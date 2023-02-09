using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for Region, provides Add, Update and Delete operations
 /// </summary>
    public class RegionRepository : BaseRepository<Region, int>, IRegionRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public RegionRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Created new Region into database
        /// </summary>
        /// <param name="Region">New entity of Region, <see cref="Region"/></param>
        /// <returns>Saved entity of Region, <see cref="Region"/></returns>
        public async Task<Region> AddAsync(Region region,string changeReason)
        {
            return await AddAsync(region, Constants.AuditLog.Title.AddRegion(region.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Region with new values
        /// </summary>
        /// <param name="Region">Updated entity of Region, <see cref="Region"/></param>
        /// <returns>Saved entity of Region, <see cref="Region"/></returns>
        public async Task<Region> UpdateAsync(Region region, string changeReason)
        {
            return await UpdateAsync(region, Constants.AuditLog.Title.EditRegion(region.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Region with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Region, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var region = await ValidateExistsAndGetAsync(id);

            SetAuditLog(region, Constants.AuditLog.Title.DeleteRegion(region.Name), changeReason);

            return Remove(region);
        }
    }
}
