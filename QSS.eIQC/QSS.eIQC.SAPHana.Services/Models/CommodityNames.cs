using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.SAPModels
{
        public class CommodityNames
       {
            [Key]
            public string IntClassNo { get; set; }
            public string Class { get; set; }
            public string ValidFrom { get; set; }
            public string ValidTo { get; set; }
            public int Id { get; set; }
            public bool IsEnabled { get; set; }

    }
}
