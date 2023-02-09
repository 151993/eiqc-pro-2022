/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SAPPartInspectionPlan entity model to map database SAPPartInspectionPlan table 
    /// </summary>
    public class SAPPartInspectionPlan : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        public SAPPartInspectionPlan()
        {
            this.SAPPartInspectionPlanSuppliers = new HashSet<SAPPartInspectionPlanSupplier>();
            this.SAPPartInspectionPlanSamplingPlans = new HashSet<SAPPartInspectionPlanSamplingPlan>();
            this.SAPPartInspectionPlanAdminCertifications = new HashSet<SAPPartInspectionPlanAdminCertification>();
            this.PartInspectionCertificationAttachments = new HashSet<PartInspectionCertificationAttachment>();
            this.PartMPositionTolerances = new HashSet<PartMPositionTolerance>();
            this.PartLPositionTolerances = new HashSet<PartLPositionTolerance>();
            this.PartMeasurementParameters = new HashSet<PartMeasurementParameter>();
            this.PartFunParameters = new HashSet<PartFunParameter>();
            this.PartMicrosectionParameters = new HashSet<PartMicrosection>();
            this.PartResultOrientedParameters = new HashSet<PartResultOrientedParameter>();
            this.PartInspectionBowTwistParameters = new HashSet<PartInspectionBowTwistParameter>();
            this.PartTestReportParameters = new HashSet<PartTestReportParameter>();
            this.PartCountParameters = new HashSet<PartCountParameter>();
            this.PartInspectionSpecifications = new HashSet<PartInspectionSpecification>();
            this.PartInspectionDrawings = new HashSet<PartInspectionDrawing>();
            this.SupplierMeasurementSubmissions = new HashSet<SupplierMeasurementSubmission>();

        }

        [AuditLog]
        public string PartNo { get; set; }

        [AuditLog]
        public string PartDescription { get; set; }

        [AuditLog]
        public string IP { get; set; }

        [AuditLog]
        public bool IsSafePart { get; set; }

        public int? WorkCellId { get; set; }

        [AuditLog]
        public string ManufacturePartNumber { get; set; }        

        [AuditLog]
        public string DivisionModelNumber { get; set; }

        [AuditLog]
        public string GenWI { get; set; }

        [AuditLog]
        public string RefDoc { get; set; }

        public int CommodityId { get; set; }

        public int? ProductLifeCycleStageId { get; set; }

        public virtual ProductLifeCycleStageModel ProductLifeCycleStage { get; set; }

        [AuditLog(DisplayName = "WorkCell", ValueField = "Name", MappingField = "WorkCellId")]
        public virtual WorkCell WorkCell { get; set; }

        public int? PartDateCodeId { get; set; }

        [AuditLog(DisplayName = "PartDateCode", ValueField = "DateCodeDetails", MappingField = "PartDateCodeId")]
        public virtual PartDateCode PartDateCode { get; set; }

        public virtual Commodity Commodity { get; set; }

        [AuditLog]
        public string Manufacturer { get; set; }

        [AuditLog]
        public string MediaCode { get; set; }

        [AuditLog]
        public string MaskedMPN { get; set; }

        public int? SupplierId { get; set; }

        [Unique]
        public int? IPSerialNumber { get; set; }

        public string IPVersion { get; set; }

        [AuditLog]
        public string SiteIP { get; set; }

        [Unique]
        public int? SiteIPSerialNumber { get; set; }

        public string SiteIPVersion { get; set; }

        [AuditLog]
        public string CAFNo { get; set; }

        [AuditLog(DisplayName = "Supplier", ValueField = "VendorName", MappingField = "SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [AuditLog]
        public string JabilOwnerContact { get; set; }

        public StateTypeModel StateType { get; set; }

        public int StateTypeId { get; set; }

        public string Comment { get; set; }

        public int? SubmittedByUserId { get; set; }

        public DateTimeOffset? SubmittedDate { get; set; }

        public int? AssignToUserId { get; set; }

        public int? ApproveRejectedId { get; set; }

        public DateTimeOffset? ApproveRejectedDate { get; set; }

        [AuditLog(DisplayName = "SubmittedBy", ValueField = "Name", MappingField = "SubmittedByUserId")]
        [ForeignKey("SubmittedByUserId")]
        public virtual User SubmittedBy { get; set; }

        [AuditLog(DisplayName = "AssignTo", ValueField = "Name", MappingField = "AssignToUserId")]
        [ForeignKey("AssignToUserId")]
        public virtual User AssignTo { get; set; }

        [AuditLog(DisplayName = "ApproveRejected", ValueField = "Name", MappingField = "ApproveRejectedId")]
        [ForeignKey("ApproveRejectedId")]
        public virtual User ApproveRejected { get; set; }

        public int? SupplierContactId { get; set; }

        [AuditLog(DisplayName = "SupplierContact", ValueField = "Name", MappingField = "SupplierContactId")]
        [ForeignKey("SupplierContactId")]
        public virtual User SupplierContact { get; set; }


        public bool IsMPNMatched { get; set; }

        [AuditLog]
        public string MPNMaterialHERS { get; set; }

        [AuditLog]
        public string MPNReason { get; set; }

        public virtual Part Part { get; set; }

        public int SpecTypeId { get; set; }

        public int DataTypeId { get; set; }

        public int? ReferenceSAPPartInspectionPlanId { get; set; }

        public virtual ICollection<PartInspectionCertificationAttachment> PartInspectionCertificationAttachments { get; set; }

        public virtual ICollection<SAPPartInspectionPlanSupplier> SAPPartInspectionPlanSuppliers { get; set; }

        public virtual ICollection<SAPPartInspectionPlanSamplingPlan> SAPPartInspectionPlanSamplingPlans { get; set; }

        public virtual ICollection<SAPPartInspectionPlanAdminCertification> SAPPartInspectionPlanAdminCertifications { get; set; }


        public virtual ICollection<PartMPositionTolerance> PartMPositionTolerances { get; set; }

        public virtual ICollection<PartLPositionTolerance> PartLPositionTolerances { get; set; }

        public virtual ICollection<PartMeasurementParameter> PartMeasurementParameters { get; set; }

        public virtual ICollection<PartFunParameter> PartFunParameters { get; set; }

        public virtual ICollection<PartMicrosection> PartMicrosectionParameters { get; set; }

        public virtual ICollection<PartResultOrientedParameter> PartResultOrientedParameters { get; set; }

        public virtual ICollection<PartInspectionBowTwistParameter> PartInspectionBowTwistParameters { get; set; }

        public virtual ICollection<PartTestReportParameter> PartTestReportParameters { get; set; }

        public virtual ICollection<PartCountParameter> PartCountParameters { get; set; }

        public virtual ICollection<PartInspectionSpecification> PartInspectionSpecifications { get; set; }

        public virtual ICollection<PartInspectionDrawing> PartInspectionDrawings { get; set; }

        public virtual ICollection<SAPPartInspectionPlanComment> PartComments { get; set; } 

        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissions { get; set; }
    }
}
