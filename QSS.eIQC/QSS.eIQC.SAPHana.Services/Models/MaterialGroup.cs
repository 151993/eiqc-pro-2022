using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.Models
{
        public class MaterialGroups
        {
            public int Id { get; set; }
            public bool IsEnabled { get; set; }
            public string SiteName { get; set; }
            public string MaterialGroupName { get; set; }
            public bool Deleted { get; set; }

    }
}
