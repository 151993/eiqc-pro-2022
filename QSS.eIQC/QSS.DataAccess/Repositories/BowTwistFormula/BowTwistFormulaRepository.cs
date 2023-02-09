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
    public class BowTwistFormulaRepository : BaseRepository<BowTwistFormula, int>, IBowTwistFormulaRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public BowTwistFormulaRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new BowTwistFormula into database
        /// </summary>
        /// <param name="BowTwistFormula">New entity of BowTwistFormula, <see cref="BowTwistFormula"/></param>
        /// <returns>Saved entity of Role, <see cref="BowTwistFormula"/></returns>
        public async Task<BowTwistFormula> AddAsync(BowTwistFormula bowTwistFormula, string changeReason)
        {
            return await AddAsync(bowTwistFormula, Constants.AuditLog.Title.AddBowTwistFormula(bowTwistFormula.Name), changeReason);
        }

        /// <summary>
        /// Updates existing BowTwistFormula with new values
        /// </summary>
        /// <param name="BowTwistFormula">Updated entity of BowTwistFormula, <see cref="BowTwistFormula"/></param>
        /// <returns>Saved entity of BowTwistFormula, <see cref="BowTwistFormula"/></returns>
        public async Task<BowTwistFormula> UpdateAsync(BowTwistFormula bowTwistFormula, string changeReason)
        {
            return await UpdateAsync(bowTwistFormula, Constants.AuditLog.Title.EditBowTwistFormula(bowTwistFormula.Name), changeReason);
        }

        /// <summary>
        /// Checks if the BowTwistFormula with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">BowTwistFormula Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed BowTwistFormula, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var bowTwistFormula = await ValidateExistsAndGetAsync(id);

            SetAuditLog(bowTwistFormula, Constants.AuditLog.Title.DeleteBowTwistFormula(bowTwistFormula.Name), changeReason);

            return Remove(bowTwistFormula);
        }
    }
}

