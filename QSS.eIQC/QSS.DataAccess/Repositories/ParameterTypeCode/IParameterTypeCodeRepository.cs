
﻿using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IParameterTypeCodeRepository
    {
        Task<ParameterTypeCode> AddAsync(ParameterTypeCode parameterTypeCode, string changeReason);

        Task UpdateAsync(ParameterTypeCode parameterTypeCode, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

    }
}
