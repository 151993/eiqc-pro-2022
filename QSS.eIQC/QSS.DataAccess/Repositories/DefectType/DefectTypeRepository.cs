using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for UserRole, provides Add, Update and Delete operations
    /// </summary>
    public class DefectTypeRepository : Repository<DefectType, int>, IDefectTypeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public DefectTypeRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of parameterNames associated with User in database.
        /// </summary>
        /// <param name="certificateType">User object</param>
        /// <param name="addedparameterNames">List of parameterNames to be added</param>
        public void AddDefectTypes(DefectManagement defectManagement, List<string> defectTypeNames)
        {
            if (defectTypeNames != null && defectTypeNames.IsAny())
            {
                AddRange(defectTypeNames.Select(r =>
                   new DefectType()
                   {
                       DefectManagement = defectManagement,
                       DefectTypeName = r
                   }
                ));
            }
        }

        /// <summary>
        /// Checks if the certificateTypeParameter with id presents in database, if found then deletes from database.
        /// </summary>
        /// <param name="certificateTypeParameterId">User Id</param>
        /// <param name="parameterNames">List of parameterNames to be deleted</param>
        /// <returns>Returns instance of removed UserRole, <see cref="UserRole"/></returns>
        public void RemoveDefectTypes(int defectManagementId, List<string> defectTypeNames)
        {
            if (defectTypeNames != null && defectTypeNames.IsAny())
            {
                var certificateTypeParameters = Context.Set<DefectType>()
                                .Where(s => s.DefectManagementId == defectManagementId)
                                .Where(d => defectTypeNames.Contains(d.DefectTypeName))
                                .ToList();


                if (!certificateTypeParameters.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.DefectTypeDoesNotExists(defectManagementId));
                }

                RemoveRange(certificateTypeParameters);
            }
        }
    }
}
