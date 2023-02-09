/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.DefectSectionCommand;
using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using System.Collections.Generic;


namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand
{
    /// <summary>
    /// Representation model for DefectManagement entity
    /// </summary>
    public class DefectManagementModel : BaseStausModel<int>
    {


        /// <summary>
        /// Get or set Name property
        /// </summary>        
        public int DefectSectionId { get; set; }

        public virtual DefectSectionModel DefectSection { get; set; }

        /// <summary>
        /// Get or set DefectTypes property
        /// </summary>
        public virtual IEnumerable<DefectTypeModel> DefectTypes { get; set; }
        
    }
}
