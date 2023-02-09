
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
    /// Repository for SAPPartInspectionPlanAdminCertification, provides Add, Update and Delete operations
    /// </summary>
    public class SAPPartInspectionPlanAdminCertificationRepository : Repository<SAPPartInspectionPlanAdminCertification, int>, ISAPPartInspectionPlanAdminCertificationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SAPPartInspectionPlanAdminCertificationRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Dependency associated with SAPPartInspectionPlan in database.
        /// </summary>
        /// <param name="SAPPartInspectionPlan">SAPPartInspectionPlan object</param>
        /// <param name="AdminCertificateIds">List of Ids to be added</param>
        public async Task<IEnumerable<SAPPartInspectionPlanAdminCertification>> AddSAPPartInspectionPlanAdminCertifications(SAPPartInspectionPlan sapPartInspectionPlan, List<int> AdminCertificateIds)
        {
            IEnumerable<SAPPartInspectionPlanAdminCertification> sapPartInspectionPlanAdminCertification = null;
            if (AdminCertificateIds != null && AdminCertificateIds.IsAny())
            {
                sapPartInspectionPlanAdminCertification = AdminCertificateIds.Select(r =>
                   new SAPPartInspectionPlanAdminCertification()
                   {
                       SAPPartInspectionPlan = sapPartInspectionPlan,
                       AdminCertificationId = r
                   }
                );
                AddRange(sapPartInspectionPlanAdminCertification);
            }
            return sapPartInspectionPlanAdminCertification;
        }

        /// <summary>
        /// Checks if the SAPPartInspectionPlanAdminCertification with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id</param>
        /// <param name="AdminCertificateIds">List of Ids to be deleted</param>
        public async Task<IEnumerable<SAPPartInspectionPlanAdminCertification>> RemoveSAPPartInspectionPlanAdminCertifications(int sapPartInspectionPlanId, List<int> AdminCertificateIds)
        {
            if (AdminCertificateIds != null && AdminCertificateIds.IsAny())
            {
                var sapPartInspectionPlanAdminCertification = Context.Set<SAPPartInspectionPlanAdminCertification>()
                                .Where(s => s.SAPPartInspectionPlanId == sapPartInspectionPlanId)
                                .Where(d => AdminCertificateIds.Contains((int)d.AdminCertificationId))
                                .ToList();


                if (!sapPartInspectionPlanAdminCertification.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SAPPartInspectionPlanAdminCertificationDoesNotExists(sapPartInspectionPlanId));
                }

                RemoveRange(sapPartInspectionPlanAdminCertification);

                return sapPartInspectionPlanAdminCertification;
            }
            return Enumerable.Empty<SAPPartInspectionPlanAdminCertification>();
        }
    }
}
