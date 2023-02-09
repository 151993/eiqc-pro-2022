

using System;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Domain.Models
{
    public class TM1DataSyncDetails 
    {
        [Key]
        public int TM1DataSyncDetailsId { get; set; }
        [Unique]
        public string Name { get; set; }

        public DateTimeOffset? LastSyncDate { get; set; }
    }
}
