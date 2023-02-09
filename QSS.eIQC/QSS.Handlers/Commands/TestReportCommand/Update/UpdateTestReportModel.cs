/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.TestReportCommand.Update
{
    /// <summary>
    /// Representation model for Update TestReport operation
    /// </summary>
    public class UpdateTestReportModel : BaseUpdateCommand<int>, IRequest<TestReportModel>
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

        public List<int> RemovedCommodityIds { get; set; }


    }
}
