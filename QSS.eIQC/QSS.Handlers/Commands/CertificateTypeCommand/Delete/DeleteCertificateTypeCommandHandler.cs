/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete CertificateType operation
    /// </summary>
    public class DeleteCertificateTypeCommandHandler : IRequestHandler<DeleteCertificateTypeModel, DeleteCertificateTypeResponse>
    {
        private readonly QSSContext _context;
        private readonly ICertificateTypeRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCertificateTypeCommandHandler(QSSContext context, ICertificateTypeRepository certificateTypeRepository)
        {
            _context = context;
            _repository = certificateTypeRepository;
        }

        /// <summary>
        /// Handle the request to Delete CertificateType 
        /// </summary>
        /// <param name="request">Input Delete CertificateType model, <see cref="DeleteCertificateTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCertificateTypeResponse"/></returns>
        public async Task<DeleteCertificateTypeResponse> Handle(DeleteCertificateTypeModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteCertificateTypeResponse()
            {
                Result = true
            };
        }
    }
}
