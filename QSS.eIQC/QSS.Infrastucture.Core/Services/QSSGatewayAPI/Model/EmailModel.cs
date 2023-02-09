using System.Collections.Generic;

namespace QSS.Infrastructure.Core.QSSGatewayAPI.Model
{
    /// <summary>
    /// Email Model
    /// </summary>
    public class EmailModel
    {
        public EmailModel()
        {
            Cc = new List<string>();
            Bcc = new List<string>();
            To = new List<string>();
            Attachment = new List<Attachment>();
        }
        /// <summary>
        /// From
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// To
        /// </summary>
        public List<string> To { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// HTML EmailBody
        /// </summary>
        public string EmailBody { get; set; }

        /// <summary>
        /// Cc
        /// </summary>
        public List<string> Cc { get; set; }

        /// <summary>
        /// Bcc
        /// </summary>
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Email Attachments
        /// </summary>
        public List<Attachment> Attachment { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// EnableSsl
        /// </summary>
        public bool EnableSsl { get; set; } = false;
    }

    public class Attachment
    {
        /// <summary>
        /// Bytes data of file
        /// </summary>
        public byte[] bytes { get; set; }

        /// <summary>
        /// File Name with Extension
        /// </summary>
        public string fileName { get; set; }
    }
}
