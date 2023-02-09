using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class InspectionToolsTypePcCodeRepository : Repository<InspectionToolsTypePcCode, int>, IInspectionToolsTypePcCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public InspectionToolsTypePcCodeRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of PcCodes associated with Site in database.
        /// </summary>
        /// <param name="inspectionToolsType">inspectionToolsType object</param>
        /// <param name="pcCodeIds">List of pcCode Ids to be added</param>
        public void AddInspectionToolsTypePcCode(InspectionToolsType inspectionToolsType, List<int> pcCodeIds)
        {
            if (pcCodeIds != null && pcCodeIds.IsAny())
            {
                AddRange(pcCodeIds.Select(r =>
                   new InspectionToolsTypePcCode()
                   {
                       InspectionToolsType = inspectionToolsType,
                       PCCodeId = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the InspectionToolsTypePcCode with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="id">InspectionToolsType Id</param>
        /// <param name="pcCodeIds">List of PcCode Ids to be deleted</param>
        public void RemoveInspectionToolsTypePcCode(int inspectionToolsTypeId, List<int> pcCodeIds)
        {
            if (pcCodeIds != null && pcCodeIds.IsAny())
            {
                var inspectionToolsTypePcCodes = Context.Set<InspectionToolsTypePcCode>()
                                .Where(s => s.InspectionToolsTypeId == inspectionToolsTypeId)
                                .Where(d => pcCodeIds.Contains(d.PCCodeId))
                                .ToList();


                if (!inspectionToolsTypePcCodes.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.InspectionToolsTypePcCodeDoesNotExists(inspectionToolsTypeId));
                }

                RemoveRange(inspectionToolsTypePcCodes);
            }
        }
    }
}
