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
    public class PartTestReportParameterRepository : BaseRepository<PartTestReportParameter, int>, IPartTestReportParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartTestReportParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartTestReportParameters.Count > 0)
            {
                var partTestReportParametersrToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partTestReportParametersrToRemove != null)
                {
                    this.RemoveRange(partTestReportParametersrToRemove);
                }
            }
        }

        public void AddRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartTestReportParameters.Count > 0)
            {
                var partTestReportParametersrToAdd = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partTestReportParametersrToAdd != null)
                {
                    this.AddRange(partTestReportParametersrToAdd);
                }
            }
        }

            public async Task UpdateAsync(PartTestReportParameter partTestReportParameter, string changeReason)
        {
            await UpdateAsync(partTestReportParameter, Constants.AuditLog.Title.EditPartTestReportParameter(string.Empty), changeReason);
        }

    }
}

