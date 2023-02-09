using QSS.eIQC.Domain.EnumModels;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Commodity : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Commodity()
        {
            ParameterManagementCommodity = new HashSet<ParameterManagementCommodity>();
            SAPPartInspectionPlans = new HashSet<SAPPartInspectionPlan>();
            TestReportCommodities = new HashSet<TestReportCommodity>();
            CommodityPartNumberSites = new HashSet<CommodityPartNumberSite>();

        }
        
        // [AuditLog]
        public string SAPCommodityId { get; set; }

        // [AuditLog]
        public DateTimeOffset CommodityValidFrom { get; set; }

        // [AuditLog]
        public DateTimeOffset CommodityValidTo { get; set; }

        // [AuditLog]
        public string Name { get; set; }


        public int? CommodityCategoryOptionId { get; set; }

        public int? CommodityCategoryId { get; set; }

        public virtual CommodityCategory CommodityCategory { get; set; }

        public virtual CommodityCategoryOptionModel CommodityCategoryOption { get; set; }

        // [AuditLog]
        public string Description { get; set; }

        // [AuditLog]
        public string AppearanceInspectionItem { get; set; }

        // [AuditLog]
        public string FunctionTestItem { get; set; }


        public virtual ICollection<ParameterManagementCommodity> ParameterManagementCommodity { get; set; }

        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlans { get; set; }

        public virtual ICollection<TestReportCommodity> TestReportCommodities { get; set; }

        public virtual ICollection<CommodityPartNumberSite> CommodityPartNumberSites { get; set; }

    }
}
