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
    public class PartDateCodeRepository : BaseRepository<PartDateCode, int>, IPartDateCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartDateCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new PartDateCode into database
        /// </summary>
        /// <param name="PartDateCode">New entity of PartDateCode, <see cref="PartDateCode"/></param>
        /// <returns>Saved entity of Role, <see cref="PartDateCode"/></returns>
        public async Task<PartDateCode> AddAsync(PartDateCode partDateCode, string changeReason)
        {
            return await AddAsync(partDateCode, Constants.AuditLog.Title.AddPartDateCode(partDateCode.DateCodeDetails), changeReason);
        }

        /// <summary>
        /// Updates existing PartDateCode with new values
        /// </summary>
        /// <param name="PartDateCode">Updated entity of PartDateCode, <see cref="PartDateCode"/></param>
        /// <returns>Saved entity of PartDateCode, <see cref="PartDateCode"/></returns>
        public async Task UpdateAsync(PartDateCode partDateCode, string changeReason)
        {
            await UpdateAsync(partDateCode, Constants.AuditLog.Title.EditPartDateCode(partDateCode.DateCodeDetails), changeReason);
        }

        /// <summary>
        /// Checks if the PartDateCode with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">PartDateCode Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PartDateCode, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var partDateCode = await ValidateExistsAndGetAsync(id);

            SetAuditLog(partDateCode, Constants.AuditLog.Title.DeletePartDateCode(partDateCode.DateCodeDetails), changeReason);

            Remove(partDateCode);
        }

        public void RemoveRange(SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (sAPPartInspectionPlan.Id != 0 && sAPPartInspectionPlan.PartDateCode!=null)
            {
                var partDateCodeToRemove = this.Find(m => m.Id == sAPPartInspectionPlan.PartDateCodeId);
                if (partDateCodeToRemove != null)
                {
                    this.RemoveRange(partDateCodeToRemove);
                }
            }
        }
    }
}

