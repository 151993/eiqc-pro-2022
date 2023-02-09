/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// CertificateType entity model to map database CertificateType table 
    /// </summary>
    public class CertificateType : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public CertificateType()
        {
            CertificateTypeParameters = new HashSet<CertificateTypeParameter>();
        }

        [AuditLog]
        [Unique]
        public string Name { get; set; }


        [AuditLog(DisplayName = "Certificate Type Parameters", ValueField = "ParameterName", MappingField = "ParameterName")]
        public virtual ICollection<CertificateTypeParameter> CertificateTypeParameters { get; set; }
    }
}
