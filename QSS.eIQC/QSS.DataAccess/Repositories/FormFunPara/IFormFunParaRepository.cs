/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormFunParaRepository
    {
        Task<FormFunPara> AddAsync(FormFunPara formFunPara, string changeReason);

        Task UpdateAsync(FormFunPara formFunPara, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
