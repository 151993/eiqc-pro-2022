using MediatR;


namespace QSS.eIQC.Handlers.Commands.RegionCommand.Update
{

    public class UpdateRegionModel : BaseUpdateCommand<int>, IRequest<RegionModel>
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
