/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.SiteCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Site operation
    /// </summary>
    public class DeleteSiteCommandHandler : IRequestHandler<DeleteSiteModel, DeleteSiteResponse>
    {
        private readonly QSSContext _context;
        private readonly ISiteRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteSiteCommandHandler(QSSContext context, ISiteRepository siteRepository)
        {
            _context = context;
            _repository = siteRepository;
        }

        /// <summary>
        /// Handle the request to Delete Site 
        /// </summary>
        /// <param name="request">Input Delete Site model, <see cref="DeleteSiteModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteSiteResponse"/></returns>
        public async Task<DeleteSiteResponse> Handle(DeleteSiteModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteSiteResponse()
            {
                Result = true
            };
        }
    }
}
