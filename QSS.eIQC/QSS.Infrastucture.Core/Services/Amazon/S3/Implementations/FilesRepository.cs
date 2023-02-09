using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File;
using QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Microsoft.Extensions.Logging;

namespace QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Implementations
{
	public class FilesRepository : IFilesRepository
    {
        private readonly SessionAwsCredentialsOptions _sessionAwsCredentialsOptions;
        private readonly IAmazonS3 _s3Client;
        private readonly ILogger<FilesRepository> _logger;

		public FilesRepository(
	        IAmazonS3 s3Client,
            IOptions<SessionAwsCredentialsOptions> sessionAwsCredentialsOptions,
	        ILogger<FilesRepository> logger)
		{
			var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

			_logger = logger;
			_sessionAwsCredentialsOptions = sessionAwsCredentialsOptions.Value;
			if (env.Contains("Local"))
			{
				// TODO: we must improve this client initialization, this code commented is just to test in the local environment. create a temporal session to test locally, use SSO temporal keys, update these keys in app settings
				SessionAWSCredentials tempCredentials = new SessionAWSCredentials(_sessionAwsCredentialsOptions.AwsAccessKeyId,
				 _sessionAwsCredentialsOptions.AwsSecretAccessKey,
				 _sessionAwsCredentialsOptions.Token);
				_s3Client = new AmazonS3Client(tempCredentials, RegionEndpoint.APSoutheast1);
			}
			else
			{
				// TODO: example using IAM keys
				// IAM
				//var credentials = new BasicAWSCredentials(_sessionAwsCredentialsOptions.AwsAccessKeyId, _sessionAwsCredentialsOptions.AwsSecretAccessKey);
				//_s3Client = new AmazonS3Client(RegionEndpoint.APSoutheast1);

				// TODO: using IAM role, deployed to development, staging or production
				_s3Client = s3Client;
			}
        }

        private static async Task<SessionAWSCredentials> GetTemporaryCredentialsAsync()
        {
            using (var stsClient = new AmazonSecurityTokenServiceClient())
            {
                var getSessionTokenRequest = new GetSessionTokenRequest
                {
                    DurationSeconds = 7200 // seconds
                };

                GetSessionTokenResponse sessionTokenResponse =
                    await stsClient.GetSessionTokenAsync(getSessionTokenRequest);

                Credentials credentials = sessionTokenResponse.Credentials;

                var sessionCredentials =
                    new SessionAWSCredentials(credentials.AccessKeyId,
                        credentials.SecretAccessKey,
                        credentials.SessionToken);
                return sessionCredentials;
            }
        }

        /// <summary>
        /// Add json object
        /// </summary>
        /// <param name="bucketName">bucket name</param>
        /// <param name="request">object request</param>
        public async Task AddJsonObject(string bucketName, AddJsonObjectRequest request)
        {
	        var createdOnUtc = DateTime.UtcNow;

	        var s3Key = $"{createdOnUtc:yyyy}/{createdOnUtc:MM}/{createdOnUtc:dd}/{request.Id}";

	        var putObjectRequest = new PutObjectRequest
	        {
		        BucketName = bucketName,
		        Key = s3Key,
		        ContentBody = JsonConvert.SerializeObject(request),
	        };

	        await _s3Client.PutObjectAsync(putObjectRequest);
        }

        /// <summary>
        /// Copy a file or key to another location
        /// </summary>
        /// <param name="sourceBucket">source bucket name</param>
        /// <param name="sourceKey">source key</param>
        /// <param name="targetBucket">target bucket name</param>
        /// <param name="targetKey">traget key</param>
        /// <returns>target key</returns>
        public async Task CopyKey(string sourceBucket, string sourceKey, string targetBucket, string targetKey)
        {
			try
			{
				CopyObjectRequest request = new CopyObjectRequest
				{
					SourceBucket = sourceBucket,
					SourceKey = "/" + sourceKey,
					DestinationBucket = targetBucket,
					DestinationKey = "/" + targetKey,
					CannedACL = S3CannedACL.BucketOwnerFullControl
				};
				CopyObjectResponse response = await _s3Client.CopyObjectAsync(request);
			}
			catch (AmazonS3Exception e)
			{
				Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
			}
		}



        /// <summary>
        /// Delete file from s3
        /// </summary>
        /// <param name="bucketName">bucket name</param>
        /// <param name="key">file name /key</param>
        /// <returns>DeleteFileResponse<see cref="DeleteFileResponse"/></returns>
        public async Task<DeleteFileResponse> DeleteFile(string bucketName, string key)
        {
	        var multiObjectDeleteRequest = new DeleteObjectsRequest
	        {
		        BucketName = bucketName
	        };


			multiObjectDeleteRequest.AddKey(key);

	        var response = await _s3Client.DeleteObjectsAsync(multiObjectDeleteRequest);

	        return new DeleteFileResponse
	        {
		        NumberOfDeletedObjects = response.DeletedObjects.Count
	        };
        }

