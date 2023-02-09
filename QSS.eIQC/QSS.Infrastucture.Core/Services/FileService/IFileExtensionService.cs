using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace QSS.eIQC.Infrastucture.Core.Services.FileService
{
	public interface IFileExtensionService
	{
		/// <summary>
		/// Move files to different location, e.g. temporal to final destination
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <param name="id">id attachment</param>
		/// <param name="targetKey">key</param>
		/// <returns><see cref="string"/></returns>
		public string MoveFileToPermanentStorage(string fileName, string id, string targetKey);
		/// <summary>
		/// Get memory stream file form temp file
		/// </summary>
		/// <param name="filePath">path or key</param>
		/// <param name="fileName">filename</param>
		/// <returns>file memory stream <see cref="MemoryStream"/></returns>
		Task<MemoryStream> GetTempFileAsync(string filePath, string fileName);
		/// <summary>
		/// Get memory stream file form s3
		/// </summary>
		/// <param name="key">key</param>
		/// <param name="fileName">file name</param>
		/// <returns></returns>
		Task<MemoryStream> GetFileAsync(string key, string fileName);
		/// <summary>
		/// Delete temporal attachment
		/// </summary>
		/// <param name="key">key</param>
		/// <param name="fileName">file name</param>
		void DeleteTemporalFile(string key, string fileName);
		/// <summary>
		/// List all key/files in a s3 bucket
		/// </summary>
		/// <param name="key">key</param>
		/// <returns>ListFilesResponse<see cref="ListFilesResponse"/></returns>
		Task<IEnumerable<ListFilesResponse>> ListFiles(string key);
		/// <summary>
		/// Upload presigned file
		/// </summary>
		/// <param name="file">file</param>
		/// <param name="folder">folder</param>
		/// <returns></returns>
		Task<AddSingleFileResponse> UploadFilePreSignedUrl(IFormFile file, string folder);

		/// <summary>
		/// Generates pre signed url
		/// </summary>
		/// <param name="key">file url</param>
		/// <param name="filename">file name</param>
		/// <returns>link</returns>
		AddSingleFileResponse GetPreSignedUrlForDownload(string key, string filePath, string fileName, bool isPermanentfile);

		AddSingleFileResponse GetPreSignedUrlForUpload(string folder, string fileName);


	}
}
