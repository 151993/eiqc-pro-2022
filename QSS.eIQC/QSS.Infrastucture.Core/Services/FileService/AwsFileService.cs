using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QSS.Infrastructure.Core.Services.FileService;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;

namespace QSS.eIQC.Infrastucture.Core.Services.FileService
{
	public class AwsFileService : IFileService, IFileExtensionService
	{
		private readonly ILogger<AwsFileService> _logger;

		private readonly IFilesRepository _filesRepository;

		private readonly FileStorageOptions _fileStorageOptions;

		public AwsFileService(
			ILogger<AwsFileService> logger,
			IFilesRepository filesRepository,
			IOptions<FileStorageOptions> fileStorageOptions
		)
		{
			_logger = logger;
			_filesRepository = filesRepository;
			_fileStorageOptions = fileStorageOptions.Value;
		}

		/// <summary>
		/// Delete file in storage
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <param name="id">attachment id</param>
		public void DeleteFile(string fileName, string id = "")
		{
			var key = GetFolder(id);
			var task = Task.Run(() => _filesRepository.DeleteFile(_fileStorageOptions.Bucket, key));
			task.Wait();
		}

		/// <summary>
		/// Delete temporal attachment
		/// </summary>
		/// <param name="key">key</param>
		/// <param name="fileName">file name</param>
		public void DeleteTemporalFile(string key, string fileName)
		{
			var task = Task.Run(() => _filesRepository.DeleteFile(_fileStorageOptions.Bucket, key));
			task.Wait();
		}

		public string DeleteTempFolder(string folder)
		{
			string fullPath = GetTempFolder(folder);
			if (Directory.Exists(fullPath))
			{
				Directory.Delete(fullPath, true);
			}
			return "";
		}

		public async Task<(MemoryStream stream, string fileName)> GetCompressedFolderAsync(string[] filePaths,
			string[] fileNames)
		{
			string tempFolder = GetTempFolder();

			tempFolder = Path.Combine(tempFolder, Guid.NewGuid().ToString());
			if (!Directory.Exists(tempFolder))
			{
				Directory.CreateDirectory(tempFolder);
			}

			for (int i = 0; i < filePaths.Length && i < fileNames.Length; i++)
			{
				string fileName = fileNames[i];

				string newFilePath = Path.Combine(tempFolder, fileName);

				if (File.Exists(newFilePath))
				{
					File.Delete(newFilePath);
				}

				var mStream = await this.GetTempFileAsync(filePaths[i], fileName);
				using (var fs = new FileStream(newFilePath, FileMode.Create))
				{
					mStream.CopyTo(fs);
					mStream.Close();
				}
			}

			string zipFileName = new DirectoryInfo(Path.GetDirectoryName(filePaths[0])).Name;

			string downloadFileAlias = String.Format("{0}.zip", string.IsNullOrEmpty(zipFileName) ? ("download_" + DateTime.Now.Ticks.ToString()) : zipFileName);

			string downloadFilePath = Path.Combine(_fileStorageOptions.DownloadTemporalFolder, downloadFileAlias);

			ZipFile.CreateFromDirectory(tempFolder, downloadFilePath);

			var memory = new MemoryStream();
			using (var stream = new FileStream(downloadFilePath, FileMode.Open))
			{
				await stream.CopyToAsync(memory);
			}
			memory.Position = 0;

			File.Delete(downloadFilePath);
			Directory.Delete(tempFolder, true);

			return (memory, downloadFileAlias);
		}
		public Task<MemoryStream> GetFileAsync(string filePath)
		{
			var fileMemoryStream = Task.Run(() =>
				_filesRepository.DownloadMemoryStreamAsync(_fileStorageOptions.Bucket, filePath)
			);
			fileMemoryStream.Wait();

			return fileMemoryStream;
		}

		/// <summary>
		/// Get memory stream file form s3DeleteTemporalFile
		/// </summary>
		/// <param name="key">key</param>
		/// <param name="fileName">file name</param>
		/// <returns></returns>
		public Task<MemoryStream> GetFileAsync(string key, string fileName)
		{
			key = Path.Combine(GetFolder(), key);
			string fullTemporalPath = Path.Combine(GetTemporalDownloadFolder(), fileName);

			var fileMemoryStream = Task.Run(() =>
				_filesRepository.DownloadMemoryStreamAsync(_fileStorageOptions.Bucket, $"{key}/{fileName}")
			);
			fileMemoryStream.Wait();

			return fileMemoryStream;
		}

