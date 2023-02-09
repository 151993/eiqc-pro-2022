/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete DefectManagement operation
    /// </summary>
    public class DeleteDefectManagementCommandHandler : IRequestHandler<DeleteDefectManagementModel, DeleteDefectManagementResponse>
    {
        private readonly QSSContext _context;
        private readonly IDefectManagementRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteDefectManagementCommandHandler(QSSContext context, IDefectManagementRepository certificateTypeRepository)
        {
            _context = context;
            _repository = certificateTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete DefectManagement 
        /// </summary>
        /// <param name="request">Input Delete DefectManagement model, <see cref="DeleteDefectManagementModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteDefectManagementResponse"/></returns>
        public async Task<DeleteDefectManagementResponse> Handle(DeleteDefectManagementModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteDefectManagementResponse()
            {
                Result = true
            };
        }
    }
}
