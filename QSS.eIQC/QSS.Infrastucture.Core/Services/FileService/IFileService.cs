using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace QSS.Infrastructure.Core.Services.FileService
{
    public interface IFileService
    {
	    Task<string> UploadFile(IFormFile file, string folder);

        string MoveFileToPermanentStorage(string fileName, string id);

        string SaveFileFromTemp(string filePath, string folder = "");

        Task<MemoryStream> GetFileAsync(string filePath);

        Task<MemoryStream> GetTempFileAsync(string filePath);

        /// <summary>
        /// Read file from a temporal path
        /// </summary>
        /// <param name="path">temporal path</param>
        /// <param name="fileName">file name</param>
        /// <returns><see cref="MemoryStream"/>Memory stream</returns>
        Task<MemoryStream> ReadFileAsync(string path, string fileName);

        Task<(MemoryStream stream, string fileName)> GetCompressedFolderAsync(string[] filePaths, string[] fileNames);

        Task<(byte[] fileBytes, string fileName)> GetCompressedFolderDownloadAsync(string[] filePaths, string[] fileNames);

        string GetMimeType(string fileName);

        void DeleteFile(string fileName, string id = "");

        string[] GetFilesFromTempFolder(string folderName);

        string GetFullFilePath(string filePath, bool isTemp);

        string DeleteTempFolder(string folder);
    }
}
