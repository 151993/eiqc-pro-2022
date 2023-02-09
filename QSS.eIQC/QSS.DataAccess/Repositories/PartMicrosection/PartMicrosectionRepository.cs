/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartMicrosectionRepository : BaseRepository<PartMicrosection, int>, IPartMicrosectionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartMicrosectionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartMicrosectionParameters.Count > 0)
            {
                var partMicrosectionParameterToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partMicrosectionParameterToRemove != null)
                {
                    this.RemoveRange(partMicrosectionParameterToRemove);
                }
            }
            else if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartMicrosectionParameters != null && sAPPartInspectionPlan.PartMicrosectionParameters.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

