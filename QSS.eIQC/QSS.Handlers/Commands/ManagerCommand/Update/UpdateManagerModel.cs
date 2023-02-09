using MediatR;


namespace QSS.eIQC.Handlers.Commands.ManagerCommand.Update
{

    public class UpdateManagerModel : BaseUpdateCommand<int>, IRequest<ManagerModel>
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }


    }
}
