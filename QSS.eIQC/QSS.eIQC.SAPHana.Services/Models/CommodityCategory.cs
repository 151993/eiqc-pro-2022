using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.SAPModels
{
    public class CommodityCategory
    {
       [Key]
        public string Class { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
        public bool IsEnabled { get; set; }

    }
}
