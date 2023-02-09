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
    public class PartMeasurementParameterRepository : BaseRepository<PartMeasurementParameter, int>, IPartMeasurementParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartMeasurementParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartMeasurementParameters.Count > 0)
            {
                var partMeasurementParameterToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partMeasurementParameterToRemove != null)
                {
                    this.RemoveRange(partMeasurementParameterToRemove);
                }
            }
            else if(sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartMeasurementParameters!=null && sAPPartInspectionPlan.PartMeasurementParameters.Count == 0)
            {
                this.RemoveRange(this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id));
            }
        }
    }
}

