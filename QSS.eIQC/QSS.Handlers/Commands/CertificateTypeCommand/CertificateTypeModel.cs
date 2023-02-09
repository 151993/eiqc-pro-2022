/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.CertificateTypeParameterCommand;
using System.Collections.Generic;


namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand
{
    /// <summary>
    /// Representation model for CertificateType entity
    /// </summary>
    public class CertificateTypeModel : BaseStausModel<int>
    {


        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public string Name { get; set; }

        /// <summary>
        /// Get or set CertificateTypeParameters property
        /// </summary>
        public virtual IEnumerable<CertificateTypeParameterModel> CertificateTypeParameters { get; set; }
        
    }
}
