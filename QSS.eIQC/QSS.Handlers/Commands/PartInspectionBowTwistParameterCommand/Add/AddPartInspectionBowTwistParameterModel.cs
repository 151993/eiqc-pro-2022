/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Add
{
    /// <summary>
    /// Representation model for Add PartBowTwistParameter operation
    /// </summary>
    public class AddPartInspectionBowTwistParameterModel : BaseCommand, IRequest<PartInspectionBowTwistParameterModel>
    {
        public int SAPPartInspectionPlanId { get; set; }

        public int BowTwistFormulaId { get; set; }
    
        public decimal Spec { get; set; }
    
        public decimal Length { get; set; }
    
        public decimal Width { get; set; }
    
        public string Unit { get; set; }
     
        public decimal UpperLimit { get; set; }

    }
}
