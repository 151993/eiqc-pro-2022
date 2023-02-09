/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Form entity model to map database Form table 
    /// </summary>
    public class Form : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Form()
        {

            FormBowTwistActual = new HashSet<FormBowTwistActual>();
            FormBowTwistParameter = new HashSet<FormBowTwistParameter>();
            FormCountParameter = new HashSet<FormCountParameter>();
            FormFunPara = new HashSet<FormFunPara>();
            FormFunParaActual = new HashSet<FormFunParaActual>();
            FormLPosition = new HashSet<FormLPosition>();
            FormLPositionActual = new HashSet<FormLPositionActual>();
            FormMeasurementParameter = new HashSet<FormMeasurementParameter>();
            FormMeasurementParameterActual = new HashSet<FormMeasurementParameterActual>();
            FormMicroSection = new HashSet<FormMicroSection>();
            FormMicroSectionActual = new HashSet<FormMicroSectionActual>();
            FormMPosition = new HashSet<FormMPosition>();
            FormMPositionActual = new HashSet<FormMPositionActual>();
            FormPackaging = new HashSet<FormPackaging>();
            FormPartDateCode = new HashSet<FormPartDateCode>();
            FormPartSAPFailedQty = new HashSet<FormPartSAPFailedQty>();
            FormResultOrientedParameter = new HashSet<FormResultOrientedParameter>();
            FormSAPParameter = new HashSet<FormSAPParameter>();
            FormSpecialParameter = new HashSet<FormSpecialParameter>();
            FormStatus = new HashSet<FormStatus>();
            FormTestReport = new HashSet<FormTestReport>();
            FormVIS = new HashSet<FormVIS>();
            Inspection = new HashSet<Inspection>();

        }

        public virtual ICollection<FormBowTwistActual> FormBowTwistActual { get; set; }
        public virtual ICollection<FormBowTwistParameter> FormBowTwistParameter { get; set; }

        public virtual ICollection<FormCountParameter> FormCountParameter { get; set; }
        public virtual ICollection<FormFunPara> FormFunPara { get; set; }
        public virtual ICollection<FormFunParaActual> FormFunParaActual { get; set; }
        public virtual ICollection<FormLPosition> FormLPosition { get; set; }
        public virtual ICollection<FormLPositionActual> FormLPositionActual { get; set; }
        public virtual ICollection<FormMeasurementParameter> FormMeasurementParameter { get; set; }
        public virtual ICollection<FormMeasurementParameterActual> FormMeasurementParameterActual { get; set; }
        public virtual ICollection<FormMicroSection> FormMicroSection { get; set; }
        public virtual ICollection<FormMicroSectionActual> FormMicroSectionActual { get; set; }
        public virtual ICollection<FormMPosition> FormMPosition { get; set; }
        public virtual ICollection<FormMPositionActual> FormMPositionActual { get; set; }
        public virtual ICollection<FormPackaging> FormPackaging { get; set; }
        public virtual ICollection<FormPartDateCode> FormPartDateCode { get; set; }
        public virtual ICollection<FormPartSAPFailedQty> FormPartSAPFailedQty { get; set; }
        public virtual ICollection<FormResultOrientedParameter> FormResultOrientedParameter { get; set; }
        public virtual ICollection<FormSAPParameter> FormSAPParameter { get; set; }
        public virtual ICollection<FormSpecialParameter> FormSpecialParameter { get; set; }
        public virtual ICollection<FormStatus> FormStatus { get; set; }
        public virtual ICollection<FormTestReport> FormTestReport { get; set; }
        public virtual ICollection<FormVIS> FormVIS { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }


        [AuditLog(DisplayName = "FormType", ValueField = "Type", MappingField = "FormTypeId")]
        public virtual FormType FormType { get; set; }
        public int FormTypeId { get; set; }
        [AuditLog(DisplayName = "GRS", ValueField = "GRSNo", MappingField = "GRSId")]
        public virtual GRS GRS { get; set; }
        public int GRSId { get; set; }
        [AuditLog]
        public string DPID { get; set; }
        public int SampleQTY { get; set; }
        [AuditLog]
        public string DateCode { get; set; }
        public bool? DateCodeActual { get; set; }
        public bool? FinalResult { get; set; }
        [AuditLog]
        public string Remark { get; set; }
        [AuditLog]
        public string UserName { get; set; }
        [AuditLog]
        public string QN { get; set; }
        [AuditLog]
        public string IPVersion { get; set; }
        [AuditLog]
        public string RefDoc { get; set; }
        [AuditLog]
        public string QNSoftcopy { get; set; }
        [AuditLog]
        public string GRSNoType { get; set; }
        [AuditLog]
        public string BatchDC { get; set; }
        [AuditLog]
        public string StorageLoc { get; set; }
        public int? RequireStatus { get; set; }
        public int? PackQty { get; set; }
        public double? QtyPerBox { get; set; }
        public string OddQtyPerBox { get; set; }
        [AuditLog]
        public string ReceivingInfo { get; set; }
        [AuditLog]
        public string DANo { get; set; }
        public int? PackSampleQty { get; set; }
        public int? BuyerID { get; set; }
        public int? DivisionId { get; set; }
        public int? SAPDefectTypeID { get; set; }
         
        public int? VISDefectTypeID { get; set; }
         
        public int? FUNDefectTypeID { get; set; }
         
        public int? FunMeasureTypeID { get; set; }
         
        public int? DIMDefectTypeID { get; set; }
         
        public int? MPositionDefectTypeID { get; set; }
         
        public int? LPositionDefectTypeID { get; set; }
         
        public int? DateCodeDefectTypeID { get; set; }
         
        public int? BowTwistDefectTypeID { get; set; }
         
        public int? FunParaDefectTypeID { get; set; }
         
        public int? MicroDefectTypeID { get; set; }
         
        public int? TestReportDefectTypeID { get; set; }
         
        public string SpecDefectType { get; set; }
         
        public int? LastFormID { get; set; }
         
        public int? LockFlag { get; set; }
         
        public string LockUser { get; set; }
        [AuditLog]
        public string DCRequirement { get; set; }
    }
}
