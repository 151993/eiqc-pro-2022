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
    public class PartInspectionSpecificationRepository : BaseRepository<PartInspectionSpecification, int>, IPartInspectionSpecificationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartInspectionSpecificationRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartInspectionSpecifications.Count > 0)
            {
                var partInspectionSpecificationsrToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partInspectionSpecificationsrToRemove != null)
                {
                    this.RemoveRange(partInspectionSpecificationsrToRemove);
                }
            }
        }

        public void AddRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartInspectionSpecifications.Count > 0)
            {
                var partInspectionSpecificationsrToAdd = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partInspectionSpecificationsrToAdd != null)
                {
                    this.AddRange(partInspectionSpecificationsrToAdd);
                }
            }
        }

            public async Task UpdateAsync(PartInspectionSpecification partInspectionSpecification, string changeReason)
        {
            await UpdateAsync(partInspectionSpecification, Constants.AuditLog.Title.EditPartInspectionSpecification(string.Empty), changeReason);
        }

    }
}