		public string[] GetFilesFromTempFolder(string folderName)
		{
			throw new NotImplementedException();
		}

		public string GetFullFilePath(string filePath, bool isTemp)
		{
			string rootFolder = _fileStorageOptions.Root;
			string key = $"{rootFolder}{filePath}";
			return key.Equals(string.Empty) ? key : $"{key}/";
		}

		/// <summary>
		/// get mime type of file stream downloaded
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public string GetMimeType(string fileName)
		{
			var provider = new FileExtensionContentTypeProvider();
			string contentType;
			if (!provider.TryGetContentType(fileName, out contentType))
			{
				contentType = "application/octet-stream";
			}
			return contentType;
		}

		/// <summary>
		/// Generates pre signed url
		/// </summary>
		/// <param name="key">file url</param>
		/// <param name="filename">file name</param>
		/// <returns>link</returns>
		public AddSingleFileResponse GetPreSignedUrlForDownload(string folder,string filePath, string fileName, bool isPermanentfile)
		{
			string key = String.Empty;
			string rootFolder = _fileStorageOptions.Root;
			string tempFolder = _fileStorageOptions.UploadTemporalFolder;

			 key = isPermanentfile ? $"{rootFolder}{filePath}" : $"{rootFolder}{tempFolder}{folder}" ;

			var fileData = _filesRepository.GetPreSignedUrl(_fileStorageOptions.Bucket, $"{key}/{fileName}",
				DateTime.Now.AddDays(1));
			return fileData;
		}

		public AddSingleFileResponse GetPreSignedUrlForUpload(string folder, string fileName)
		{

			string rootFolder = _fileStorageOptions.Root;
			string tempFolder = _fileStorageOptions.UploadTemporalFolder;

			string key = $"{rootFolder}{tempFolder}{folder}";

			var fileData = _filesRepository.GetPreSignedUrlForUpload(_fileStorageOptions.Bucket, $"{key}/{fileName}",
				DateTime.UtcNow.AddDays(1));
			return fileData;
		}

		public Task<MemoryStream> GetTempFileAsync(string filePath)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get memory stream file form temp file
		/// </summary>
		/// <param name="filePath">path or key</param>
		/// <param name="fileName">filename</param>
		/// <returns>file memory stream <see cref="MemoryStream"/></returns>
		public Task<MemoryStream> GetTempFileAsync(string filePath, string fileName)
		{
			string fullPath = Path.Combine(filePath, fileName);

			var fileMemoryStream = Task.Run(() =>
				_filesRepository.DownloadMemoryStreamAsync(_fileStorageOptions.Bucket, fullPath)
			);
			fileMemoryStream.Wait();

			return fileMemoryStream;
		}

		/// <summary>
		/// Remove file from a location
		/// </summary>
		/// <param name="path">file path</param>
		/// <param name="fileName">file name</param>
		public void RemoveFileInServer(string path, string fileName)
		{
			var fullPath = Path.Combine(path, fileName);

			if (System.IO.File.Exists(fullPath))
			{
				Thread.Sleep(1);
				System.IO.File.Delete(fullPath);
			}
		}

