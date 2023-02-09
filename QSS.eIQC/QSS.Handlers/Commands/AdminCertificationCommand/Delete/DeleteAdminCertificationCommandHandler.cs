/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete AdminCertification operation
    /// </summary>
    public class DeleteAdminCertificationCommandHandler : IRequestHandler<DeleteAdminCertificationModel, DeleteAdminCertificationResponse>
    {
        private readonly QSSContext _context;
        private readonly IAdminCertificationRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteAdminCertificationCommandHandler(QSSContext context, IAdminCertificationRepository adminCertificationRepository)
        {
            _context = context;
            _repository = adminCertificationRepository;
        }

        /// <summary>
        /// Handle the request to Delete AdminCertification 
        /// </summary>
        /// <param name="request">Input Delete AdminCertification model, <see cref="DeleteAdminCertificationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteAdminCertificationResponse"/></returns>
        public async Task<DeleteAdminCertificationResponse> Handle(DeleteAdminCertificationModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteAdminCertificationResponse()
            {
                Result = true
            };
        }
    }
}
