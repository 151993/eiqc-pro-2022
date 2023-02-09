using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for Country, provides Add, Update and Delete operations
    /// </summary>
    public class CountryRepository : BaseRepository<Country, int>, ICountryRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CountryRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Created new Country into database
        /// </summary>
        /// <param name="Country">New entity of Country, <see cref="Country"/></param>
        /// <returns>Saved entity of Country, <see cref="Country"/></returns>
        public async Task<Country> AddAsync(Country Country, string changeReason)
        {
            return await AddAsync(Country, Constants.AuditLog.Title.AddCountry(Country.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Country with new values
        /// </summary>
        /// <param name="Country">Updated entity of Country, <see cref="Country"/></param>
        /// <returns>Saved entity of Country, <see cref="Country"/></returns>
        public async Task<Country> UpdateAsync(Country country, string changeReason)
        {
            return await UpdateAsync(country, Constants.AuditLog.Title.EditCountry(country.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Country with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Country, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var country = await ValidateExistsAndGetAsync(id);

            SetAuditLog(country, Constants.AuditLog.Title.DeleteCountry(country.Name), changeReason);

            return Remove(country);
        }
    }
}
