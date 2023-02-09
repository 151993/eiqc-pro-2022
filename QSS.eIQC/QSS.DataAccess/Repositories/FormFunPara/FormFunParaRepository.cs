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
    public class FormFunParaRepository : BaseRepository<FormFunPara, int>, IFormFunParaRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public FormFunParaRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new FormFunPara into database
        /// </summary>
        /// <param name="FormFunPara">New entity of FormFunPara, <see cref="FormFunPara"/></param>
        /// <returns>Saved entity of Role, <see cref="FormFunPara"/></returns>
        public async Task<FormFunPara> AddAsync(FormFunPara formFunPara, string changeReason)
        {
            return await AddAsync(formFunPara, Constants.AuditLog.Title.AddFormFunPara(formFunPara.ParameterName), changeReason);
        }

        /// <summary>
        /// Updates existing FormFunPara with new values
        /// </summary>
        /// <param name="FormFunPara">Updated entity of FormFunPara, <see cref="FormFunPara"/></param>
        /// <returns>Saved entity of FormFunPara, <see cref="FormFunPara"/></returns>
        public async Task UpdateAsync(FormFunPara formFunPara, string changeReason)
        {
            await UpdateAsync(formFunPara, Constants.AuditLog.Title.EditFormFunPara(formFunPara.ParameterName), changeReason);
        }

        /// <summary>
        /// Checks if the FormFunPara with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">FormFunPara Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed FormFunPara, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var formFunPara = await ValidateExistsAndGetAsync(id);

            SetAuditLog(formFunPara, Constants.AuditLog.Title.DeleteFormFunPara(formFunPara.ParameterName), changeReason);

            Remove(formFunPara);
        }
    }
}

