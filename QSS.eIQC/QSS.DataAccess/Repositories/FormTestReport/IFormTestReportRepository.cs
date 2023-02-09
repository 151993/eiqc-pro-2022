/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IFormTestReportRepository
    {
        Task<FormTestReport> AddAsync(FormTestReport formTestReport, string changeReason);

        Task UpdateAsync(FormTestReport formTestReport, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
