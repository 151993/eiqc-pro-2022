using MediatR;

namespace QSS.eIQC.Handlers.Commands.ManagerCommand.Add
{
    public class AddManagerModel : BaseCommand, IRequest<ManagerModel>
    {
        public string Name { get; set; }

        public string Email { get; set; }

    }
}
