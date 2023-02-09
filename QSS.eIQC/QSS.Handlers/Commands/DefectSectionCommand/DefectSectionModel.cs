

namespace QSS.eIQC.Handlers.Commands.DefectSectionCommand
{
    public class DefectSectionModel : BaseStausModel<int>
    {
        public int DefectSectionId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Get or set Description property
        /// </summary>
        public string Description { get; set; }
    }
}
