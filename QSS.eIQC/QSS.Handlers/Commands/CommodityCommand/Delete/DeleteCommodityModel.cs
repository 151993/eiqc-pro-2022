using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Delete
{
    public class DeleteCommodityModel : IRequest<DeleteCommodityResponse>
    {
        /// <summary>
        /// Commodity Id to be deleted
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Change reason to be logged into Audit Log 
        /// </summary>
        public string ChangeReason { get; set; }
    }
}
