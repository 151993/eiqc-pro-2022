using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for Department, provides Add, Update and Delete operations
 /// </summary>
    public class DepartmentRepository : BaseRepository<Department, int>, IDepartmentRepository
    {
        private readonly QSSContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public DepartmentRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Created new Department into database
        /// </summary>
        /// <param name="Department">New entity of Department, <see cref="Department"/></param>
        /// <returns>Saved entity of Department, <see cref="Department"/></returns>
        public async Task<Department> AddAsync(Department department, string changeReason)
        {
            return await AddAsync(department, Constants.AuditLog.Title.AddDepartment(department.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Department with new values
        /// </summary>
        /// <param name="Department">Updated entity of Department, <see cref="Department"/></param>
        /// <returns>Saved entity of Department, <see cref="Department"/></returns>
        public async Task<Department> UpdateAsync(Department department, string changeReason)
        {
            return await UpdateAsync(department, Constants.AuditLog.Title.EditDepartment(department.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Department with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Department, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var department = await ValidateExistsAndGetAsync(id);

            SetAuditLog(department, Constants.AuditLog.Title.DeleteDepartment(department.Name), changeReason);

            return Remove(department);
        }
        /// <summary>
        /// Checks if department name already exists in Database 
        /// </summary>
        /// <param name="name">manager Name</param>
        /// <returns>true or false</returns>
        public async Task<Department> GetDepartmentDetailByName(string name)
        {
            return await _context.Department.FirstOrDefaultAsync(d => d.Name.ToLower() == name.ToLower());
        }

        /// <summary>
        /// Add new Department into User 
        /// </summary>
        /// <param name="name">user ,  departmentName</param>
        /// <returns>user object</returns>
        public async Task<User> AddUserDepartment(User user, string departmentName)
        {
            user.Department = new Department() { Name = departmentName, Description = null, Status = Domain.Enums.StatusType.Active };

            return user;
        }
    }
}
