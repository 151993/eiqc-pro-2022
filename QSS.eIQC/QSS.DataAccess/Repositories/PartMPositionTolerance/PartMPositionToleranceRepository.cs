/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartMPositionToleranceRepository : BaseRepository<PartMPositionTolerance, int>, IPartMPositionToleranceRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartMPositionToleranceRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartMPositionTolerances.Count > 0)
            {
                var partMPositionTolerancesToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partMPositionTolerancesToRemove != null)
                {
                    this.RemoveRange(partMPositionTolerancesToRemove);
                }
            }
            else if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartMPositionTolerances != null && sAPPartInspectionPlan.PartMPositionTolerances.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

