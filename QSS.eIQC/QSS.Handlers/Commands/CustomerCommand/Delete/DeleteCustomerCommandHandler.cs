/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.CustomerCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Customer operation
    /// </summary>
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerModel, DeleteCustomerResponse>
    {
        private readonly QSSContext _context;
        private readonly ICustomerRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCustomerCommandHandler(QSSContext context, ICustomerRepository customerRepository)
        {
            _context = context;
            _repository = customerRepository;
        }

        /// <summary>
        /// Handle the request to Delete Customer 
        /// </summary>
        /// <param name="request">Input Delete Customer model, <see cref="DeleteCustomerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCustomerResponse"/></returns>
        public async Task<DeleteCustomerResponse> Handle(DeleteCustomerModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteCustomerResponse()
            {
                Result = true
            };
        }
    }
}
