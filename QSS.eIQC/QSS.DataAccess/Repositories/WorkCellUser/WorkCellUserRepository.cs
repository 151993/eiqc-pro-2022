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
    public class WorkCellUserRepository : BaseRepository<WorkCellUser, int>, IWorkCellUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public WorkCellUserRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new WorkCellUser into database
        /// </summary>
        /// <param name="WorkCellUser">New entity of WorkCellUser, <see cref="WorkCellUser"/></param>
        /// <returns>Saved entity of Role, <see cref="WorkCellUser"/></returns>
        public async Task<WorkCellUser> AddAsync(WorkCellUser workCellUser, string changeReason)
        {
            return await AddAsync(workCellUser, Constants.AuditLog.Title.AddWorkCellUser(workCellUser.WorkCellId.ToString()), changeReason);
        }

        /// <summary>
        /// Updates existing WorkCellUser with new values
        /// </summary>
        /// <param name="WorkCellUser">Updated entity of WorkCellUser, <see cref="WorkCellUser"/></param>
        /// <returns>Saved entity of WorkCellUser, <see cref="WorkCellUser"/></returns>
        public async Task UpdateAsync(WorkCellUser workCellUser, string changeReason)
        {
            await UpdateAsync(workCellUser, Constants.AuditLog.Title.EditWorkCellUser(workCellUser.WorkCellId.ToString()), changeReason);
        }

        /// <summary>
        /// Checks if the WorkCellUser with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">WorkCellUser Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed WorkCellUser, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var workCellUser = await ValidateExistsAndGetAsync(id);

            SetAuditLog(workCellUser, Constants.AuditLog.Title.DeleteWorkCellUser(workCellUser.WorkCellId.ToString()), changeReason);

            Remove(workCellUser);
        }
    }
}

