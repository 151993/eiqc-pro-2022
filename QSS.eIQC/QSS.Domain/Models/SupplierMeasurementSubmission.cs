using QSS.eIQC.Domain.EnumModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    public class SupplierMeasurementSubmission : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierMeasurementSubmission()
        {
            this.SupplierFunctionAttributes = new HashSet<SupplierFunctionAttribute>();
            this.SupplierMicrosectionParameters = new HashSet<SupplierMicrosection>();
            this.SupplierDimensionMeasurements = new HashSet<SupplierDimensionMeasurement>();
            this.SupplierFunctionVariables = new HashSet<SupplierFunctionVariable>();
            this.SupplierSamplingPlans = new HashSet<SupplierSamplingPlan>();
            this.SupplierSapBasedParameters = new HashSet<SupplierSapBasedParameter>();
            this.SupplierTestReports = new HashSet<SupplierTestReport>();
            this.SupplierBowTwists = new HashSet<SupplierBowTwist>();
            this.SupplierMPositions = new HashSet<SupplierMPosition>();
            this.SupplierLPositions = new HashSet<SupplierLPosition>();
            this.SupplierVisualInspections = new HashSet<SupplierVisualInspection>();
            this.SMSCommentAttachments = new HashSet<SMSCommentAttachment>();

        }

        [AuditLog]
        public string PartNo { get; set; }

        public virtual ICollection<SupplierMicrosection> SupplierMicrosectionParameters { get; set; }
        public virtual ICollection<SupplierDimensionMeasurement> SupplierDimensionMeasurements { get; set; }
        public virtual ICollection<SupplierFunctionVariable> SupplierFunctionVariables { get; set; }
        public virtual ICollection<SMSCommentAttachment> SMSCommentAttachments { get; set; }
        [AuditLog]
        public string Manufacturer { get; set; }

        [AuditLog]
        public string MediaCode { get; set; }

        [AuditLog]
        public string MaskedMPN { get; set; }

        public int? SapBasedResultPassFailId { get; set; }

        [AuditLog]
        public string ManufacturePartNumber { get; set; }

        public int? WorkCellId { get; set; }

        [AuditLog(DisplayName = "WorkCell", ValueField = "Name", MappingField = "WorkCellId")]
        public virtual WorkCell WorkCell { get; set; }

        public int? SupplierContactId { get; set; }

        [AuditLog(DisplayName = "SupplierContact", ValueField = "Name", MappingField = "SupplierContactId")]
        [ForeignKey("SupplierContactId")]
        public virtual User SupplierContact { get; set; }

        public int? SupplierId { get; set; }

        [AuditLog(DisplayName = "Supplier", ValueField = "VendorName", MappingField = "SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [AuditLog]
        public string IP { get; set; }

        public int PurchaseOrderId { get; set; }

        public decimal? Quantity { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [AuditLog]
        public string BatchNo { get; set; }

        public decimal? BatchQuantity { get; set; }


        public int InspectorId { get; set; }
        

        [AuditLog(DisplayName = "Inspector", ValueField = "Name", MappingField = "InspectorId")]
        [ForeignKey("InspectorId")]
        public virtual User Inspector { get; set; }

        public int SMSPOStateTypeId { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public string ResultDescription { get; set; }

        public int PackagingQuantity { get; set; }

        public int ResultId { get; set; }
        
        public string SMSNo { get; set; }

        [Unique]
        public int? SMSSerialNumber { get; set; }

        public virtual SMSPOStateTypeModel SMSPOStateType { get; set; }

        public virtual ICollection<SupplierFunctionAttribute> SupplierFunctionAttributes { get; set; }

        public virtual ICollection<SupplierSamplingPlan> SupplierSamplingPlans { get; set; }

        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public virtual ICollection<SupplierSapBasedParameter> SupplierSapBasedParameters { get; set; }

        public virtual ICollection<SupplierTestReport> SupplierTestReports { get; set; }

        public int? SupplierDateCodeId { get; set; }

        public virtual SupplierDateCode SupplierDateCode { get; set; }

        public virtual ICollection<SupplierBowTwist> SupplierBowTwists { get; set; }

        public virtual ICollection<SupplierMPosition> SupplierMPositions { get; set; }
        public virtual ICollection<SupplierLPosition> SupplierLPositions { get; set; }

        public virtual ICollection<SupplierVisualInspection> SupplierVisualInspections { get; set; }

        public StateTypeModel StateType { get; set; }

        public int? StateTypeId { get; set; }

        public string Comments { get; set; }

        public int? SubmittedByUserId { get; set; }

        public DateTimeOffset? SubmittedDate { get; set; }

        public int? ApproveRejectedId { get; set; }

        public DateTimeOffset? ApproveRejectedDate { get; set; }

        [AuditLog(DisplayName = "SubmittedBy", ValueField = "Name", MappingField = "SubmittedByUserId")]
        [ForeignKey("SubmittedByUserId")]
        public virtual User SubmittedBy { get; set; }

        
        [AuditLog(DisplayName = "ApproveRejected", ValueField = "Name", MappingField = "ApproveRejectedId")]
        [ForeignKey("ApproveRejectedId")]
        public virtual User ApproveRejected { get; set; }

    }
}
