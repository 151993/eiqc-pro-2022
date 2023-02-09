/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, int>, ICustomerRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CustomerRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new Customer into database
        /// </summary>
        /// <param name="Customer">New entity of Customer, <see cref="Customer"/></param>
        /// <returns>Saved entity of Role, <see cref="Customer"/></returns>
        public async Task<Customer> AddAsync(Customer customer, string changeReason)
        {
            return await AddAsync(customer, Constants.AuditLog.Title.AddCustomer(customer.Name), changeReason);
        }

        /// <summary>
        /// Updates existing Customer with new values
        /// </summary>
        /// <param name="Customer">Updated entity of Customer, <see cref="Customer"/></param>
        /// <returns>Saved entity of Customer, <see cref="Customer"/></returns>
        public async Task UpdateAsync(Customer customer, string changeReason)
        {
            await UpdateAsync(customer, Constants.AuditLog.Title.EditCustomer(customer.Name), changeReason);
        }

        /// <summary>
        /// Checks if the Customer with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Customer Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Customer, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

            SetAuditLog(role, Constants.AuditLog.Title.DeleteCustomer(role.Name), changeReason);

            Remove(role);
        }
    }
}

