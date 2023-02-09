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
    public class PartCountParameterRepository : BaseRepository<PartCountParameter, int>, IPartCountParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartCountParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartCountParameters.Count > 0)
            {
                var partPartCountParametersToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partPartCountParametersToRemove != null)
                {
                    this.RemoveRange(partPartCountParametersToRemove);
                }
            }
            else
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

