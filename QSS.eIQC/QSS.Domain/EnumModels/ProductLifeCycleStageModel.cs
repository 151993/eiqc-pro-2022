using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.EnumModels
{

    [Table("ProductLifeCycleStage")]
    public class ProductLifeCycleStageModel : BaseEnum<ProductLifeCycleStage, int>
    {
        public bool IsEnabled { get; set; }

        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlans { get; set; }
    }
}
