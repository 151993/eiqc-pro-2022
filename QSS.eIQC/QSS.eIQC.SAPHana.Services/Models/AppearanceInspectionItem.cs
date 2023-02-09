using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.SAPModels
{

    public class AppearanceInspectionItem
    {
        [Key]
        public string Intchar { get; set; }
        public string ToleranceFrom { get; set; }
        public string ToleranceTo { get; set; }
        public int Id { get; set; }
        public bool IsEnabled { get; set; }
    }

}
