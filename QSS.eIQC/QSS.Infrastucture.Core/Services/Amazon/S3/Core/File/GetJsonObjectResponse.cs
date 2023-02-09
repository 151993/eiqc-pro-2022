using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Infrastucture.Core.Services.Amazon.S3.Core.File
{
	public class GetJsonObjectResponse
	{
		/// <summary>
		/// identifier
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// updated date
		/// </summary>
		public DateTime TimeSent { get; set; }
		/// <summary>
		/// json data
		/// </summary>
		public string Data { get; set; }
	}
}
