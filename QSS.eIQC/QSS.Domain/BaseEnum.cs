using QSS.Common.Utilities.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QSS.eIQC.Domain
{
    public class BaseEnum<TEnum,TKey>: PersistentObject<TKey>
        where TKey : IComparable
    {
        [Required]
        [MaxLength(100)]
        public virtual string Name { get; set; }

        [MaxLength(250)]
        public virtual string Description { get; set; }
    }
}
