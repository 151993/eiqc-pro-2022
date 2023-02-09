/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.GRSSAPResultCommand.Update
{
    /// <summary>
    /// Representation model for Update GRSSAPResult operation
    /// </summary>
    public class UpdateGRSSAPResultModel : BaseUpdateCommand<int>, IRequest<GRSSAPResultModel>
    {
        /// <summary>
        /// Get or set GRSNO property
        /// </summary>        
        public string GRSNO { get; set; }

        /// <summary>
        /// Get or set ISOK property
        /// </summary>        
        public string ISOK { get; set; }

        /// <summary>
        /// Get or set Error property
        /// </summary>        
        public string Error { get; set; }

        /// <summary>
        /// Get or set NTID property
        /// </summary>        
        public string NTID { get; set; }

        /// <summary>
        /// Get or set PayLoad property
        /// </summary>        
        public string PayLoad { get; set; }

   }
}
