using MediatR;

namespace QSS.eIQC.Handlers.Commands.CountryCommand.Add
{
    public class AddCountryModel : BaseCommand, IRequest<CountryModel>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int RegionId { get; set; }

    }
}
