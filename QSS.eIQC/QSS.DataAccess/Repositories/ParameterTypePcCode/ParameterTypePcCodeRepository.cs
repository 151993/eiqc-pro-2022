using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class ParameterTypePcCodeRepository : BaseRepository<ParameterTypePcCode, int>, IParameterTypePcCodeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public ParameterTypePcCodeRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
        }

        

        /// <summary>
        /// Adds range of PcCodes associated with Site in database.
        /// </summary>
        /// <param name="inspectionToolsType">inspectionToolsType object</param>
        /// <param name="pcCodeIds">List of pcCode Ids to be added</param>
        public void AddParameterTypePcCode(ParameterTypeCode parameterTypeCode, List<int> pcCodeIds)
        {
            if (pcCodeIds != null && pcCodeIds.IsAny())
            {
                AddRange(pcCodeIds.Select(r =>
                   new ParameterTypePcCode()
                   {
                       ParameterTypeCode = parameterTypeCode,
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
        public void RemoveParameterTypePcCode(int parameterTypeCodeId, List<int> pcCodeIds)   // Check :TODO : Prashanth
        {
            if (pcCodeIds != null && pcCodeIds.IsAny())
            {
                var parameterTypeCodes = Context.Set<ParameterTypePcCode>()
                                .Where(s => s.ParameterTypeCodeId == parameterTypeCodeId)
                                .Where(d => pcCodeIds.Contains(d.PCCodeId))
                                .ToList();


                if (!parameterTypeCodes.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.ParameterTypeCodeIdCodeDoesNotExists(parameterTypeCodeId));
                }

                RemoveRange(parameterTypeCodes);
            }
        }
    }
}

