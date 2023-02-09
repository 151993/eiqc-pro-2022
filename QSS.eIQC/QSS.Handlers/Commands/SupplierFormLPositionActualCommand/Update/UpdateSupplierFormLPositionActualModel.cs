/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormLPositionActualCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierFormLPositionActual operation
    /// </summary>
    public class UpdateSupplierFormLPositionActualModel : BaseUpdateCommand<int>, IRequest<SupplierFormLPositionActualModel>
    {



        /// <summary>
        /// Get or set SupplierFormId property
        /// </summary>        
        public int SupplierFormId { get; set; }

        /// <summary>
        /// Get or set LineNo property
        /// </summary>        
        public string LineNo { get; set; }

        /// <summary>
        /// Get or set No property
        /// </summary>        
        public int No { get; set; }

        /// <summary>
        /// Get or set ValueActual property
        /// </summary>        
        public double? ValueActual { get; set; }

        /// <summary>
        /// Get or set PositionCalcul property
        /// </summary>        
        public double? PositionCalcul { get; set; }

        /// <summary>
        /// Get or set PositionActual property
        /// </summary>        
        public double? PositionActual { get; set; }

        /// <summary>
        /// Get or set Result property
        /// </summary>        
        public string Result { get; set; }

        /// <summary>
        /// Get or set InstrumentID property
        /// </summary>        
        public string InstrumentID { get; set; }

        /// <summary>
        /// Get or set Base1Actual property
        /// </summary>        
        public double? Base1Actual { get; set; }

        /// <summary>
        /// Get or set Base2Actual property
        /// </summary>        
        public double? Base2Actual { get; set; }

        /// <summary>
        /// Get or set Base3Actual property
        /// </summary>        
        public double? Base3Actual { get; set; }

        /// <summary>
        /// Get or set InstrumentID-1 property
        /// </summary>        
        public string InstrumentID1 { get; set; }

        /// <summary>
        /// Get or set InstrumentID-2 property
        /// </summary>        
        public string InstrumentID2 { get; set; }

        /// <summary>
        /// Get or set InstrumentID-3 property
        /// </summary>        
        public string InstrumentID3 { get; set; }

        /// <summary>
        /// Get or set PositionType property
        /// </summary>        
        public int? PositionType { get; set; }

    }
}
