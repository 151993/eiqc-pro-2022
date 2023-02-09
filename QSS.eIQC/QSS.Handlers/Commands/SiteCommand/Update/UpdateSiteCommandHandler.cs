/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.SiteCommand.Update;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.EIQC.Handlers.Commands.SiteCommand.Update
{
    /// <summary>
    /// Command Handler for Update Site operation
    /// </summary>
    public class UpdateSiteCommandHandler : IRequestHandler<UpdateSiteModel, SiteModel>
    {
        private readonly QSSContext _context;
        private readonly ISiteRepository _repository;
        private readonly IMapper _mapper;
        private readonly ISiteDivisionRepository _siteDivisionRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSiteCommandHandler(QSSContext context, ISiteRepository siteRepository, IMapper mapper, ISiteDivisionRepository siteDivisionRepository)
        {
            _context = context;
            _repository = siteRepository;
            _mapper = mapper;
            _siteDivisionRepository = siteDivisionRepository;
        }

        /// <summary>
        /// Validates the input model and Update Site entity
        /// </summary>
        /// <param name="request">Input Update Site model, <see cref="UpdateSiteModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Site model</returns>
        public async Task<SiteModel> Handle(UpdateSiteModel request, CancellationToken cancellationToken)
        {
            var site = _mapper.Map<Site>(request);

            _siteDivisionRepository.AddSiteDivisions(site, request.AddedDivisionIds);

            _siteDivisionRepository.RemoveSiteDivisions(site.Id, request.RemovedDivisionIds);

            await _repository.UpdateAsync(site, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SiteModel>(site);
        }
    }
}
