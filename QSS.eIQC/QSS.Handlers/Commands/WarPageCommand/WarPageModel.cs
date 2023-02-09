

namespace QSS.eIQC.Handlers.Commands.WarPageCommand
{
    public class WarPageModel : BaseStausModel<int>
    {
        public int WarPageId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
