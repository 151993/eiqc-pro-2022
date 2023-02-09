/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartResultOrientedParameterRepository : BaseRepository<PartResultOrientedParameter, int>, IPartResultOrientedParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartResultOrientedParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartResultOrientedParameters.Count > 0)
            {
                var partResultOrientedParameterToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partResultOrientedParameterToRemove != null)
                {
                    this.RemoveRange(partResultOrientedParameterToRemove);
                }
            }
            else
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

