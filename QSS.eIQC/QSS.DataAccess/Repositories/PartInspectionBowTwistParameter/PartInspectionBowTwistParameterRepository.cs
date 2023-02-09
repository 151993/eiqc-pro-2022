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
    public class PartInspectionBowTwistParameterRepository : BaseRepository<PartInspectionBowTwistParameter, int>, IPartInspectionBowTwistParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartInspectionBowTwistParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new PartBowTwistParameter into database
        /// </summary>
        /// <param name="PartBowTwistParameter">New entity of PartBowTwistParameter, <see cref="PartBowTwistParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="PartBowTwistParameter"/></returns>
        public async Task<PartInspectionBowTwistParameter> AddAsync(PartInspectionBowTwistParameter partInspectionBowTwistParameter, string changeReason)
        {
            return await AddAsync(partInspectionBowTwistParameter, Constants.AuditLog.Title.AddPartBowTwistParameter(String.Empty), changeReason);
        }

        /// <summary>
        /// Updates existing PartBowTwistParameter with new values
        /// </summary>
        /// <param name="PartBowTwistParameter">Updated entity of PartBowTwistParameter, <see cref="PartBowTwistParameter"/></param>
        /// <returns>Saved entity of PartBowTwistParameter, <see cref="PartBowTwistParameter"/></returns>
        public async Task UpdateAsync(PartInspectionBowTwistParameter partInspectionBowTwistParameter, string changeReason)
        {
            await UpdateAsync(partInspectionBowTwistParameter, Constants.AuditLog.Title.EditPartBowTwistParameter(String.Empty), changeReason);
        }

        /// <summary>
        /// Checks if the PartBowTwistParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">PartBowTwistParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PartBowTwistParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var partBowTwistParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(partBowTwistParameter, Constants.AuditLog.Title.DeletePartBowTwistParameter(String.Empty), changeReason);

            Remove(partBowTwistParameter);
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartInspectionBowTwistParameters.Count > 0)
            {
                var partInspectionBowTwistParameterToRemove = this.Find(m => m.SAPPartInspectionPlanId == sAPPartInspectionPlan.Id);
                if (partInspectionBowTwistParameterToRemove != null)
                {
                    this.RemoveRange(partInspectionBowTwistParameterToRemove);
                }
            }
        }

    }
}

