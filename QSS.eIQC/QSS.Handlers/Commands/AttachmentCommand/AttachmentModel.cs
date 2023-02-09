using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.AttachmentCommand
{
	/// <summary>
	/// Representation model for Attachment entity
	/// </summary>
	public class AttachmentModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set SavePath property
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// Get or set TempSavePath property
        /// </summary>
        public string TempSavePath { get; set; }

        /// <summary>
        /// Get or set Template property
        /// </summary>
        public string Template { get; set; }
    }
}
