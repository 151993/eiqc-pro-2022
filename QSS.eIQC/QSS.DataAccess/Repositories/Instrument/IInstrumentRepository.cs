/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IInstrumentRepository
    {
        Task<Instrument> AddAsync(Instrument instrument, string changeReason);

        Task UpdateAsync(Instrument instrument, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
