/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IGroupRepository
    {
        Task<Group> AddAsync(Group group, string changeReason);

        Task UpdateAsync(Group group, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
