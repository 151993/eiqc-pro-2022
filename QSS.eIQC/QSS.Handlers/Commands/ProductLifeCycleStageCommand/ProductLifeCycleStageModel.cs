

namespace QSS.eIQC.Handlers.Commands.ProductLifeCycleStageCommand
{
    public class ProductLifeCycleStageModel : BaseStausModel<int>
    {
        public int ProductLifeCycleStageId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
