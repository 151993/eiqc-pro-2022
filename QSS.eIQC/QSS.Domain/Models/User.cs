using QSS.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
    public class User : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public User()
        {
            Roles = new HashSet<UserRole>();
            SiteUsers = new HashSet<SiteUser>();
            UserCustomers = new HashSet<UserCustomer>();
            WorkCellJabilUsers = new HashSet<WorkCellJabilUser>();
            WorkCellDccUsers = new HashSet<WorkCellDccUser>();
            SAPPartInspectionPlanSubmittedUsers = new HashSet<SAPPartInspectionPlan>();
            SAPPartInspectionPlanAssignToUsers = new HashSet<SAPPartInspectionPlan>();
            SAPPartInspectionPlanApproveRejectedUsers = new HashSet<SAPPartInspectionPlan>();
            SAPPartInspectionPlanSupplierContactUsers = new HashSet<SAPPartInspectionPlan>();
            SupplierMeasurementSubmissionSubmittedUsers = new HashSet<SupplierMeasurementSubmission>();
            SupplierMeasurementSubmissionApproveRejectedUsers = new HashSet<SupplierMeasurementSubmission>();
            SupplierMeasurementSubmissionSupplierContactUsers = new HashSet<SupplierMeasurementSubmission>();
            SupplierMeasurementSubmissionInspectors = new HashSet<SupplierMeasurementSubmission>();
        }

        [AuditLog]
        [Unique]
        public string UserName { get; set; }

        [AuditLog]
        public string Name { get; set; }

        [AuditLog]
        public string EmployeeId { get; set; }

        [AuditLog]
        public string Email { get; set; }

        [AuditLog]
        public bool AllowNotification { get; set; }

        public int? ManagerId { get; set; }

        public int? DepartmentId { get; set; }

        [AuditLog(DisplayName ="Role",ValueField = "Role.Name")]
        public virtual ICollection<UserRole> Roles { get; set; }

        [AuditLog(DisplayName = "Manager", ValueField = "Name", MappingField = "ManagerId")]
        public virtual Manager Manager { get; set; }

        [AuditLog(DisplayName = "Department", ValueField = "Name", MappingField = "DepartmentId")]
        public virtual Department Department { get; set; }

        public virtual ICollection<SiteUser> SiteUsers { get; set; }

        public virtual ICollection<UserCustomer> UserCustomers { get; set; }

        public virtual ICollection<WorkCellJabilUser> WorkCellJabilUsers { get; set; }

        public virtual ICollection<WorkCellDccUser> WorkCellDccUsers { get; set; }

        [NotMapped]
        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlanAssignToUsers { get; set; }
        [NotMapped]
        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlanSubmittedUsers { get; set; }
        [NotMapped]
        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlanApproveRejectedUsers { get; set; }
        [NotMapped]
        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlanSupplierContactUsers { get; set; }
        public int? SiteId { get; set; }

        [AuditLog(DisplayName = "Site", ValueField = "Name", MappingField = "SiteId")]
        public virtual Site Site { get; set; }

        [AuditLog]
        public string Phone { get; set; }

        //[AuditLog]
        public int? UserTypeId { get; set; }

        //[AuditLog]
        public int? SupplierId { get; set; }

        [AuditLog(DisplayName = "Supplier", ValueField = "VendorName", MappingField = "SupplierId")]
        public virtual Supplier Supplier { get; set; }
        [NotMapped]
        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissionSubmittedUsers { get; set; }
        [NotMapped]
        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissionApproveRejectedUsers { get; set; }
        [NotMapped]
        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissionSupplierContactUsers { get; set; }
        [NotMapped]
        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmissionInspectors { get; set; }

    }
}