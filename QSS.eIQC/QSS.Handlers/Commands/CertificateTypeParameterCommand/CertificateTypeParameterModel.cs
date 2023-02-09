using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeParameterCommand
{
    /// <summary>
    /// Representation model for CertificateTypeParameter entity
    /// </summary>
    public class CertificateTypeParameterModel : BaseStausModel<int>
    {
        /// <summary>
        /// Parameter Name
        /// </summary>
        public string ParameterName { get; set; }

        

    }
}
