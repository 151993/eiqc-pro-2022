using System.Threading.Tasks;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Department 
    /// </summary>
    public interface IDepartmentRepository
    {
        Task<Department> AddAsync(Department department, string changeReason);

        Task<Department> UpdateAsync(Department department, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);

        Task<Department> GetDepartmentDetailByName(string name);

        Task<User> AddUserDepartment(User user, string departmentName);
    }
}
