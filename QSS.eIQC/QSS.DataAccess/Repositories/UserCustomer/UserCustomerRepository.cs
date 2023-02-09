/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class UserCustomerRepository : BaseRepository<UserCustomer, int>, IUserCustomerRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public UserCustomerRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Create new UserCustomer into database
        /// </summary>
        /// <param name="UserCustomer">New entity of UserCustomer, <see cref="UserCustomer"/></param>
        /// <returns>Saved entity of Role, <see cref="UserCustomer"/></returns>
        public async Task<UserCustomer> AddAsync(UserCustomer userCustomer, string changeReason)
        {
            // return await AddAsync(userCustomer, Constants.AuditLog.Title.AddUserCustomer(userCustomer.Name), changeReason);
            return null;
        }

        /// <summary>
        /// Updates existing UserCustomer with new values
        /// </summary>
        /// <param name="UserCustomer">Updated entity of UserCustomer, <see cref="UserCustomer"/></param>
        /// <returns>Saved entity of UserCustomer, <see cref="UserCustomer"/></returns>
        public async Task UpdateAsync(UserCustomer userCustomer, string changeReason)
        {
            // await UpdateAsync(userCustomer, Constants.AuditLog.Title.EditUserCustomer(userCustomer.Name), changeReason);
            

        }

        /// <summary>
        /// Checks if the UserCustomer with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">UserCustomer Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed UserCustomer, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var role = await ValidateExistsAndGetAsync(id);

           // SetAuditLog(role, Constants.AuditLog.Title.DeleteUserCustomer(role.Name), changeReason);

            Remove(role);
        }

        /// <summary>
        /// Adds range of Divisions associated with Site in database.
        /// </summary>
        /// <param name="Site">Site object</param>
        /// <param name="addeddivisionIds">List of Division Ids to be added</param>
        public void AddUserCustomers(Customer customer, List<int> userIds)
        {
            if (userIds != null && userIds.IsAny())
            {
                AddRange(userIds.Select(r =>
                   new UserCustomer()
                   {
                       Customer = customer,
                       UserId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the SiteDivision with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">Site Id</param>
        /// <param name="divisionIds">List of Division Ids to be deleted</param>
        public void RemoveUserCustomers(int customerId, List<int> userIds)
        {
            if (userIds != null && userIds.IsAny())
            {
                var userCustomers = Context.Set<UserCustomer>()
                                .Where(s => s.CustomerId == customerId)
                                .Where(d => userIds.Contains(d.UserId))
                                .ToList();


                if (!userCustomers.IsAny())
                {
                    //throw new Exception(Constants.ErrorMessage.SiteDivisionDoesNotExists(siteId));
                }

                RemoveRange(userCustomers);
            }
        }
    }
}

