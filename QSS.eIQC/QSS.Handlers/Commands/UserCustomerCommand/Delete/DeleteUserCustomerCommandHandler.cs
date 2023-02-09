/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete UserCustomer operation
    /// </summary>
    public class DeleteUserCustomerCommandHandler : IRequestHandler<DeleteUserCustomerModel, DeleteUserCustomerResponse>
    {
        private readonly QSSContext _context;
        private readonly IUserCustomerRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteUserCustomerCommandHandler(QSSContext context, IUserCustomerRepository userCustomerRepository)
        {
            _context = context;
            _repository = userCustomerRepository;
        }

        /// <summary>
        /// Handle the request to Delete UserCustomer 
        /// </summary>
        /// <param name="request">Input Delete UserCustomer model, <see cref="DeleteUserCustomerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteUserCustomerResponse"/></returns>
        public async Task<DeleteUserCustomerResponse> Handle(DeleteUserCustomerModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteUserCustomerResponse()
            {
                Result = true
            };
        }
    }
}
