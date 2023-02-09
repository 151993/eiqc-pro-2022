using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class ParameterManagementCommodity : PersistentObjectWithUpdate<int>
    {
        public int ParameterManagementId { get; set; }

        public int CommodityId { get; set; }

        public virtual ParameterManagement ParameterManagement { get; set; }

        public virtual Commodity Commodity { get; set; }  
    }
}
