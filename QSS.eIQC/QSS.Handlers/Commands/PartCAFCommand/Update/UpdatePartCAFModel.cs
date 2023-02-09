/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.PartCAFCommand.Update
{
    /// <summary>
    /// Representation model for Update PartCAF operation
    /// </summary>
    public class UpdatePartCAFModel : BaseUpdateCommand<int>, IRequest<PartCAFModel>
    {
        /// <summary>
        /// Get or set PartNo property
        /// </summary>        
        public string PartNo { get; set; }

        /// <summary>
        /// Get or set Hyperlink property
        /// </summary>        
        public string Hyperlink { get; set; }


    }
}
