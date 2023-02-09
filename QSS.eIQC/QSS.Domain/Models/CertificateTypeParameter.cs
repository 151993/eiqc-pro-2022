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
    public class CertificateTypeParameter : PersistentObjectWithUpdate<int>
    {
        public CertificateTypeParameter()
        {
            this.SupplierSapBasedParameters = new HashSet<SupplierSapBasedParameter>();

        }
        public int CertificateTypeId { get; set; }

        public string ParameterName { get; set; }

        public virtual CertificateType CertificateType { get; set; }

        public virtual ICollection<SupplierSapBasedParameter> SupplierSapBasedParameters { get; set; }
    }
}
