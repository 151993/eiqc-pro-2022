/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand.Update
{
    /// <summary>
    /// Command Handler for Update SiteSme operation
    /// </summary>
    public class UpdateSiteUserCommandHandler : IRequestHandler<UpdateSiteUserModel, SiteUserModel>
    {
        private readonly QSSContext _context;
        private readonly ISiteUserRepository _repository; 
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSiteUserCommandHandler(QSSContext context, ISiteUserRepository siteUserRepository, IMapper mapper)
        {
            _context = context;
            _repository = siteUserRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update SiteUser entity
        /// </summary>
        /// <param name="request">Input Update SiteUser model, <see cref="UpdateSiteUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SiteUser model</returns>
        public async Task<SiteUserModel> Handle(UpdateSiteUserModel request, CancellationToken cancellationToken)
        {
            var siteUser = _mapper.Map<SiteUser>(request);

            siteUser.Site = null;
            siteUser.User = null;

            _repository.Update(siteUser, request.Site.Name, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<SiteUserModel>(siteUser);
        }
    }
}
