using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;
using QSS.eIQC.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;

namespace QSS.eIQC.DataAccess.Repositories
{/// <summary>
 /// Repository for SyncTM1LastDate, provides Add, Update and Delete operations
 /// </summary>
    public class TM1DataSyncDetailsRepository : BaseRepository<TM1DataSyncDetails, int>, ITM1DataSyncDetailsRepository
    {
        /// <summary>
        /// Store QSSContext, <see cref="QSSContext"/>
        /// </summary>
        private readonly QSSContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public TM1DataSyncDetailsRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Created new SyncTM1LastDate into database
        /// </summary>
        /// <param name="entity">New entity of SyncTM1DataVariable, <see cref="TM1DataSyncDetails"/></param>
        /// <returns>Saved entity of SyncTM1DataVariable, <see cref="TM1DataSyncDetails"/></returns>
        public async Task<TM1DataSyncDetails> AddAsync(TM1DataSyncDetails entity, string changeReason)
        {
            var isExist = await IsTM1LastSyncDateExistsAsync(entity.Name);

            if (isExist)
            {
                throw new Exception($"Name has been taken. Please specify a different Name!");
            }

            var result = await base.AddAsync(entity);
            return result;
        }

        /// <summary>
        /// Checks if SyncTM1LastDate name already exists in Database 
        /// </summary>
        /// <param name="name">TM1LastSyncDateExistsAsync Name</param>
        /// <returns>true or false</returns>
        public async Task<bool> IsTM1LastSyncDateExistsAsync(string name)
        {
            return await _context.TM1DataSyncDetails.AnyAsync(d => d.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
