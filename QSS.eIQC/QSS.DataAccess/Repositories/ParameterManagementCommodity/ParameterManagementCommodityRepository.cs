using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for ParameterManagementCommodity, provides Add, Update and Delete operations
    /// </summary>
    public class ParameterManagementCommodityRepository : Repository<ParameterManagementCommodity,int>, IParameterManagementCommodityRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ParameterManagementCommodityRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of ParameterManagementCommodity associated with User in database.
        /// </summary>
        /// <param name="ParameterManagement">ParameterManagement object</param>
        /// <param name="commodityNameIds">List of Commodity Ids to be added</param>
        public void AddParameterCommodityNames(ParameterManagement parameterManagement, List<int> commodityNameIds)
        {
            if (commodityNameIds != null && commodityNameIds.IsAny())
            {
                AddRange(commodityNameIds.Select(r =>
                   new ParameterManagementCommodity()
                   {
                       ParameterManagement = parameterManagement,
                       CommodityId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the ParameterManagementCommodity with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">User Id</param>
        /// <param name="commodityNameIds">List of ParameterManagementCommodity Ids to be deleted</param>
        /// <returns>Returns instance of removed ParameterManagementCommodity, <see cref="UserRole"/></returns>
        public void RemoveParameterCommodityNames(int parameterManagementId, List<int> commodityNameIds)
        {
            if (commodityNameIds != null && commodityNameIds.IsAny())
            {
                var parameterManagementCommodities = Context.Set<ParameterManagementCommodity>()
                                .Where(s => s.ParameterManagementId == parameterManagementId)
                                .Where(d => commodityNameIds.Contains(d.CommodityId))
                                .ToList();


                if (!parameterManagementCommodities.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.ParameterManagementCommodityNameIdCodeDoesNotExists(parameterManagementId));
                }

                RemoveRange(parameterManagementCommodities);
            }
        }
    }
}