		public string MoveFileToPermanentStorage(string fileName, string id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Move files to different location, e.g. temporal to final destination
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <param name="id">id attachment</param>
		/// <param name="targetKey">key</param>
		/// <returns><see cref="string"/></returns>
		public string MoveFileToPermanentStorage(string fileName, string id, string targetKey)
		{
			try
			{
				string target = Path.Combine(_fileStorageOptions.Root, $"{targetKey}/{fileName}");
				_filesRepository.CopyKey(_fileStorageOptions.Bucket, id, _fileStorageOptions.Bucket, target);
				return target;
			}
			catch (Exception e)
			{
				_logger.LogError("File Uploaded Fails", e);
				return string.Empty;
			}
		}

		/// <summary>
		/// Read file from a temporal path
		/// </summary>
		/// <param name="path">temporal path</param>
		/// <param name="fileName">file name</param>
		/// <returns><see cref="MemoryStream"/>Memory stream</returns>
		public async Task<MemoryStream> ReadFileAsync(string path, string fileName)
		{
			string fullPath = Path.Combine(path, fileName);

			if (!System.IO.File.Exists(fullPath))
			{
				throw new FileNotFoundException();
			}

			var memory = new MemoryStream();

			await using (var stream = new FileStream(fullPath, FileMode.Open)) // File.Open(fullPath, FileMode.Open, FileAccess.Write, FileShare.Read))
			{
				await stream.CopyToAsync(memory);
			}
			memory.Position = 0;

			return memory;
		}

		public string SaveFileFromTemp(string filePath, string folder = "")
		{
			throw new NotImplementedException();
		}


		public async Task<string> UploadFile(IFormFile file, string folder)
		{
			string bucketName = _fileStorageOptions.Bucket;
			string rootFolder = _fileStorageOptions.Root;
			string tempFolder = _fileStorageOptions.UploadTemporalFolder;

			string key = $"{rootFolder}{tempFolder}{folder}";

			var fullKey = key.Equals(string.Empty) ? key : $"{key}/";


			var task = await _filesRepository.UploadFiles(bucketName, fullKey, file);

			var PreSignedUrl = task.FileData[0].PreSignedUrl.Substring(rootFolder.Length + tempFolder.Length);

			return PreSignedUrl;
		}

		/// <summary>
		/// Upload presigned file
		/// </summary>
		/// <param name="file">file</param>
		/// <param name="folder">folder</param>
		/// <returns></returns>
		public async Task<AddSingleFileResponse> UploadFilePreSignedUrl(IFormFile file, string folder)
		{
			string bucketName = _fileStorageOptions.Bucket;
			string rootFolder = _fileStorageOptions.Root;
			string tempFolder = _fileStorageOptions.UploadTemporalFolder;

			string key = $"{rootFolder}{tempFolder}{folder}";

			var fullKey = key.Equals(string.Empty) ? key : $"{key}/";



			//var task = await _filesRepository.UploadObjectAsync(bucketName, fullKey, file);
			var task = await _filesRepository.UploadFiles(bucketName, fullKey, file);

			return task.FileData[0];
		}

		/// <summary>
		/// List all key/files in a s3 bucket
		/// </summary>
		/// <param name="key">key</param>
		/// <returns>ListFilesResponse<see cref="ListFilesResponse"/></returns>
		public async Task<IEnumerable<ListFilesResponse>> ListFiles(string key)
		{
			key = GetFolder(key);
			return await _filesRepository.ListFiles(_fileStorageOptions.Bucket, key);
		}


		/// <summary>
		/// Get folder to download file to read async
		/// </summary>
		/// <returns></returns>
		private string GetTemporalDownloadFolder()
		{
			return _fileStorageOptions.DownloadTemporalFolder;
		}

		/// <summary>
		/// get temporal folder to upload, before to asve and move it to final destination
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private string GetTempFolder(string id = "")
		{
			string rootPath = _fileStorageOptions.Root;
			string folder = _fileStorageOptions.UploadTemporalFolder;
			if (string.IsNullOrEmpty(id))
			{
				return Path.Combine(rootPath, folder);
			}
			else
			{
				return Path.Combine(rootPath, Path.Combine(folder, id));
			}
		}

		/// <summary>
		/// get key where all files are stores as final destination
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private string GetFolder(string id = "")
		{
			string rootPath = _fileStorageOptions.Root;
			string folder = _fileStorageOptions.UploadFolder;
			if (string.IsNullOrEmpty(id))
			{
				return Path.Combine(rootPath, folder);
			}
			else
			{
				return Path.Combine(rootPath, Path.Combine(folder, id));
			}
		}

		async Task<(byte[] fileBytes, string fileName)> IFileService.GetCompressedFolderDownloadAsync(string[] filePaths, string[] fileNames)
		{
			byte[] fileBytes = null;

			string zipFileName = new DirectoryInfo(Path.GetDirectoryName(filePaths[0])).Name;

			string downloadFileAlias = String.Format("{0}.zip", string.IsNullOrEmpty(zipFileName) ? ("download_" + DateTime.Now.Ticks.ToString()) : zipFileName);

			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ZipArchive zip = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
				{
					foreach (var file in fileNames)
					{

						var fileContent = await GetFileAsync(Path.Combine(filePaths[0], file));
						var entryName = file;

						ZipArchiveEntry zipItem = zip.CreateEntry(entryName);

						using (System.IO.Stream entryStream = zipItem.Open())
						{
							fileContent.CopyTo(entryStream);
						}
					}
				}
				fileBytes = memoryStream.ToArray();
			}
			return (fileBytes, downloadFileAlias);

		}
	}
}
