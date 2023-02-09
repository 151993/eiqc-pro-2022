/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand.Add
{
    /// <summary>
    /// Representation model for Add TestReport operation
    /// </summary>
    public class AddTestReportModel : BaseCommand, IRequest<TestReportModel>
    {
        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>        
        public string Description { get; set; }

        public List<int> AddedCommodityIds { get; set; }

    }
}
