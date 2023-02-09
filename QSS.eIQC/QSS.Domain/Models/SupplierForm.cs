/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierForm entity model to map database SupplierForm table 
    /// </summary>
    public class SupplierForm : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierForm()
        {
            SupplierFormBowTwistActual = new HashSet<SupplierFormBowTwistActual>();
            SupplierFormBowTwistParameter = new HashSet<SupplierFormBowTwistParameter>();
            SupplierFormCountParameter = new HashSet<SupplierFormCountParameter>();
            SupplierFormFunPara = new HashSet<SupplierFormFunPara>();
            SupplierFormFunParaActual = new HashSet<SupplierFormFunParaActual>();
            SupplierFormLPosition = new HashSet<SupplierFormLPosition>();
            SupplierFormLPositionActual = new HashSet<SupplierFormLPositionActual>();
            SupplierFormMeasurementParameter = new HashSet<SupplierFormMeasurementParameter>();
            SupplierFormMeasurementParameterActual = new HashSet<SupplierFormMeasurementParameterActual>();
            SupplierFormMicroSection = new HashSet<SupplierFormMicroSection>();
            SupplierFormMicroSectionActual = new HashSet<SupplierFormMicroSectionActual>();
            SupplierFormMPosition = new HashSet<SupplierFormMPosition>();
            SupplierFormMPositionActual = new HashSet<SupplierFormMPositionActual>();
            SupplierFormPackaging = new HashSet<SupplierFormPackaging>();
            SupplierFormPartDateCode = new HashSet<SupplierFormPartDateCode>();
            SupplierFormResultOrientedParameter = new HashSet<SupplierFormResultOrientedParameter>();
            SupplierFormSAPParameter = new HashSet<SupplierFormSAPParameter>();
            SupplierFormSpecialParameter = new HashSet<SupplierFormSpecialParameter>();
            SupplierFormVIS = new HashSet<SupplierFormVIS>();
            GRSSupplierForm = new HashSet<GRSSupplierForm>();



        }

        [AuditLog]
        public string PONo { get; set; }
        public string PartNo { get; set; }
        [AuditLog]
        public string FileName { get; set; }
        [AuditLog]
        public string DateCode { get; set; }
        [AuditLog]
        public bool DateCodeActual { get; set; }
        public DateTimeOffset? ApproveTime { get; set; }
        [AuditLog]
        public string ApproveUser { get; set; }
        [AuditLog]
        public int TotalQty { get; set; }
        [AuditLog]
        public int SampleQty { get; set; }
        [AuditLog]
        public string Inspector { get; set; }
        [AuditLog]
        public string Verify { get; set; }
        [AuditLog]
        public int ImportStatus { get; set; }
        [AuditLog]
        public string ImportError { get; set; }
        [AuditLog]
        public string MO { get; set; }
        [AuditLog]
        public string MovedPath { get; set; }

        public virtual ICollection<SupplierFormBowTwistActual> SupplierFormBowTwistActual { get; set; }
        public virtual ICollection<SupplierFormBowTwistParameter> SupplierFormBowTwistParameter { get; set; }

        public virtual ICollection<SupplierFormCountParameter> SupplierFormCountParameter { get; set; }
        public virtual ICollection<SupplierFormFunPara> SupplierFormFunPara { get; set; }
        public virtual ICollection<SupplierFormFunParaActual> SupplierFormFunParaActual { get; set; }
        public virtual ICollection<SupplierFormLPosition> SupplierFormLPosition { get; set; }
        public virtual ICollection<SupplierFormLPositionActual> SupplierFormLPositionActual { get; set; }
        public virtual ICollection<SupplierFormMeasurementParameter> SupplierFormMeasurementParameter { get; set; }
        public virtual ICollection<SupplierFormMeasurementParameterActual> SupplierFormMeasurementParameterActual { get; set; }
        public virtual ICollection<SupplierFormMicroSection> SupplierFormMicroSection { get; set; }
        public virtual ICollection<SupplierFormMicroSectionActual> SupplierFormMicroSectionActual { get; set; }
        public virtual ICollection<SupplierFormMPosition> SupplierFormMPosition { get; set; }
        public virtual ICollection<SupplierFormMPositionActual> SupplierFormMPositionActual { get; set; }
        public virtual ICollection<SupplierFormPackaging> SupplierFormPackaging { get; set; }
        public virtual ICollection<SupplierFormPartDateCode> SupplierFormPartDateCode { get; set; }
        public virtual ICollection<SupplierFormResultOrientedParameter> SupplierFormResultOrientedParameter { get; set; }
        public virtual ICollection<SupplierFormSAPParameter> SupplierFormSAPParameter { get; set; }
        public virtual ICollection<SupplierFormSpecialParameter> SupplierFormSpecialParameter { get; set; }
        public virtual ICollection<SupplierFormVIS> SupplierFormVIS { get; set; }

        public virtual ICollection<GRSSupplierForm> GRSSupplierForm { get; set; }

    }
}
