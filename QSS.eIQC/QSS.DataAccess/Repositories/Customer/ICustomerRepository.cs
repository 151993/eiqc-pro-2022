/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Customer customer, string changeReason);

        Task UpdateAsync(Customer customer, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);
    }
}
