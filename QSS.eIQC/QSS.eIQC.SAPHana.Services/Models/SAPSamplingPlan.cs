using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPSamplingPlan
    {
        public string MstrChar { get; set; }

        public string SmplProc { get; set; }

        public string Site { get; set; }

        public string CertificateType { get; set; }
    }
}
