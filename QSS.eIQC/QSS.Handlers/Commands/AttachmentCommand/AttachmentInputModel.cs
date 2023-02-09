using System;
using System.IO;
using System.Text;
using MediatR;

namespace QSS.eIQC.Handlers.Commands.AttachmentCommand
{
    /// <summary>
    /// Representation model for AttachmentInputModel entity
    /// </summary>
    public class AttachmentInputModel : IRequest<String>
    {
        /// <summary>
        /// Attachment Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Attachment FolderName
        /// </summary>
        public string FolderName { get; set; }
        /// <summary>
        /// Attachment ContenFile
        /// </summary>
        public Stream ContenFile { get; set; }

    }
}
