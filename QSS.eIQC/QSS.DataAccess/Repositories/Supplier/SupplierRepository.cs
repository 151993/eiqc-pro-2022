
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for Supplier, provides Add, Update and Delete operations
 /// </summary>
    public class SupplierRepository : BaseRepository<Supplier, int>, ISupplierRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SupplierRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Created new Supplier into database
        /// </summary>
        /// <param name="Supplier">New entity of Supplier, <see cref="Supplier"/></param>
        /// <returns>Saved entity of Supplier, <see cref="Supplier"/></returns>
        public async Task<Supplier> AddAsync(Supplier supplier,string changeReason)
        {
            return await AddAsync(supplier, Constants.AuditLog.Title.AddSupplier(supplier.Email), changeReason);
        }

        /// <summary>
        /// Updates existing Supplier with new values
        /// </summary>
        /// <param name="Supplier">Updated entity of Supplier, <see cref="Supplier"/></param>
        /// <returns>Saved entity of Supplier, <see cref="Supplier"/></returns>
        public async Task<Supplier> UpdateAsync(Supplier supplier, string changeReason)
        {
            return await UpdateAsync(supplier, Constants.AuditLog.Title.EditSupplier(supplier.Email), changeReason);
        }

        /// <summary>
        /// Checks if the Supplier with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Supplier, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var supplier = await ValidateExistsAndGetAsync(id);

            SetAuditLog(supplier, Constants.AuditLog.Title.DeleteSupplier(supplier.Email), changeReason);

            return Remove(supplier);
        }
    }
}
