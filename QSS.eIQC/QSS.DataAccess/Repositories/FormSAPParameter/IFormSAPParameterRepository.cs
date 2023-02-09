/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormSAPParameterRepository
    {
        Task<FormSAPParameter> AddAsync(FormSAPParameter FormSAPParameter, string changeReason);

        Task UpdateAsync(FormSAPParameter FormSAPParameter, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
