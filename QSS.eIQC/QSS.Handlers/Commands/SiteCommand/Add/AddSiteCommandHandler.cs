/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SiteCommand.Add
{
    /// <summary>
    /// Command Handler for Add Site operation
    /// </summary>
    public class AddSiteCommandHandler : IRequestHandler<AddSiteModel, SiteModel>
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
        public AddSiteCommandHandler(QSSContext context, ISiteRepository repository, IMapper mapper, ISiteDivisionRepository siteDivisionRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _siteDivisionRepository = siteDivisionRepository;
        }

        /// <summary>
        /// Validates the input model and Add new Site entity
        /// </summary>
        /// <param name="request">Add Site model, <see cref="AddSiteModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Site model</returns>
        public async Task<SiteModel> Handle(AddSiteModel request, CancellationToken cancellationToken)
        {
            var site = _mapper.Map<Site>(request);

            _siteDivisionRepository.AddSiteDivisions(site, request.AddedDivisionIds);          

            await _repository.AddAsync(site, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SiteModel>(site);
        }
    }
}
