/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.GoodsReceiveUserCommand.Update
{
    /// <summary>
    /// Representation model for Update GoodsReceiveUser operation
    /// </summary>
    public class UpdateGoodsReceiveUserModel : BaseUpdateCommand<int>, IRequest<GoodsReceiveUserModel>
    {
        /// <summary>
        /// Get or set WareHouse property
        /// </summary>        
        public string WareHouse { get; set; }

        /// <summary>
        /// Get or set SAPUser property
        /// </summary>        
        public string SAPUser { get; set; }

        /// <summary>
        /// Get or set UserName property
        /// </summary>        
        public string UserName { get; set; }

        /// <summary>
        /// Get or set SupervisorMail property
        /// </summary>        
        public string SupervisorMail { get; set; }

        /// <summary>
        /// Get or set LeaderMail property
        /// </summary>        
        public string LeaderMail { get; set; }

    }
}
