using MediatR;


namespace QSS.eIQC.Handlers.Commands.DivisionCommand.Add
{
    public class AddDivisionModel : BaseCommand, IRequest<DivisionModel>
    {
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
