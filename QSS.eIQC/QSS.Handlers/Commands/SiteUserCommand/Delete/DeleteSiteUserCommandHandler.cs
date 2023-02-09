/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SiteUserCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete SiteSme operation
    /// </summary>
    public class DeleteSiteUserCommandHandler : IRequestHandler<DeleteSiteUserModel, DeleteSiteUserResponse>
    {
        private readonly QSSContext _context;
        private readonly ISiteUserRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSiteUserCommandHandler(QSSContext context, ISiteUserRepository siteUserRepository)
        {
            _context = context;
            _repository = siteUserRepository;
        }

        /// <summary>
        /// Handle the request to Delete SiteSme 
        /// </summary>
        /// <param name="request">Input Delete SiteSme model, <see cref="DeleteSiteUserModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSiteUserResponse"/></returns>
        public async Task<DeleteSiteUserResponse> Handle(DeleteSiteUserModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.Site.Name, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSiteUserResponse()
            {
                Result = true
            };
        }
    }
}
