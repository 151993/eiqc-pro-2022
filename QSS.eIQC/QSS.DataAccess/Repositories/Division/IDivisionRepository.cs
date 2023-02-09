using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for Division 
    /// </summary>
    public interface IDivisionRepository
    {
        Task<Division> AddAsync(Division division, string changeReason);

        Task<Division> UpdateAsync(Division division, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
