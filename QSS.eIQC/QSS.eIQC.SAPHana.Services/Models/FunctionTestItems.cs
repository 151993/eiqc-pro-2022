using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.SAPModels
{

    public class FunctionTestItems
    {
        [Key]
        public string CharValue { get; set; }
        public int Id { get; set; }
        public bool IsEnabled { get; set; }
    }
}
