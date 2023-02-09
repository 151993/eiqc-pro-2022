using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;


namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for Location, provides Add, Update and Delete operations
 /// </summary>
    public class LocationRepository : BaseRepository<Location, int>, ILocationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public LocationRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Created new Location into database
        /// </summary>
        /// <param name="Location">New entity of Location, <see cref="Location"/></param>
        /// <returns>Saved entity of Location, <see cref="Location"/></returns>
        public async Task<Location> AddAsync(Location location, string changeReason)
        {
            return await AddAsync(location, Constants.AuditLog.Title.AddLocation(location.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Location with new values
        /// </summary>
        /// <param name="Location">Updated entity of Location, <see cref="Location"/></param>
        /// <returns>Saved entity of Location, <see cref="Location"/></returns>
        public async Task UpdateAsync(Location location, string changeReason)
        {
            await UpdateAsync(location, Constants.AuditLog.Title.EditLocation(location.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Location with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Location, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var location = await ValidateExistsAndGetAsync(id);

            SetAuditLog(location, Constants.AuditLog.Title.DeleteLocation(location.Name), changeReason);

            Remove(location);
        }
    }
}
