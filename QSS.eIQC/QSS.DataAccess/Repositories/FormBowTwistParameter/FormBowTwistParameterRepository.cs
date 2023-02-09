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
    public class FormBowTwistParameterRepository : BaseRepository<FormBowTwistParameter, int>, IFormBowTwistParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormBowTwistParameterRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormBowTwistParameter into database
        /// </summary>
        /// <param name="FormBowTwistParameter">New entity of FormBowTwistParameter, <see cref="FormBowTwistParameter"/></param>
        /// <returns>Saved entity of Role, <see cref="FormBowTwistParameter"/></returns>
        public async Task<FormBowTwistParameter> AddAsync(FormBowTwistParameter formBowTwistParameter, string changeReason)
        {
            return await AddAsync(formBowTwistParameter, Constants.AuditLog.Title.AddFormBowTwistParameter(formBowTwistParameter.Spec), changeReason);
        }

        /// <summary>
        /// Updates existing FormBowTwistParameter with new values
        /// </summary>
        /// <param name="FormBowTwistParameter">Updated entity of FormBowTwistParameter, <see cref="FormBowTwistParameter"/></param>
        /// <returns>Saved entity of FormBowTwistParameter, <see cref="FormBowTwistParameter"/></returns>
        public async Task UpdateAsync(FormBowTwistParameter formBowTwistParameter, string changeReason)
        {
            await UpdateAsync(formBowTwistParameter, Constants.AuditLog.Title.EditFormBowTwistParameter(formBowTwistParameter.Spec), changeReason);
        }

        /// <summary>
        /// Checks if the FormBowTwistParameter with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormBowTwistParameter Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormBowTwistParameter, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formBowTwistParameter = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formBowTwistParameter, Constants.AuditLog.Title.DeleteFormBowTwistParameter(formBowTwistParameter.Spec), changeReason);

            Remove(formBowTwistParameter);
        }
    }
}

