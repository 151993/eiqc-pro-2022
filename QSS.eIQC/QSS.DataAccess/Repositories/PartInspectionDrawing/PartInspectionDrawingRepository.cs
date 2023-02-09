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
    public class PartInspectionDrawingRepository : BaseRepository<PartInspectionDrawing, int>, IPartInspectionDrawingRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartInspectionDrawingRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartInspectionDrawings.Count > 0)
            {
                var partInspectionDrawingsrToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partInspectionDrawingsrToRemove != null)
                {
                    this.RemoveRange(partInspectionDrawingsrToRemove);
                }
            }
        }

        public void AddRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartInspectionDrawings.Count > 0)
            {
                var partInspectionDrawingsrToAdd = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partInspectionDrawingsrToAdd != null)
                {
                    this.AddRange(partInspectionDrawingsrToAdd);
                }
            }
        }

            public async Task UpdateAsync(PartInspectionDrawing partInspectionDrawing, string changeReason)
        {
            await UpdateAsync(partInspectionDrawing, Constants.AuditLog.Title.EditPartInspectionDrawing(string.Empty), changeReason);
        }

    }
}

