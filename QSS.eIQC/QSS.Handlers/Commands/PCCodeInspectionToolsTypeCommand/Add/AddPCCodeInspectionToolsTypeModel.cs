/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Add
{
    /// <summary>
    /// Representation model for Add PCCodeInspectionToolsType operation
    /// </summary>
    public class AddPCCodeInspectionToolsTypeModel : BaseCommand, IRequest<PCCodeInspectionToolsTypeModel>
    {



        /// <summary>
        /// Get or set PCCodeId property
        /// </summary>        
        public int PCCodeId { get; set; }




        /// <summary>
        /// Get or set InspectionToolsTypeId property
        /// </summary>        
        public int InspectionToolsTypeId { get; set; }


    }
}
