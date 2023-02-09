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
    public class WorkCellRepository : BaseRepository<WorkCell,int> ,IWorkCellRepository
    {
        public WorkCellRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }
        /// <summary>
        /// Created new WorkCell into database
        /// </summary>
        /// <param name="WorkCell">New entity of WorkCell, <see cref="WorkCell"/></param>
        /// <returns>Saved entity of WorkCell, <see cref="WorkCell"/></returns>
        public async Task<WorkCell> AddAsync(WorkCell workCell, string changeReason)
        {
            return await AddAsync(workCell, Constants.AuditLog.Title.AddWorkCell(workCell.Name), changeReason);
        }

        /// <summary>
        /// Updates existing WorkCell with new values
        /// </summary>
        /// <param name="WorkCell">Updated entity of WorkCell, <see cref="WorkCell"/></param>
        /// <returns>Saved entity of WorkCell, <see cref="WorkCell"/></returns>
        public async Task<WorkCell> UpdateAsync(WorkCell workCell, string changeReason)
        {
            return await UpdateAsync(workCell, Constants.AuditLog.Title.EditWorkCell(workCell.Name), changeReason);
        }

        /// <summary>
        /// Checks if the WorkCell with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">{Entity} Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed WorkCell, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var workCell = await ValidateExistsAndGetAsync(id);

            SetAuditLog(workCell, Constants.AuditLog.Title.DeleteWorkCell(workCell.Name), changeReason);

            return Remove(workCell);
        }
    }
}
