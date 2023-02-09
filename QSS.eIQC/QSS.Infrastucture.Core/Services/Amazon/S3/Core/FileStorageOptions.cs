using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core
{
	/// <summary>
	/// File management options
	/// </summary>
	public class FileStorageOptions
	{
		/// <summary>
		/// location to save file temporally
		/// </summary>
		public string DownloadTemporalFolder { get; set; }
		/// <summary>
		/// Bucket name
		/// </summary>
		public string Bucket { get; set; }
		/// <summary>
		/// Root folder
		/// </summary>
		public string Root { get; set; }
		/// <summary>
		/// upload key
		/// </summary>
		public string UploadTemporalFolder { get; set; }
		/// <summary>
		/// final destination
		/// </summary>
		public string UploadFolder { get; set; }
		/// <summary>
		/// targets
		/// </summary>
		public Targets Targets { get; set; }
	}
	/// <summary>
	/// configured paths
	/// </summary>
	public class Targets
	{
		/// <summary>
		/// issue attachments
		/// </summary>
		public string Issues { get; set; }
	}
}
