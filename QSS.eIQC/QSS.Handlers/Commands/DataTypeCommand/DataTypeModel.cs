

namespace QSS.eIQC.Handlers.Commands.DataTypeCommand
{
    public class DataTypeModel : BaseStausModel<int>
    {
        public int DataTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
