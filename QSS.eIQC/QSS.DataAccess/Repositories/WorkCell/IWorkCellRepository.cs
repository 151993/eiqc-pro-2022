using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for WorkCell 
    /// </summary>
    public interface IWorkCellRepository
    {
        Task<WorkCell> AddAsync(WorkCell workCell, string changeReason);

        Task<WorkCell> UpdateAsync(WorkCell workCell, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string changeReason);
    }
}
