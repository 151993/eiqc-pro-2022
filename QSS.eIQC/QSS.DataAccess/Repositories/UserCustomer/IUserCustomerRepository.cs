/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface IUserCustomerRepository
    {
        Task<UserCustomer> AddAsync(UserCustomer userCustomer, string changeReason);

        Task UpdateAsync(UserCustomer userCustomer, string changeReason);

        Task RemoveByIdAsync(int id, string changeReason);

        void AddUserCustomers(Customer customer, List<int> userIds);
        void RemoveUserCustomers(int customerId, List<int> userIds);
    }
}
