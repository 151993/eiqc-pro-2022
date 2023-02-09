using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class CommodityPartNumberSiteRepository : BaseRepository<CommodityPartNumberSite, int>, ICommodityPartNumberSiteRepository
    {
        private readonly QSSContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CommodityPartNumberSiteRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Created new Commodity into database
        /// </summary>
        /// <param name="Commodity">New entity of Commodity, <see cref="Commodity"/></param>
        /// <returns>Saved entity of Commodity, <see cref="Commodity"/></returns>
        public async Task<CommodityPartNumberSite> AddAsync(CommodityPartNumberSite commodity, string changeReason)
        {
            return await AddAsync(commodity, Constants.AuditLog.Title.AddCommodity(commodity.PartNumber), changeReason);
        }

        /// <summary>
        /// Updates existing Commodity with new values
        /// </summary>
        /// <param name="Commodity">Updated entity of Commodity, <see cref="Commodity"/></param>
        /// <returns>Saved entity of Commodity, <see cref="Commodity"/></returns>
        public async Task UpdateAsync(CommodityPartNumberSite commodity, string changeReason)
        {
            await UpdateAsync(commodity, Constants.AuditLog.Title.EditCommodity(commodity.PartNumber), changeReason);
        }

        /// <summary>
        /// Checks if the Commodity with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed Commodity, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var commodity = await ValidateExistsAndGetAsync(id);

            SetAuditLog(commodity, Constants.AuditLog.Title.DeleteCommodity(commodity.PartNumber), changeReason);

            Remove(commodity);
        }

    }
}
