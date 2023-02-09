/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartDimensionRepository : BaseRepository<PartDimension, int>, IPartDimensionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartDimensionRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new PartDimension into database
        /// </summary>
        /// <param name="PartDimension">New entity of PartDimension, <see cref="PartDimension"/></param>
        /// <returns>Saved entity of Role, <see cref="PartDimension"/></returns>
        public async Task<PartDimension> AddAsync(PartDimension partDimension, string changeReason)
        {
            return await AddAsync(partDimension, Constants.AuditLog.Title.AddPartDimension(partDimension.Name), changeReason);
        }

        /// <summary>
        /// Updates existing PartDimension with new values
        /// </summary>
        /// <param name="PartDimension">Updated entity of PartDimension, <see cref="PartDimension"/></param>
        /// <returns>Saved entity of PartDimension, <see cref="PartDimension"/></returns>
        public async Task<PartDimension> UpdateAsync(PartDimension partDimension, string changeReason)
        {
            return await UpdateAsync(partDimension, Constants.AuditLog.Title.EditPartDimension(partDimension.Name), changeReason);
        } 

        /// <summary>
        /// Checks if the PartDimension with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">PartDimension Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PartDimension, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var partDimension = await ValidateExistsAndGetAsync(id);

            SetAuditLog(partDimension, Constants.AuditLog.Title.DeletePartDimension(partDimension.Name), changeReason);

            return Remove(partDimension);
        }
    }
}

