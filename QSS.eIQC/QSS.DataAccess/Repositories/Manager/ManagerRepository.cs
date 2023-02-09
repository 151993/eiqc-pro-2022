using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for Manager, provides Add, Update and Delete operations
 /// </summary>
    public class ManagerRepository : BaseRepository<Manager, int>, IManagerRepository
    {
        private readonly QSSContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ManagerRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Created new Manager into database
        /// </summary>
        /// <param name="Manager">New entity of Manager, <see cref="Manager"/></param>
        /// <returns>Saved entity of Manager, <see cref="Manager"/></returns>
        public async Task<Manager> AddAsync(Manager manager, string changeReason)
        {
            return await AddAsync(manager, Constants.AuditLog.Title.AddManager(manager.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Manager with new values
        /// </summary>
        /// <param name="Manager">Updated entity of Manager, <see cref="Manager"/></param>
        /// <returns>Saved entity of Manager, <see cref="Manager"/></returns>
        public async Task UpdateAsync(Manager manager, string changeReason)
        {
            await UpdateAsync(manager, Constants.AuditLog.Title.EditManager(manager.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Manager with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Manager, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var manager = await ValidateExistsAndGetAsync(id);

            SetAuditLog(manager, Constants.AuditLog.Title.DeleteManager(manager.Name), changeReason);

            Remove(manager);
        }
        /// <summary>
        /// Checks if manager name already exists in Database 
        /// </summary>
        /// <param name="name">manager Name</param>
        /// <returns>manager detail</returns>
        public async Task<Manager> GetManagerDetailByName(string name)
        {
          return await _context.Manager.FirstOrDefaultAsync(d => d.Name.ToLower() == name.ToLower());
           
        }
        /// <summary>
        /// Add new Manager into User object 
        /// </summary>
        /// <param name="name">user ,  managerName</param>
        /// <returns>user object</returns>
        public async Task<User> AddUserManager(User user, string managerName)
        {
            user.Manager = new Manager() { Name = managerName, Email = null, Status = Domain.Enums.StatusType.Active };

            return user;
        }
    }
}
