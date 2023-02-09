/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartBowTwistParameter entity model to map database PartBowTwistParameter table 
    /// </summary>
    public class PartInspectionBowTwistParameter : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public PartInspectionBowTwistParameter()
        {
            this.SupplierBowTwists = new HashSet<SupplierBowTwist>();
        }

        public int SAPPartInspectionPlanId { get; set; }
        public virtual SAPPartInspectionPlan SAPPartInspectionPlan { get; set; }

        public int BowTwistFormulaId { get; set; }

        public virtual BowTwistFormula BowTwistFormula { get; set; }


        public int? WarPageTypeId { get; set; }

        [AuditLog]
        public decimal Spec { get; set; }
        [AuditLog]
        public decimal Length { get; set; }
        [AuditLog]
        public decimal Width { get; set; }
        [AuditLog]
        public int Unit { get; set; }
        [AuditLog]
        public decimal UpperLimit { get; set; }

        public virtual ICollection<SupplierBowTwist> SupplierBowTwists { get; set; }

    }
}
