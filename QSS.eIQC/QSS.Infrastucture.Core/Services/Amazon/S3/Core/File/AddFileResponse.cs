using System.Collections.Generic;

namespace QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File
{
	/// <summary>
	/// File response after upload
	/// </summary>
	public class AddFileResponse
	{
		/// <summary>
		/// file data array
		/// </summary>
		public IList<AddSingleFileResponse> FileData { get; set; }
	}

	/// <summary>
	/// file data
	/// </summary>
	public class AddSingleFileResponse
	{
		/// <summary>
		/// url pre signed
		/// </summary>
		public string PreSignedUrl { get; set; }
		/// <summary>
		/// s3 key
		/// </summary>
		public string Key { get; set; }
	}
}
