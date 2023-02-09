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
    public class DefectManagementRepository : BaseRepository<DefectManagement, int>, IDefectManagementRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public DefectManagementRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new DefectManagement into database
        /// </summary>
        /// <param name="DefectManagement">New entity of DefectManagement, <see cref="DefectManagement"/></param>
        /// <returns>Saved entity of Role, <see cref="DefectManagement"/></returns>
        public async Task<DefectManagement> AddAsync(DefectManagement defectManagement, string changeReason)
        {
            return await AddAsync(defectManagement, Constants.AuditLog.Title.AddDefectManagement(defectManagement.Id), changeReason);
        }

        /// <summary>
        /// Updates existing DefectManagement with new values
        /// </summary>
        /// <param name="DefectManagement">Updated entity of DefectManagement, <see cref="DefectManagement"/></param>
        /// <returns>Saved entity of DefectManagement, <see cref="DefectManagement"/></returns>
        public async Task<DefectManagement> UpdateAsync(DefectManagement defectManagement, string changeReason)
        {
            return await UpdateAsync(defectManagement, Constants.AuditLog.Title.EditDefectManagement(defectManagement.Id), changeReason);
        }

        /// <summary>
        /// Checks if the DefectManagement with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">DefectManagement Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed DefectManagement, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var defectManagement = await ValidateExistsAndGetAsync(id);

            SetAuditLog(defectManagement, Constants.AuditLog.Title.DeleteDefectManagement(defectManagement.Id), changeReason);

            return Remove(defectManagement);
        }
    }
}

