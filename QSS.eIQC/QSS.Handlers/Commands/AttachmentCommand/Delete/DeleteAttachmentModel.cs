using System;
using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.AttachmentCommand.Add
{
	/// <summary>
	/// Representation model for Add site operation
	/// </summary>
	public class DeleteAttachmentModel : BaseCommand, IRequest<AttachmentModel>
    {
	    /// <summary>
	    /// Attachment Id
	    /// </summary>
	    public int Id { get; set; }

		/// <summary>
		/// Get or set Name property
		/// </summary>
		public string Name { get; set; }

	    /// <summary>
	    /// Get or set SavePath property
	    /// </summary>
	    public string SavePath { get; set; }

	    public string TempSavePath { get; set; }
		/// <summary>
		/// LastUpdate date of the record, this field is important and mandatory to be set to avoid DBUpdateCuncurrencyException. 
		/// EF checks and throw error if value has been updated in DB.
		/// </summary>
		/// 
		public DateTimeOffset LastUpdated { get; set; }
	}
}
