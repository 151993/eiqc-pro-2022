/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IInstrumentTypeRepository
    {
        Task<InstrumentType> AddAsync(InstrumentType instrumentType, string changeReason);

        Task UpdateAsync(InstrumentType instrumentType, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
