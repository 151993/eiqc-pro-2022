/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// CommodityCategory entity model to map database CommodityCategory table 
    /// </summary>
    public class CommodityPartNumberSite : PersistentObject<int>
    {
        public CommodityPartNumberSite()
        {
            
        }
        
        public int CommodityId { get; set; }

        // [AuditLog]
        public string PartNumber { get; set; }

        // [AuditLog]
        public string SiteNo { get; set; }

        // [AuditLog(DisplayName = "Commodity", ValueField = "Name", MappingField = "CommodityId")]
        public virtual Commodity Commodity { get; set; }
        
    }
}
