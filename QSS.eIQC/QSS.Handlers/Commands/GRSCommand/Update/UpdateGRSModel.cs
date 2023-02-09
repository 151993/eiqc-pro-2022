/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.GRSCommand.Update
{
    /// <summary>
    /// Representation model for Update GRS operation
    /// </summary>
    public class UpdateGRSModel : BaseUpdateCommand<int>, IRequest<GRSModel>
    {
        /// <summary>
        /// Get or set GRSNo property
        /// </summary>        
        public string GRSNo { get; set; }




        /// <summary>
        /// Get or set PartNo property
        /// </summary>        
        public string PartNo { get; set; }



        /// <summary>
        /// Get or set MedialCode property
        /// </summary>        
        public string MedialCode { get; set; }

        /// <summary>
        /// Get or set MPN property
        /// </summary>        
        public string MPN { get; set; }

        /// <summary>
        /// Get or set MaterialName property
        /// </summary>        
        public string MaterialName { get; set; }

        /// <summary>
        /// Get or set MFG property
        /// </summary>        
        public string MFG { get; set; }

        /// <summary>
        /// Get or set Quantity property
        /// </summary>        
        public int? Quantity { get; set; }

        /// <summary>
        /// Get or set LotNo property
        /// </summary>        
        public string LotNo { get; set; }

        /// <summary>
        /// Get or set InspectQty property
        /// </summary>        
        public int? InspectQty { get; set; }

        /// <summary>
        /// Get or set RejectionQty property
        /// </summary>        
        public int? RejectionQty { get; set; }

        /// <summary>
        /// Get or set InspectorName property
        /// </summary>        
        public string InspectorName { get; set; }

        /// <summary>
        /// Get or set InspectionResult property
        /// </summary>        
        public string InspectionResult { get; set; }

        /// <summary>
        /// Get or set GRSNoType property
        /// </summary>        
        public string GRSNoType { get; set; }

        /// <summary>
        /// Get or set PO property
        /// </summary>        
        public string PO { get; set; }

        /// <summary>
        /// Get or set VendorCode property
        /// </summary>        
        public string VendorCode { get; set; }

        /// <summary>
        /// Get or set MatlGroup property
        /// </summary>        
        public string MatlGroup { get; set; }

        /// <summary>
        /// Get or set VendorName1 property
        /// </summary>        
        public string VendorName1 { get; set; }

        /// <summary>
        /// Get or set SkipIQC property
        /// </summary>        
        public string SkipIQC { get; set; }




        /// <summary>
        /// Get or set StatusTypeId property
        /// </summary>        
        public int StatusTypeId { get; set; }

    }
}
