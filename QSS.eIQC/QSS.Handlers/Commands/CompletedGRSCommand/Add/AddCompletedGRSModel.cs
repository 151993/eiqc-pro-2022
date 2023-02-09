    /* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.CompletedGRSCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddCompletedGRSModel : BaseCommand, IRequest<CompletedGRSModel>
    {
        /// <summary>
        /// Get or set PartNo property
        /// </summary>        
        public string PartNo { get; set; }
        /// <summary>
        /// Get or set UDCode property
        /// </summary>        
        public string UDCode { get; set; }
        /// <summary>
        /// Get or set GRSNo property
        /// </summary>        
        public string GRSNo { get; set; }

    }
}
