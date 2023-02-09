using System;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPCommodity
    {
        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets Commodity Valid From
        /// </summary>
        public DateTimeOffset ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets Commodity Valid To
        /// </summary>
        public DateTimeOffset ValidTo { get; set; }

        /// <summary>
        /// Gets or sets Deleted
        /// </summary>
        public bool Deleted { get; set; }

        public DateTimeOffset LastUpdated { get; set; }

        public string PartNumber { get; set; }

        public string SiteNo { get; set; }

        public string SAPCommodityId { get; set; }

        public DateTimeOffset CommodityValidFrom { get; set; }

        public DateTimeOffset CommodityValidTo { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string AppearanceInspectionItem { get; set; }

        public string FunctionTestItem { get; set; }

        public string Status { get; set; }

        public int? CommodityCategoryOptionId { get; set; }

        public int? CommodityCategoryId { get; set; }
    }
}
