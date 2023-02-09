/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand;
using System;
using System.Collections.Generic;
namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand
{
    /// <summary>
    /// Representation model for AdminCertification entity
    /// </summary>
    public class AdminCertificationModel : BaseStausModel<int>
    {
        /// <summary>
        /// Get or set AdminCertificateId property
        /// </summary>        
        public int AdminCertificateId { get; set; }
        /// <summary>
        /// Get or set Number property
        /// </summary>        
        public string Number { get; set; }
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }
        /// <summary>
        /// Get or set AssessmentBodyId property
        /// </summary>        
        public string AssessmentBodyId { get; set; }
        /// <summary>
        /// Get or set AssessmentBodyName property
        /// </summary>        
        public string AssessmentBodyName { get; set; }
        /// <summary>
        /// Get or set CertificateStartDate property
        /// </summary>        
        public DateTimeOffset CertificateStartDate { get; set; }
        /// <summary>
        /// Get or set CertificateEndDate property
        /// </summary>        
        public DateTimeOffset CertificateEndDate { get; set; }

        public virtual IEnumerable<AdminCertificationAttachmentModel> AdminCertificationAttachments { get; set; }

    }
}
