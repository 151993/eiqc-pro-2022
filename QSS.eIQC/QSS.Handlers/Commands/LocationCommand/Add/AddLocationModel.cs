using MediatR;

namespace QSS.eIQC.Handlers.Commands.LocationCommand.Add
{
    public class AddLocationModel : BaseCommand, IRequest<LocationModel>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int CountryId { get; set; }

    }
}
