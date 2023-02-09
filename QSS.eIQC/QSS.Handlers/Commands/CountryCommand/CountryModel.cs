

using QSS.eIQC.Handlers.Commands.RegionCommand;

namespace QSS.eIQC.Handlers.Commands.CountryCommand
{
    public class CountryModel : BaseStausModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string RegionName { get; set; }

        public int RegionId { get; set; }

        public virtual RegionModel Region { get; set; }

    }
}
