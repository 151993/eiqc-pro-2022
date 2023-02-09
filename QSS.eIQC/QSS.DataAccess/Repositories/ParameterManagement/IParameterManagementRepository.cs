using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IParameterManagementRepository
    {
        Task<ParameterManagement> AddAsync(ParameterManagement parameterManagement, string changeReason);

        Task UpdateAsync(ParameterManagement parameterManagement, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
