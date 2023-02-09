using Microsoft.AspNetCore.Http;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Interfaces
{
	public interface IFilesRepository
	{


		/// <summary>
		/// List all key/files in a s3 bucket
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <returns>ListFilesResponse<see cref="ListFilesResponse"/></returns>
		Task<IEnumerable<ListFilesResponse>> ListFiles(string bucketName, string key);

		/// <summary>
		/// Download file from s3 to local temp folder
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="temporalPathAndFileName">temporal path to download</param>
		/// <param name="key">s3 key: path</param>
		/// <returns>task just to download file</returns>
		Task DownloadFile(string bucketName, string temporalPathAndFileName, string key);

		/// <summary>
		/// Delete file from s3
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="fileName">file name /key</param>
		/// <returns>DeleteFileResponse<see cref="DeleteFileResponse"/></returns>
		Task<DeleteFileResponse> DeleteFile(string bucketName, string key);

		/// <summary>
		/// Get file from s3 bucket
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="key">s3 key -  path + file name</param>
		/// <returns><see cref="MemoryStream"/>Memory file object</returns>
		Task<MemoryStream> DownloadMemoryStreamAsync(string bucketName, string key);

		/// <summary>
		/// Add json object
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="request">object request</param>
		Task AddJsonObject(string bucketName, AddJsonObjectRequest request);

		/// <summary>
		/// Get json object
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="fileName">file name</param>
		/// <returns>GetJsonObjectResponse<see cref="GetJsonObjectResponse"/></returns>
		Task<GetJsonObjectResponse> GetJsonObject(string bucketName, string fileName);

		AddSingleFileResponse GetPreSignedUrl(string bucketName, string key, DateTime expirationTime);

		AddSingleFileResponse GetPreSignedUrlForUpload(string bucketName, string key, DateTime expirationTime);
		/// <summary>
		/// Copy a file or key to another location
		/// </summary>
		/// <param name="sourceBucket">source bucket name</param>
		/// <param name="sourceKey">source key</param>
		/// <param name="targetBucket">target bucket name</param>
		/// <param name="targetKey">traget key</param>
		/// <returns>target key</returns>
		Task CopyKey(string sourceBucket, string sourceKey, string targetBucket, string targetKey);

		/// <summary>
		/// Upload files
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="formFiles">files</param>
		/// <param name="key">s3 key</param>
		/// <returns>AddFileResponse<see cref="AddFileResponse"/></returns>
		Task<AddFileResponse> UploadFiles(string bucketName, string key = "", params IFormFile[] formFiles);
	}
}
