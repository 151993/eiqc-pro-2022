/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartLPositionToleranceRepository : BaseRepository<PartLPositionTolerance, int>, IPartLPositionToleranceRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartLPositionToleranceRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartLPositionTolerances.Count > 0)

            {
                var partLPositionTolerancesToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partLPositionTolerancesToRemove != null)
                {
                    this.RemoveRange(partLPositionTolerancesToRemove);
                }
            }
            else if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartLPositionTolerances != null && sAPPartInspectionPlan.PartLPositionTolerances.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

