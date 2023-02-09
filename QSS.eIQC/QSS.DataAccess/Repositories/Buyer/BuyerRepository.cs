/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class BuyerRepository : BaseRepository<Buyer, int>, IBuyerRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public BuyerRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Buyer into database
        /// </summary>
        /// <param name="Buyer">New entity of Buyer, <see cref="Buyer"/></param>
        /// <returns>Saved entity of Role, <see cref="Buyer"/></returns>
        public async Task<Buyer> AddAsync(Buyer buyer, string changeReason)
        {
            return await AddAsync(buyer, Constants.AuditLog.Title.AddBuyer(buyer.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Buyer with new values
        /// </summary>
        /// <param name="Buyer">Updated entity of Buyer, <see cref="Buyer"/></param>
        /// <returns>Saved entity of Buyer, <see cref="Buyer"/></returns>
        public async Task UpdateAsync(Buyer buyer, string changeReason)
        {
            await UpdateAsync(buyer, Constants.AuditLog.Title.EditBuyer(buyer.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Buyer with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Buyer Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Buyer, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteBuyer(role.Name), changeReason);

            Remove(role);
        }
    }
}

