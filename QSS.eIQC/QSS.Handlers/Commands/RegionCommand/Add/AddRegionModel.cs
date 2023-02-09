using MediatR;

namespace QSS.eIQC.Handlers.Commands.RegionCommand.Add
{
    public class AddRegionModel : BaseCommand, IRequest<RegionModel>
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
    }
}
