
using QSS.eIQC.Handlers.Commands.CountryCommand;

namespace QSS.eIQC.Handlers.Commands.LocationCommand
{
    public class LocationModel : BaseStausModel<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public virtual CountryModel Country { get; set; }


    }
}
