/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartFunParameterRepository : BaseRepository<PartFunParameter, int>, IPartFunParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartFunParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        
        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartFunParameters.Count > 0)
            {
                var partFunParameterToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partFunParameterToRemove != null)
                {
                    this.RemoveRange(partFunParameterToRemove);
                }
            }
            else if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartFunParameters != null && sAPPartInspectionPlan.PartFunParameters.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

