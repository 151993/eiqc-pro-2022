/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.GroupCommand.Update
{
    /// <summary>
    /// Representation model for Update Group operation
    /// </summary>
    public class UpdateGroupModel : BaseUpdateCommand<int>, IRequest<GroupModel>
    {
        /// <summary>
        /// Get or set WareHouse property
        /// </summary>        
        public string WareHouse { get; set; }

        /// <summary>
        /// Get or set UserName property
        /// </summary>        
        public string UserName { get; set; }

    }
}
