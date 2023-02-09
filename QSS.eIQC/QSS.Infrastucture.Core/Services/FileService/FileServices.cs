using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QSS.Common.Utilities.FileStorage;
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QSS.Infrastructure.Core.Services.FileService
{
    public class FileService : IFileService
    {
        IConfiguration _configuration;
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FileService> _logger;

        public CspParameters cspp = new CspParameters();
        public RSACryptoServiceProvider rsa;

        IFileStorageHelper _fileStorage;

        public FileService(IConfiguration configuration, ILogger<FileService> logger, IFileStorageHelper fileStorage)
        {
            _configuration = configuration;
            _logger = logger;
            _fileStorage = fileStorage;
        }

        public Task<string> UploadFile(IFormFile file, string folder)
        {
            string pathToSave = GetTempFolder(folder);
            string tempFolder = GetTempFolder();

            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }

            if (file != null)
            {
                var fullPath = _fileStorage.EncryptFileIFormFile(file, pathToSave);



                var task = Task.Run(() => fullPath.Substring(tempFolder.Length + 1));
                task.Wait();
                return task;
            }
            else
            {
                return null;
            }

        }

        public string MoveFileToPermanentStorage(string fileName, string id)
        {
            string pathFromSave = GetTempFolder(id);
            string pathToSave = GetFolder(id);

            var fullFromPath = Path.Combine(pathFromSave, fileName);
            var fullToPath = Path.Combine(pathToSave, fileName);

            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }

            if (File.Exists(fullFromPath))
            {
                if (File.Exists(fullToPath))
                    File.Delete(fullToPath);

                File.Move(fullFromPath, fullToPath);
            }
            return fullToPath;
        }

        public string SaveFileFromTemp(string filePath, string folder = "")
        {
            string pathFromSave = GetTempFolder();
            string pathToSave = GetFolder();
            string fullDirectory = string.IsNullOrEmpty(folder) ? pathToSave : Path.Combine(pathToSave, folder);

            var fullFromPath = Path.Combine(pathFromSave, filePath);
            var fullToPath = Path.Combine(fullDirectory, Guid.NewGuid().ToString() + Path.GetExtension(filePath));

            if (!Directory.Exists(fullDirectory))
            {
                Directory.CreateDirectory(fullDirectory);
            }

            if (File.Exists(fullFromPath))
            {
                if (File.Exists(fullToPath))
                    File.Delete(fullToPath);

                File.Move(fullFromPath, fullToPath);
            }
            return fullToPath.Substring(pathToSave.Length + 1);
        }

        public void DeleteFile(string fileName, string id = "")
        {
            var pathToSave = GetFolder(id);
            var fullToPath = Path.Combine(pathToSave, fileName);

            if (File.Exists(fullToPath))
                File.Delete(fullToPath);
        }

        public async Task<MemoryStream> GetFileAsync(string filePath)
        {
            string tempPath = GetFolder();
            string fullPath = Path.Combine(tempPath, filePath);

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException();
            }

            var memory = new MemoryStream();
            using (var stream = new FileStream(fullPath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            return memory;
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
            await using (var stream = new FileStream(fullPath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            return memory;
        }

        public async Task<MemoryStream> GetTempFileAsync(string filePath)
        {
            string tempPath = GetTempFolder();
            string fullPath = Path.Combine(tempPath, filePath);

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException();
            }

            var memory = _fileStorage.DecryptFile(fullPath);

            return memory;
        }

        public async Task<(MemoryStream stream, string fileName)> GetCompressedFolderAsync(string[] filePaths, string[] fileNames)
        {
            string tempFolder = GetTempFolder();
            string fileServerDirectoryPath = tempFolder;

            tempFolder = Path.Combine(tempFolder, Guid.NewGuid().ToString());
            if (!Directory.Exists(tempFolder))
            {
                Directory.CreateDirectory(tempFolder);
            }

            for (int i = 0; i < filePaths.Length && i < fileNames.Length; i++)
            {
                string fileFrom = filePaths[i];
                if (!File.Exists(fileFrom))
                {
                    throw new FileNotFoundException();
                }

                string fileName = fileNames[i];
                fileName = $"{Path.GetFileName(fileFrom)}";
                string newFilePath = Path.Combine(tempFolder, fileName);

                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                }

                var mStream = _fileStorage.DecryptFile(fileFrom);
                using (var fs = new FileStream(newFilePath, FileMode.Create))
                {
                    mStream.CopyTo(fs);
                    mStream.Close();
                }
            }

            string zipFileName = new DirectoryInfo(Path.GetDirectoryName(filePaths[0])).Name;

            string downloadFileAlias = String.Format("{0}.zip", string.IsNullOrEmpty(zipFileName) ? ("download_" + DateTime.Now.Ticks.ToString()) : zipFileName);

            string downloadFilePath = Path.Combine(fileServerDirectoryPath, downloadFileAlias);

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


        public async Task<(byte[] fileBytes,string fileName)> GetCompressedFolderDownloadAsync(string[] filePaths, string[] fileNames)
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
                        var fileContent = await GetFileAsync(Path.Combine(filePaths[0],file));
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

        public string[] GetFilesFromTempFolder(string folderName)
        {
            string folder = GetTempFolder(folderName);
            if (Directory.Exists(folder))
            {
                return Directory.GetFiles(folder);
            }
            else
            {
                return null;
            }
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

        public string GetFullFilePath(string filePath, bool isTemp)
        {
            string rootPath = _configuration.GetSection("AttachmentFileServer").GetSection("BasePath").Value;
            string folder = "";
            if (isTemp)
            {
                folder = _configuration.GetSection("AttachmentFileServer").GetSection("TempFolder").Value;
            }
            else
            {
                folder = _configuration.GetSection("AttachmentFileServer").GetSection("Folder").Value;
            }

            return Path.Combine(rootPath, folder, filePath);
        }

        private string GetTempFolder(string id = "")
        {
            string rootPath = _configuration.GetSection("AttachmentFileServer").GetSection("BasePath").Value;
            string folder = _configuration.GetSection("AttachmentFileServer").GetSection("TempFolder").Value;
            if (string.IsNullOrEmpty(id))
            {
                return Path.Combine(rootPath, folder);
            }
            else
            {
                return Path.Combine(rootPath, Path.Combine(folder, id));
            }
        }

        private string GetFolder(string id = "")
        {
            string rootPath = _configuration.GetSection("AttachmentFileServer").GetSection("BasePath").Value;
            string folder = _configuration.GetSection("AttachmentFileServer").GetSection("Folder").Value;
            if (string.IsNullOrEmpty(id))
            {
                return Path.Combine(rootPath, folder);
            }
            else
            {
                return Path.Combine(rootPath, Path.Combine(folder, id));
            }
        }
    }
}
