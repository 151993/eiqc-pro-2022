/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.ReceiveGoodsInfoManualCommand.Update
{
    /// <summary>
    /// Representation model for Update ReceiveGoodsInfoManual operation
    /// </summary>
    public class UpdateReceiveGoodsInfoManualModel : BaseUpdateCommand<int>, IRequest<ReceiveGoodsInfoManualModel>
    {
        /// <summary>
        /// Get or set Plant property
        /// </summary>        
        public string Plant { get; set; }

        /// <summary>
        /// Get or set MatlGroup property
        /// </summary>        
        public string MatlGroup { get; set; }

        /// <summary>
        /// Get or set Material property
        /// </summary>        
        public string Material { get; set; }

        /// <summary>
        /// Get or set Quantity property
        /// </summary>        
        public int Quantity { get; set; }

        /// <summary>
        /// Get or set ReceivedDateTime property
        /// </summary>        
        public DateTimeOffset? ReceivedDateTime { get; set; }

        /// <summary>
        /// Get or set MocDoc property
        /// </summary>        
        public string MocDoc { get; set; }

        /// <summary>
        /// Get or set StorLoc property
        /// </summary>        
        public string StorLoc { get; set; }

        /// <summary>
        /// Get or set MvmtType property
        /// </summary>        
        public string MvmtType { get; set; }

        /// <summary>
        /// Get or set Batch property
        /// </summary>        
        public string Batch { get; set; }

        /// <summary>
        /// Get or set Vendor property
        /// </summary>        
        public string Vendor { get; set; }

        /// <summary>
        /// Get or set User property
        /// </summary>        
        public string User { get; set; }

        /// <summary>
        /// Get or set SpecStock property
        /// </summary>        
        public string SpecStock { get; set; }

        /// <summary>
        /// Get or set Reference property
        /// </summary>        
        public string Reference { get; set; }


    }
}
