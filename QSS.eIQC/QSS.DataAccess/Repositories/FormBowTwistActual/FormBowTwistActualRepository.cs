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
    public class FormBowTwistActualRepository : BaseRepository<FormBowTwistActual, int>, IFormBowTwistActualRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormBowTwistActualRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormBowTwistActual into database
        /// </summary>
        /// <param name="FormBowTwistActual">New entity of FormBowTwistActual, <see cref="FormBowTwistActual"/></param>
        /// <returns>Saved entity of Role, <see cref="FormBowTwistActual"/></returns>
        public async Task<FormBowTwistActual> AddAsync(FormBowTwistActual formBowTwistActual, string changeReason)
        {
            return await AddAsync(formBowTwistActual, Constants.AuditLog.Title.AddFormBowTwistActual(formBowTwistActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormBowTwistActual with new values
        /// </summary>
        /// <param name="FormBowTwistActual">Updated entity of FormBowTwistActual, <see cref="FormBowTwistActual"/></param>
        /// <returns>Saved entity of FormBowTwistActual, <see cref="FormBowTwistActual"/></returns>
        public async Task UpdateAsync(FormBowTwistActual formBowTwistActual, string changeReason)
        {
            await UpdateAsync(formBowTwistActual, Constants.AuditLog.Title.EditFormBowTwistActual(formBowTwistActual.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormBowTwistActual with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormBowTwistActual Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormBowTwistActual, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formBowTwistActual = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formBowTwistActual, Constants.AuditLog.Title.DeleteFormBowTwistActual(formBowTwistActual.ParameterName), changeReason);

            Remove(formBowTwistActual);
        }
    }
}

