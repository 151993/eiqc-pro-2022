

using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{

    /// <summary>
    /// Repository for SAPPartInspectionPlanSamplingPlan, provides Add, Update and Delete operations
    /// </summary>
    public class SAPPartInspectionPlanSamplingPlanRepository : Repository<SAPPartInspectionPlanSamplingPlan, int>, ISAPPartInspectionPlanSamplingPlanRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SAPPartInspectionPlanSamplingPlanRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of Dependency associated with SAPPartInspectionPlan in database.
        /// </summary>
        /// <param name="SAPPartInspectionPlan">SAPPartInspectionPlan object</param>
        /// <param name="addedSAPPartInspectionPlanIds">List of Ids to be added</param>
        //public async Task<SAPPartInspectionPlan> AddSAPPartInspectionPlanSamplingPlans(SAPPartInspectionPlan sapPartInspectionPlan, List<int> SAPPartInspectionPlanIds)
        //{
        //    foreach (var item in sapPartInspectionPlan.SAPPartInspectionPlanSamplingPlans)
        //    {
        //        sapPartInspectionPlan.SAPPartInspectionPlanSamplingPlans.Add(item);
        //    }
           
        //    //IEnumerable<SAPPartInspectionPlanSamplingPlan> sapPartInspectionPlanSamplingPlan = null;
        //    //if (SAPPartInspectionPlanIds != null && SAPPartInspectionPlanIds.IsAny())
        //    //{
        //    //    sapPartInspectionPlanSamplingPlan = SAPPartInspectionPlanIds.Select(r =>
        //    //       new SAPPartInspectionPlanSamplingPlan()
        //    //       {
        //    //           SAPPartInspectionPlan = sapPartInspectionPlan,
        //    //           SAPPartInspectionPlanId = r
        //    //       }
        //    //    );
        //    //    AddRange(sapPartInspectionPlanSamplingPlan);
        //    //}
        //    return sapPartInspectionPlan;
        //}

        public async Task<SAPPartInspectionPlan> AddSAPPartInspectionPlanSamplingPlans(SAPPartInspectionPlan sapPartInspectionPlan)
        {
            foreach (var partInspectionPlanSamplingPlan in sapPartInspectionPlan.SAPPartInspectionPlanSamplingPlans)
            {
                sapPartInspectionPlan.SAPPartInspectionPlanSamplingPlans.Add(new SAPPartInspectionPlanSamplingPlan
                {
                    SAPPartInspectionPlan = sapPartInspectionPlan,
                    MstrChar = partInspectionPlanSamplingPlan.MstrChar,
                    SmplProc= partInspectionPlanSamplingPlan.SmplProc,
                    Site = partInspectionPlanSamplingPlan.Site,
                    CertificateType = partInspectionPlanSamplingPlan.CertificateType
                });
            }
            return sapPartInspectionPlan;
        }

        /// <summary>
        /// Checks if the SAPPartInspectionPlanSamplingPlan with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id</param>
        /// <param name="SAPPartInspectionPlanIds">List of Ids to be deleted</param>
        public async Task<IEnumerable<SAPPartInspectionPlanSamplingPlan>> RemoveSAPPartInspectionPlanSamplingPlans(int sapPartInspectionPlanId, List<int> SAPPartInspectionPlanIds)
        {
            if (SAPPartInspectionPlanIds != null && SAPPartInspectionPlanIds.IsAny())
            {
                var sapPartInspectionPlanSamplingPlans = Context.Set<SAPPartInspectionPlanSamplingPlan>()
                                .Where(s => s.SAPPartInspectionPlanId == sapPartInspectionPlanId)
                                .Where(d => SAPPartInspectionPlanIds.Contains(d.Id))
                                .ToList();


                if (!sapPartInspectionPlanSamplingPlans.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.SAPPartInspectionPlanSamplingPlanDoesNotExists(sapPartInspectionPlanId));
                }

                RemoveRange(sapPartInspectionPlanSamplingPlans);

                return sapPartInspectionPlanSamplingPlans;
            }

            return Enumerable.Empty<SAPPartInspectionPlanSamplingPlan>();
        }
    }

}
