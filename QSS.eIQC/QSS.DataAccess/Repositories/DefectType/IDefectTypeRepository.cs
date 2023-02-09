using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for UserRole 
    /// </summary>
    public interface IDefectTypeRepository
    {
        void AddDefectTypes(DefectManagement defectManagement, List<string> defectTypeNames);
        void RemoveDefectTypes(int defectManagementId, List<string> defectTypeNames);
    }
}
