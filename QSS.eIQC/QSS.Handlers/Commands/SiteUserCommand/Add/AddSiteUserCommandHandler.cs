/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand.Add
{
    /// <summary>
    /// Command Handler for Add SiteSme operation
    /// </summary>
    public class AddSiteUserCommandHandler : IRequestHandler<AddSiteUserModel, SiteUserModel>
    {
        private readonly QSSContext _context;
        private readonly ISiteUserRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSiteUserCommandHandler(QSSContext context, ISiteUserRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new SiteSme entity
        /// </summary>
        /// <param name="request">Add SiteSme model, <see cref="AddSiteUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SiteSme model</returns>
        public async Task<SiteUserModel> Handle(AddSiteUserModel request, CancellationToken cancellationToken)
        {
            var siteUser = _mapper.Map<SiteUser>(request);

            _repository.AddSiteUsers(siteUser.Site, request.AddedSiteUserIds, request.ChangeReason);

            _repository.RemoveSiteUsers(siteUser.Site, request.RemovedSiteUserIds, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SiteUserModel>(siteUser);
        }
    }
}
