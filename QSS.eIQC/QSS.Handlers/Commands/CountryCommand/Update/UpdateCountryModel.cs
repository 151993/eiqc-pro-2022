using MediatR;

namespace QSS.eIQC.Handlers.Commands.CountryCommand.Update
{
    public class UpdateCountryModel : BaseUpdateCommand<int>, IRequest<CountryModel>
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
        /// RegionId
        /// </summary>
        public int RegionId { get; set; }



    }
}
