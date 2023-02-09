/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class PartRepository : BaseRepository<Part, int>, IPartRepository
    {
        private readonly QSSContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PartRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Create new Part into database
        /// </summary>
        /// <param name="Part">New entity of Part, <see cref="Part"/></param>
        /// <returns>Saved entity of Role, <see cref="Part"/></returns>
        public async Task<Part> AddAsync(Part part, string changeReason)
        {
            return await AddAsync(part, Constants.AuditLog.Title.AddPart(part.PartNo), changeReason);
        }

        /// <summary>
        /// Updates existing Part with new values
        /// </summary>
        /// <param name="Part">Updated entity of Part, <see cref="Part"/></param>
        /// <returns>Saved entity of Part, <see cref="Part"/></returns>
        public async Task UpdateAsync(Part part, string changeReason)
        {
            await UpdateAsync(part, Constants.AuditLog.Title.EditPart(part.PartNo), changeReason);
        }

        /// <summary>
        /// Checks if the Part with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">Part Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Part, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var part = await ValidateExistsAndGetAsync(id);

            SetAuditLog(part, Constants.AuditLog.Title.DeletePart(part.PartNo), changeReason);

            Remove(part);
        }

        public async Task<string> GetCAFNoPrefix(int siteId, int workCellId)
        {
            var cafPrefix=  (from wc in _context.WorkCellUser
                                join dcc in _context.DCCConfiguration
                                          on wc.SiteId equals dcc.SiteId
                                          where wc.SiteId == siteId && wc.WorkCellId == workCellId && wc.IsDccApproval == true
                                          select dcc.SiteNo + "-" + dcc.DeptCode + "" + dcc.DocLevel).FirstOrDefault();

            return string.IsNullOrEmpty(cafPrefix)? "": cafPrefix;


        }
    }
}

