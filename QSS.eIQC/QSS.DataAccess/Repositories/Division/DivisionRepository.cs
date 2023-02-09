using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for Division, provides Add, Update and Delete operations
 /// </summary>
    public class DivisionRepository : BaseRepository<Division, int>, IDivisionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public DivisionRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Created new Division into database
        /// </summary>
        /// <param name="Division">New entity of Division, <see cref="Division"/></param>
        /// <returns>Saved entity of Division, <see cref="Division"/></returns>
        public async Task<Division> AddAsync(Division division, string changeReason)
        {
            return await AddAsync(division, Constants.AuditLog.Title.AddDivision(division.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Division with new values
        /// </summary>
        /// <param name="Division">Updated entity of Division, <see cref="Division"/></param>
        /// <returns>Saved entity of Division, <see cref="Division"/></returns>
        public async Task<Division> UpdateAsync(Division division, string changeReason)
        {
            return await UpdateAsync(division, Constants.AuditLog.Title.EditDivision(division.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Division with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by Division to store into audit log</param>
        /// <returns>Returns instance of removed Division, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var division = await ValidateExistsAndGetAsync(id);

            SetAuditLog(division, Constants.AuditLog.Title.DeleteDivision(division.Name), changeReason);

            return Remove(division);
        }
    }
}
