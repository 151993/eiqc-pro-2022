/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// BowTwistFormula entity model to map database BowTwistFormula table 
    /// </summary>
    public class BowTwistFormula : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public BowTwistFormula()
        {
            this.PartInspectionBowTwistParameters = new HashSet<PartInspectionBowTwistParameter>();
        }

        [AuditLog]
        [Unique]
        public string Name { get; set; }
        [AuditLog]
        public string Equation { get; set; }

        [AuditLog]
        public int WarPageId { get; set; }

        [AuditLog(DisplayName = "WarPage", ValueField = "Name", MappingField = "WarPageId")]
        public virtual WarPageModel WarPage { get; set; }

        public virtual ICollection<PartInspectionBowTwistParameter> PartInspectionBowTwistParameters { get; set; }
    }
}
