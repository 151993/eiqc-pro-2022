using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static QSS.eIQC.DataAccess.Common.Constants;

namespace QSS.eIQC.DataAccess.Repositories.SAPDataSync
{
    public class SAPDataSyncDetailsRepository : BaseRepository<SAPDataSyncDetails, int>, ISAPDataSyncDetailsRepository
    {
        /// <summary>
        /// Store QSSContext, <see cref="QSSContext"/>
        /// </summary>
        private readonly QSSContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SAPDataSyncDetailsRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Created new SyncSAPLastDate into database
        /// </summary>
        /// <param name="entity">New entity of SyncSAPDataVariable, <see cref="SAPDataSyncDetails"/></param>
        /// <returns>Saved entity of SyncSAPDataVariable, <see cref="SAPDataSyncDetails"/></returns>
        public async Task<SAPDataSyncDetails> AddAsync(SAPDataSyncDetails entity, string changeReason)
        {
            var isExist = await IsSAPLastSyncDateExistsAsync(entity.Name);

            if (isExist)
            {
                throw new Exception(ErrorMessage.NameAlreadyExists);
            }

            var result = await base.AddAsync(entity);
            return result;
        }

        /// <summary>
        /// Checks if SyncSAPLastDate name already exists in Database 
        /// </summary>
        /// <param name="name">SAPLastSyncDateExistsAsync Name</param>
        /// <returns>true or false</returns>
        public async Task<bool> IsSAPLastSyncDateExistsAsync(string name)
        {
            return await _context.SAPDataSyncDetails.AnyAsync(d => d.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
