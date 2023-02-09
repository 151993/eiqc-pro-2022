

using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{

    /// <summary>
    /// Repository for SAPPartInspectionPlanSupplier, provides Add, Update and Delete operations
    /// </summary>
    public class SAPPartInspectionPlanSupplierRepository : Repository<SAPPartInspectionPlanSupplier, int>, ISAPPartInspectionPlanSupplierRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SAPPartInspectionPlanSupplierRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Dependency associated with SAPPartInspectionPlan in database.
        /// </summary>
        /// <param name="SAPPartInspectionPlan">SAPPartInspectionPlan object</param>
        /// <param name="addedSAPPartInspectionPlanIds">List of Ids to be added</param>
        public async Task<IEnumerable<SAPPartInspectionPlanSupplier>> AddSAPPartInspectionPlanSuppliers(SAPPartInspectionPlan sapPartInspectionPlan, List<int> SAPPartInspectionPlanIds)
        {
            IEnumerable<SAPPartInspectionPlanSupplier> sapPartInspectionPlanSupplier = null;
            if (SAPPartInspectionPlanIds != null && SAPPartInspectionPlanIds.IsAny())
            {
                sapPartInspectionPlanSupplier = SAPPartInspectionPlanIds.Select(r =>
                   new SAPPartInspectionPlanSupplier()
                   {
                       SAPPartInspectionPlan = sapPartInspectionPlan,
                       SAPPartInspectionPlanId = r
                   }
                );
                AddRange(sapPartInspectionPlanSupplier);
            }
            return sapPartInspectionPlanSupplier;
        }

        /// <summary>
        /// Checks if the SAPPartInspectionPlanSupplier with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id</param>
        /// <param name="SAPPartInspectionPlanIds">List of Ids to be deleted</param>
        public async Task<IEnumerable<SAPPartInspectionPlanSupplier>> RemoveSAPPartInspectionPlanSuppliers(int sapPartInspectionPlanId, List<int> SAPPartInspectionPlanIds)
        {
            if (SAPPartInspectionPlanIds != null && SAPPartInspectionPlanIds.IsAny())
            {
                var sapPartInspectionPlanSuppliers = Context.Set<SAPPartInspectionPlanSupplier>()
                                .Where(s => s.SAPPartInspectionPlanId == sapPartInspectionPlanId)
                                .Where(d => SAPPartInspectionPlanIds.Contains(d.SAPPartInspectionPlanId))
                                .ToList();


                if (!sapPartInspectionPlanSuppliers.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SAPPartInspectionPlanSupplierDoesNotExists(sapPartInspectionPlanId));
                }

                RemoveRange(sapPartInspectionPlanSuppliers);

                return sapPartInspectionPlanSuppliers;
            }

            return Enumerable.Empty<SAPPartInspectionPlanSupplier>();
        }
    }

}
