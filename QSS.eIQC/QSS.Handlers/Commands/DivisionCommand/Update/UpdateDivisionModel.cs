using MediatR;

namespace QSS.eIQC.Handlers.Commands.DivisionCommand.Update
{
    public class UpdateDivisionModel : BaseUpdateCommand<int>, IRequest<DivisionModel>
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }


    }
}