		/// <summary>
		/// Download file from s3 to local temp folder
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="temporalPathAndFileName">temporal path to download</param>
		/// <param name="key">s3 key: path</param>
		/// <returns>task just to download file</returns>
		public async Task DownloadFile(string bucketName, string temporalPathAndFileName, string key)
        {
	        try
	        {
		        var downloadRequest = new TransferUtilityDownloadRequest
		        {
			        BucketName = bucketName,
			        Key = key,
			        FilePath = temporalPathAndFileName
		        };

		        using var transferUtility = new TransferUtility(_s3Client);
		        await transferUtility.DownloadAsync(downloadRequest);
			}
			catch (AmazonS3Exception e)
	        {
		        _logger.LogError("Error encountered on server. Message:'{0}' when writing an object", e.Message);
	        }
	        catch (Exception e)
	        {
		        _logger.LogError("Download fail", e.Message);
	        }
			
        }

		/// <summary>
		/// Get file from s3 bucket
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="key">s3 key -  path + file name</param>
		/// <returns><see cref="MemoryStream"/>Memory file object</returns>
		public async Task<MemoryStream> DownloadMemoryStreamAsync(string bucketName, string key)
		{
			if(!string.IsNullOrEmpty(key))
            {
				key = key.Replace("/ /", "/");
			}
			var memory = new MemoryStream();
			try
			{
				var streamRequest = new TransferUtilityOpenStreamRequest
				{
					BucketName = bucketName,
					Key = key
				};

				var request = new GetObjectRequest()
				{
					BucketName = bucketName,
					Key = key
				};
				_logger.LogInformation("Bucket Name" + bucketName);
				_logger.LogInformation("Key Name" + key);
				using (var transferUtility = new TransferUtility(_s3Client))
				{
					var objectResponse = await transferUtility.S3Client.GetObjectAsync(request);

					var stream = objectResponse.ResponseStream;

					await stream.CopyToAsync(memory);
				}

				memory.Position = 0;

				return memory;
			}
			catch (AmazonS3Exception e)
			{
				_logger.LogError("Error encountered on server. Message:'{0}' when writing an object", e.Message);
			}
			catch (Exception e)
			{
				_logger.LogError("Download fail", e.Message);
			}

			return memory;
		}

		/// <summary>
		/// Get json object
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="fileName">file name</param>
		/// <returns>GetJsonObjectResponse<see cref="GetJsonObjectResponse"/></returns>
		public async Task<GetJsonObjectResponse> GetJsonObject(string bucketName, string fileName)
        {
	        var request = new GetObjectRequest
	        {
		        BucketName = bucketName,
		        Key = fileName
	        };

	        var response = await _s3Client.GetObjectAsync(request);

	        using (var reader = new StreamReader(response.ResponseStream))
	        {
		        var contents = reader.ReadToEnd();
		        return JsonConvert.DeserializeObject<GetJsonObjectResponse>(contents);
	        }
        }

        /// <summary>
        /// List all key/files in a s3 bucket
        /// </summary>
        /// <param name="bucketName">bucket name</param>
        /// <returns>ListFilesResponse<see cref="ListFilesResponse"/></returns>
        public async Task<IEnumerable<ListFilesResponse>> ListFiles(string bucketName, string key)
        {
			var responses = await _s3Client.ListObjectsAsync(bucketName);

	        return responses.S3Objects.Where(x=>x.Key.Contains(key)).Select(b => new ListFilesResponse
	        {
		        BucketName = b.BucketName,
		        Key = b.Key,
		        Owner = b.Owner.DisplayName,
		        Size = b.Size,
		        LastModified = b.LastModified,
		        StorageClass = b.StorageClass
	        });
        }

        /// <summary>
        /// Upload files
        /// </summary>
        /// <param name="bucketName">bucket name</param>
        /// <param name="formFiles">files</param>
        /// <param name="key">s3 key</param>
        /// <returns>AddFileResponse<see cref="AddFileResponse"/></returns>
        public async Task<string> UploadFile(string bucketName, IFormFile formFiles, string key)
        {
	        try
	        {
		        var uploadRequest = new TransferUtilityUploadRequest
		        {
			        InputStream = formFiles.OpenReadStream(),
			        Key = key + formFiles.FileName,
			        BucketName = bucketName,
			        CannedACL = S3CannedACL.NoACL
		        };

		        using (var fileTransferUtility = new TransferUtility(_s3Client))
		        {
			        await fileTransferUtility.UploadAsync(uploadRequest);
		        }

		        var expiryUrlRequest = new GetPreSignedUrlRequest
		        {
			        BucketName = bucketName,
			        Key = key + formFiles.FileName,
			        Expires = DateTime.Now.AddDays(1)
		        };

		        return expiryUrlRequest.Key; 
		        // TODO: Improve this url: _s3Client.GetPreSignedURL(expiryUrlRequest);
	        }
	        catch (Exception e)
	        {
				_logger.LogError("Upload file fail", e);
				return "";
	        }
        }

