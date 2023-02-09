

namespace QSS.eIQC.Handlers.Commands.ChartTypeCommand
{
    public class ChartTypeModel : BaseStausModel<int>
    {
        public int ChartTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
