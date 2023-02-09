using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class SAPDataSyncDetails
    {
        [Key]
        public int SAPDataSyncDetailsId { get; set; }
        [Unique]
        public string Name { get; set; }

        public DateTimeOffset? LastSyncDate { get; set; }
    }
}
