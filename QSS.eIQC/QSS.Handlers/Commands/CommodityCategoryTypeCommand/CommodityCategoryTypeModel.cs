
namespace QSS.eIQC.Handlers.Commands.CommodityCategoryTypeCommand
{
    public class CommodityCategoryTypeModel : BaseStausModel<int>
    {
        public int CommodityCategoryTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
