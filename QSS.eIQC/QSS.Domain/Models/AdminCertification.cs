/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// AdminCertification entity model to map database AdminCertification table 
    /// </summary>
    public class AdminCertification : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public AdminCertification()
        {
            this.AdminCertificationAttachments = new HashSet<AdminCertificationAttachment>();
            SAPPartInspectionPlanAdminCertifications = new HashSet<SAPPartInspectionPlanAdminCertification>();
        }

        [AuditLog]
        public string Number { get; set; }

        [AuditLog]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        [AuditLog]
        public string AssessmentBodyId { get; set; }

        [AuditLog]
        public string AssessmentBodyName { get; set; }

        [AuditLog]
        public DateTimeOffset CertificateStartDate { get; set; }

        [AuditLog]
        public DateTimeOffset CertificateEndDate { get; set; }

        public virtual ICollection<AdminCertificationAttachment> AdminCertificationAttachments { get; set; }

        public virtual ICollection<SAPPartInspectionPlanAdminCertification> SAPPartInspectionPlanAdminCertifications { get; set; }

        

    }
}
