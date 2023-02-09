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
    public class DefectType : PersistentObjectWithUpdateAuditLog<int>
    {
        public DefectType()
        {
            SupplierFunctionAttributeDefectTypes = new HashSet<SupplierFunctionAttributeDefectType>();
            SupplierSapBasedParameterDefectTypes = new HashSet<SupplierSapBasedParameterDefectType>();
            SupplierTestReports = new HashSet<SupplierTestReport>();
        }

        public int DefectManagementId { get; set; }

        public virtual DefectManagement DefectManagement { get; set; }

        [AuditLog]
        public string DefectTypeName { get; set; }

        public virtual ICollection<SupplierFunctionAttributeDefectType> SupplierFunctionAttributeDefectTypes { get; set; }

        public virtual ICollection<SupplierSapBasedParameterDefectType> SupplierSapBasedParameterDefectTypes { get; set; }
        public virtual ICollection<SupplierTestReport> SupplierTestReports { get; set; }

        public virtual ICollection<SupplierVisualInspectionDefectType> SupplierVisualInspectionDefectTypes { get; set; }


    }
}
