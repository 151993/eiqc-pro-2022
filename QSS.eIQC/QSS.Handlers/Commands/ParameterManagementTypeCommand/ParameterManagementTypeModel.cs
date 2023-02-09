

namespace QSS.eIQC.Handlers.Commands.ParameterManagementTypeCommand
{
    public class ParameterManagementTypeModel : BaseStausModel<int>
    {
        public int ParameterManagementTypeId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>
        public string Description { get; set; }
    }
}
