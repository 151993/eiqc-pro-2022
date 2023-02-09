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
    public class PurchaseOrderRepository : BaseRepository<PurchaseOrder, int>, IPurchaseOrderRepository
    {
        private readonly QSSContext _context;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public PurchaseOrderRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Created new PurchaseOrder into database
        /// </summary>
        /// <param name="PurchaseOrder">New entity of PurchaseOrder, <see cref="PurchaseOrder"/></param>
        /// <returns>Saved entity of PurchaseOrder, <see cref="PurchaseOrder"/></returns>
        public async Task<PurchaseOrder> AddAsync(PurchaseOrder purchaseOrder, string changeReason)
        {
            return await AddAsync(purchaseOrder, Constants.AuditLog.Title.AddPurchaseOrder(purchaseOrder.PurchaseOrderNo), changeReason);
        }

        /// <summary>
        /// Updates existing PurchaseOrder with new values
        /// </summary>
        /// <param name="PurchaseOrder">Updated entity of PurchaseOrder, <see cref="PurchaseOrder"/></param>
        /// <returns>Saved entity of PurchaseOrder, <see cref="PurchaseOrder"/></returns>
        public async Task UpdateAsync(PurchaseOrder purchaseOrder, string changeReason)
        {
            await UpdateAsync(purchaseOrder, Constants.AuditLog.Title.EditPurchaseOrder(purchaseOrder.PurchaseOrderNo), changeReason);
        }

        /// <summary>
        /// Checks if the PurchaseOrder with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed PurchaseOrder, <see cref="{Entity}"/></returns>
        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var purchaseOrder = await ValidateExistsAndGetAsync(id);

            SetAuditLog(purchaseOrder, Constants.AuditLog.Title.DeletePurchaseOrder(purchaseOrder.PurchaseOrderNo), changeReason);

            Remove(purchaseOrder);
        }

    }
}
