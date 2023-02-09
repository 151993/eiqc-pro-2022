using MediatR;

namespace QSS.eIQC.Handlers.Commands.LocationCommand.Update
{
    public class UpdateLocationModel : BaseUpdateCommand<int>, IRequest<LocationModel>
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// CountryId
        /// </summary>
        public int CountryId { get; set; }


    }
}
