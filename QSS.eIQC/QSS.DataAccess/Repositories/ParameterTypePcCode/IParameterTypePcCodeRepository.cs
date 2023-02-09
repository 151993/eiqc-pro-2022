using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IParameterTypePcCodeRepository
    {
        void AddParameterTypePcCode(ParameterTypeCode parameterTypeCode, List<int> parameterTypeCodeIds);

        void RemoveParameterTypePcCode(int parameterTypeCodeId, List<int> parameterTypeCodeIds);
    }
}