		/// <summary>
		/// Upload files
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="formFiles">files</param>
		/// <param name="key">s3 key</param>
		/// <returns>AddFileResponse<see cref="AddFileResponse"/></returns>
		public async Task<AddFileResponse> UploadFiles(string bucketName, string key = "", params IFormFile[] formFiles) // (string bucketName, string key, params IFormFile[] formFiles)
        {
	        var response = new List<AddSingleFileResponse>();
            try
	        {
		        foreach (var file in formFiles)
		        {
					var uploadRequest = new TransferUtilityUploadRequest
					{
						BucketName = bucketName,
						Key = key + file.FileName,
						InputStream = file.OpenReadStream(),
						StorageClass = S3StorageClass.Standard,
						CannedACL = S3CannedACL.PublicRead,
						ContentType = file.ContentType,
					
					};

					using (var fileTransferUtility = new TransferUtility(_s3Client))
					{
						await fileTransferUtility.UploadAsync(uploadRequest);
					}
					
					response.Add(GetPreSignedUrl(bucketName, key + file.FileName, DateTime.Now.AddDays(1)));
		        }
	        }
            catch (AmazonS3Exception e)
            {
	            _logger.LogError("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
			catch (Exception e)
	        {
		        _logger.LogError("Upload files fail", e.Message);
            }

            return new AddFileResponse
            {
	            FileData = response
            };
        } 

		/*
		public async Task<AddFileResponse> UploadFiles(string bucketName, string keyName = "", params IFormFile[] formFiles)
		{
			var response = new List<AddSingleFileResponse>();
			// Create list to store upload part responses.
			List<UploadPartResponse> uploadResponses = new List<UploadPartResponse>();

			foreach (var file in formFiles)
			{
				try
				{

					// Setup information required to initiate the multipart upload.
					InitiateMultipartUploadRequest initiateRequest = new InitiateMultipartUploadRequest
					{
						BucketName = bucketName,
						Key = keyName + file.FileName
					};
					// Initiate the upload.
					InitiateMultipartUploadResponse initResponse =
						await _s3Client.InitiateMultipartUploadAsync(initiateRequest);

					// Upload parts.
					long contentLength = file.Length;
					long partSize = 5 * (long)Math.Pow(2, 20); // 5 MB


					long filePosition = 0;
					for (int i = 1; filePosition < contentLength; i++)
					{
						UploadPartRequest uploadRequest = new UploadPartRequest
						{
							BucketName = bucketName,
							Key = keyName + file.FileName ,
							UploadId = initResponse.UploadId,
							PartNumber = i,
							PartSize = partSize,
							FilePosition = filePosition,
							InputStream = file.OpenReadStream(),
						};

						// Track upload progress.
						uploadRequest.StreamTransferProgress +=
							new EventHandler<StreamTransferProgressArgs>(UploadPartProgressEventCallback);

						// Upload a part and add the response to our list.
						uploadResponses.Add(await _s3Client.UploadPartAsync(uploadRequest));

						filePosition += partSize;
					}

					// Setup to complete the upload.
					CompleteMultipartUploadRequest completeRequest = new CompleteMultipartUploadRequest
					{
						BucketName = bucketName,
						Key = keyName + file.FileName,
						UploadId = initResponse.UploadId
					};
					completeRequest.AddPartETags(uploadResponses);

					// Complete the upload.
					CompleteMultipartUploadResponse completeUploadResponse =
						await _s3Client.CompleteMultipartUploadAsync(completeRequest);

					response.Add(GetPreSignedUrl(bucketName, keyName + file.FileName, DateTime.Now.AddDays(1)));
				}
				catch (Exception exception)
				{
				}

			}

			return new AddFileResponse
			{
				FileData = response
			};

		} 
		public static void UploadPartProgressEventCallback(object sender, StreamTransferProgressArgs e)
		{
			// Process event. 
			Console.WriteLine("{0}/{1}", e.TransferredBytes, e.TotalBytes);
		} */


		/// <summary>
		/// Generate presigned url
		/// </summary>
		/// <param name="bucketName">bucket name</param>
		/// <param name="key">file key</param>
		/// <param name="expirationTime">time to expire url</param>
		/// <returns></returns>
		public AddSingleFileResponse GetPreSignedUrl(string bucketName, string key, DateTime expirationTime)
		{
			var expiryUrlRequest = new GetPreSignedUrlRequest
			{
				BucketName = bucketName,
				Key = key,
				Expires = expirationTime
			};

			var url = _s3Client.GetPreSignedURL(expiryUrlRequest);

			var response = new AddSingleFileResponse()
			{
				PreSignedUrl = url, // temporal download url
				Key = key // Internal reference s3 key
			};

			return response;
		}

		public AddSingleFileResponse GetPreSignedUrlForUpload(string bucketName, string key, DateTime expirationTime)
		{
			var expiryUrlRequest = new GetPreSignedUrlRequest
			{
				BucketName = bucketName,
				Key = key,
				Expires = expirationTime,
				Verb = HttpVerb.PUT,

			};

			var url = _s3Client.GetPreSignedURL(expiryUrlRequest);

			var response = new AddSingleFileResponse()
			{
				PreSignedUrl = url, // temporal download url
				Key = key // Internal reference s3 key
			};

			return response;
		}
	}
}
