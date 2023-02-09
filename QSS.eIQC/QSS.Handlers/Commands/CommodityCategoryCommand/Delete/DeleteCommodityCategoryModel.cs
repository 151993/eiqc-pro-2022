/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Delete
{
    /// <summary>
    /// Representation model for Delete CommodityCategory operation
    /// </summary>
    public class DeleteCommodityCategoryModel : IRequest<DeleteCommodityCategoryResponse>
    {
        /// <summary>
        /// CommodityCategory Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
