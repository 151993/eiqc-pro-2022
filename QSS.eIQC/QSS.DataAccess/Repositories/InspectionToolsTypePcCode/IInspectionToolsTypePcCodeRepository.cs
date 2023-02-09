using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for InspectionToolsType PcCode
    /// </summary>
    public interface IInspectionToolsTypePcCodeRepository
    {
        void AddInspectionToolsTypePcCode(InspectionToolsType inspectionToolsType, List<int> pcCodeIds);
        void RemoveInspectionToolsTypePcCode(int inspectionToolsTypeId, List<int> pcCodeIds);
    }
}
