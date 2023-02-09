using QSS.eIQC.Domain.Models;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for UserRole 
    /// </summary>
    public interface ICertificateTypeParameterRepository
    {
        void AddCertificateTypeParameters(CertificateType certificateType, List<string> parameterNames);
        void RemoveCertificateTypeParameters(int certificateTypeParameterId, List<string> parameterNames);
    }
}
