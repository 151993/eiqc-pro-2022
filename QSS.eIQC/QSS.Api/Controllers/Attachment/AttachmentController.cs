using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.FileService;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.AttachmentCommand.Add;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static QSS.eIQC.Api.Extensions.DependencyInjection.DependencyInjectionExtension;
using QSS.eIQC.Domain.Common;
using System.Net;
using System.IO;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File;

namespace QSS.Controllers
{

    /// <summary>
    /// Manage attachment files
    /// </summary>
    [Route("api/attachment")]
    [ApiController]
    public class AttachmentController : BaseController
    {
        private readonly IFileService _fileService;
        private readonly IQSSContext _context;
        private readonly IFileExtensionService _fileExtensionService;
        private readonly IMapper _mapper;

        public AttachmentController(
            ILogger<AttachmentController> logger,
            IMediator mediator,
            IHttpContextAccessor contextAccessor,
            StorageServiceResolver storageServiceAccessor,
            IQSSContext context,
            IFileExtensionService fileExtensionService,
            IMapper mapper
        ) : base(mediator, logger, contextAccessor)
        {
            _fileService = storageServiceAccessor(ServiceStorageEnum.Aws);
            _context = context;
            _fileExtensionService = fileExtensionService;
            _mapper = mapper;
        }

        /// <summary>
        /// This endpoint upload Attachment.
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        [HttpPost, DisableRequestSizeLimit]
        [Route("UploadFile/{folderName}")]
        [SwaggerOperation(Summary = "Upload Attachment", Description = "This endpoint upload Attachment.")]
        public async Task<IActionResult> Upload(string folderName)
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileData = await _fileExtensionService.UploadFilePreSignedUrl(file, folderName);
                if (fileData != null)
                {
                    if (string.IsNullOrEmpty(fileData.Key))
                        return BadRequest();

                    return Ok(new { Result = fileData.Key, PreSignedUrl = fileData.PreSignedUrl });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex}");
            }
        }

        /// <summary>
        /// This endpoint download Attachment.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DownloadFile")]
        [SwaggerOperation(
            Summary = "Download Attachment",
            Description = "This endpoint download Attachment.")]
        public async Task<IActionResult> Download(DownloadAttachmentModel request)
        {
            if (!string.IsNullOrEmpty(request.Id))
            {
                var memory = await _fileExtensionService.GetFileAsync(request.SavePath, request.Name);
                var mimeType = _fileService.GetMimeType(request.SavePath);
                return File(memory, mimeType, request.Name);
            }
            else
            {
                var memory = await _fileExtensionService.GetTempFileAsync(request.SavePath,string.Empty);
                var mimeType = _fileService.GetMimeType(request.Name);
                return File(memory, mimeType, request.Name);
            }
        }

        /// <summary>
        /// This endpoint downloads a compressed zip folder containing attachments.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DownloadAllFiles")]
        [SwaggerOperation(Summary = "Download files", Description = "This endpoint downloads a compressed zip folder containing attachments.")]
        public async Task<IActionResult> DownloadAllFiles(DownloadAttachmentModel[] request)
        {
            List<string> filePaths = new List<string>();
            List<string> fileNames = new List<string>();
            foreach (DownloadAttachmentModel item in request)
            {
                if (!string.IsNullOrEmpty(item.Id))
                {
                    var attachment = _context.Attachment.Where(a => a.Id.ToString() == item.Id).FirstOrDefault();
                    filePaths.Add(_fileService.GetFullFilePath(attachment.SavePath, false));
                    fileNames.Add(item.Name);

                }
                else
                {
                    filePaths.Add($"{Path.GetDirectoryName(item.SavePath).Replace("\\", "/")}/");
                    fileNames.Add(item.Name);
                }
            }

            var compressedResult = await _fileService.GetCompressedFolderDownloadAsync(filePaths.ToArray(), fileNames.ToArray());

            var mimeType = _fileService.GetMimeType(compressedResult.fileName);
            
            return File(compressedResult.fileBytes, mimeType, compressedResult.fileName);

        }

        /// <summary>
        /// This endpoint remove temp folder.
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteTempFolder")]
        [SwaggerOperation(Summary = "Delete Temp Folder", Description = "This endpoint remove temp folder.")]
        public IActionResult DeleteTempFolder(string folder)
        {
            try
            {
                _fileService.DeleteTempFolder(folder);
                return Ok(new { Result = "Delete Success" });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// POST action method to add a new problem configuration by means of a CSV file
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        [HttpPost, DisableRequestSizeLimit]
        [Route("UploadFileCsv/{folderName}")]
        [SwaggerOperation(
            Summary = "Upload Attachment attachment",
            Description = "This endpoint upload Attachment attachment.")]
        public IActionResult UploadCsv(string folderName)
        {
            try
            {
                return this.ExecuteMediatrRequest(new AttachmentInputModel()
                {
                    FolderName = folderName,
                    ContenFile = Request.Form.Files[0].OpenReadStream(),

                }).Result;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex}");
            }
        }

        /// <summary>
        /// This endpoint remove temp folder.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteFile")]
        [SwaggerOperation(Summary = "Delete file", Description = "This endpoint remove file.")]
        public IActionResult DeleteFile(DeleteAttachmentModel file)
        {
            try
            {
                if (file.Id > 0)
                {
                    var attachment = _context.Attachment.Where(a => a.Id.ToString() == file.Id.ToString()).FirstOrDefault();
                    _fileService.DeleteFile(file.Name, attachment.Id.ToString());
                    return Ok(new { Result = "Delete Success" });
                }
                else
                {
                    _fileExtensionService.DeleteTemporalFile(file.SavePath, file.Name);
                    return Ok(new { Result = "Delete Success" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// List file in s3 bucket
        /// </summary>
        /// <param name="key">key in s3</param>
        /// <returns></returns>
        [HttpGet]
        [Route("ListFiles")]
        public async Task<IActionResult> ListFiles(string key)
        {
            try
            {
                return Ok(await _fileExtensionService.ListFiles(key));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Get presigned url
        /// </summary>
        /// <param name="attachmentId">attachment id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPreSignedUrl")]
        public async Task<IActionResult> GetPreSignedUrl(string attachmentId,string filePath, string fileName, bool isUploadRequest, bool isPermanentfile)
        {
            try
            {
                AddSingleFileResponse response = null;
                if (!string.IsNullOrEmpty(attachmentId))
                {
                    if(isUploadRequest)
                    {
                        response = _fileExtensionService.GetPreSignedUrlForUpload(attachmentId, fileName);
                    }
                    else
                    {
                        response = _fileExtensionService.GetPreSignedUrlForDownload(attachmentId, filePath, fileName, isPermanentfile);
                    }
                    
                    return Ok(response);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"Internal server error: {ex.Message}");
            }
        }


        /// <summary>
        /// Retrieve Attachment by id
        /// </summary>
        /// <param name="id"> Attachment id <see cref="int"/></param>
        /// <returns>Attachment detail <see cref="AttachmentModel"/></returns>
        [HttpGet, Route("{id}")]
        [EnableQueryFromODataToAWS]
        public async Task<IQueryable<AttachmentModel>> GetAttachmentById(int id)
        {

            return _context.Attachment.Where(d => d.Id == id)
                .ProjectTo<AttachmentModel>(_mapper.ConfigurationProvider).AsQueryable();
        }

        /// <summary>
        /// Retrieve Attachment list with enabled elements
        /// </summary>
        /// <returns>Attachment list<see cref="AttachmentModel"/></returns>
        [HttpGet, Route("")]
        [EnableQueryFromODataToAWS]
        public async Task<IQueryable<AttachmentModel>> GetAttachment()
        {
            return _context.Attachment.ProjectTo<AttachmentModel>(_mapper.ConfigurationProvider).AsQueryable();
        }
    }
}
