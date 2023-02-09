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
    public class CertificateTypeParameterRepository : Repository<CertificateTypeParameter, int>, ICertificateTypeParameterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public CertificateTypeParameterRepository(QSSContext context) : base(context)
        {
        }

        /// <summary>
        /// Adds range of parameterNames associated with User in database.
        /// </summary>
        /// <param name="certificateType">User object</param>
        /// <param name="addedparameterNames">List of parameterNames to be added</param>
        public void AddCertificateTypeParameters(CertificateType certificateType, List<string> parameterNames)
        {
            if (parameterNames != null && parameterNames.IsAny())
            {
                AddRange(parameterNames.Select(r =>
                   new CertificateTypeParameter()
                   {
                       CertificateType = certificateType,
                       ParameterName = r
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
        public void RemoveCertificateTypeParameters(int certificateTypeParameterId, List<string> parameterNames)
        {
            if (parameterNames != null && parameterNames.IsAny())
            {
                var certificateTypeParameters = Context.Set<CertificateTypeParameter>()
                                .Where(s => s.CertificateTypeId == certificateTypeParameterId)
                                .Where(d => parameterNames.Contains(d.ParameterName))
                                .ToList();


                if (!certificateTypeParameters.IsAny())
                {
                    throw new Exception(Constants.ErrorMessage.CertificateTypeParameterDoesNotExists(certificateTypeParameterId));
                }

                RemoveRange(certificateTypeParameters);
            }
        }
    }
}
