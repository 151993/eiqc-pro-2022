using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.DefectTypeCommand
{
    /// <summary>
    /// Representation model for DefectType entity
    /// </summary>
    public class DefectTypeModel : BaseStausModel<int>
    {
        /// <summary>
        /// DefectTypeName
        /// </summary>
        public string DefectTypeName { get; set; }

        

    }
}
