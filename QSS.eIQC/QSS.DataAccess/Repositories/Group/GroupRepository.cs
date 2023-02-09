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
    public class GroupRepository : BaseRepository<Group, int>, IGroupRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public GroupRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Group into database
        /// </summary>
        /// <param name="Group">New entity of Group, <see cref="Group"/></param>
        /// <returns>Saved entity of Role, <see cref="Group"/></returns>
        public async Task<Group> AddAsync(Group group, string changeReason)
        {
            return await AddAsync(group, Constants.AuditLog.Title.AddGroup(group.WareHouse), changeReason);
        }

        /// <summary>
        /// Updates existing Group with new values
        /// </summary>
        /// <param name="Group">Updated entity of Group, <see cref="Group"/></param>
        /// <returns>Saved entity of Group, <see cref="Group"/></returns>
        public async Task UpdateAsync(Group group, string changeReason)
        {
            await UpdateAsync(group, Constants.AuditLog.Title.EditGroup(group.WareHouse), changeReason);
        }

        /// <summary>
        /// Checks if the Group with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Group Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Group, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteGroup(role.WareHouse), changeReason);

            Remove(role);
        }
    }
}

