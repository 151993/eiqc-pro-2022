/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddLotInspectionQtyModel : BaseCommand, IRequest<LotInspectionQtyModel>
    {
        /// <summary>
        /// Get or set LotNo property
        /// </summary>        
        public string LotNo { get; set; }
        /// <summary>
        /// Get or set Material property
        /// </summary>        
        public string Material { get; set; }
        /// <summary>
        /// Get or set MstrChar property
        /// </summary>        
        public string MstrChar { get; set; }
        /// <summary>
        /// Get or set InspStg property
        /// </summary>        
        public string InspStg { get; set; }
        /// <summary>
        /// Get or set INspectQty property
        /// </summary>        
        public int INspectQty { get; set; }
   }
}
