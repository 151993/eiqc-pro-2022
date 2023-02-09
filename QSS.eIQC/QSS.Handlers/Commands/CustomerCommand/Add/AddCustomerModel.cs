/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CustomerCommand.Add
{
    /// <summary>
    /// Representation model for Add Role operation
    /// </summary>
    public class AddCustomerModel : BaseCommand, IRequest<CustomerModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }
        /// <summary>
        /// Get or set CAFPath property
        /// </summary>        
        public string CAFPath { get; set; }
        /// <summary>
        /// Get or set DCCSavePath property
        /// </summary>        
        public string DCCSavePath { get; set; }
        /// <summary>
        /// Get or set CAFTempPath property
        /// </summary>        
        public string CAFTempPath { get; set; }
        /// <summary>
        /// Get or set BackupSavePath property
        /// </summary>        
        public string BackupSavePath { get; set; }

        public List<int> AddedUserIds { get; set; }

    }
}
