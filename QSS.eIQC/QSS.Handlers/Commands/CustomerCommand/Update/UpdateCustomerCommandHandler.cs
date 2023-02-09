/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CustomerCommand.Update
{
    /// <summary>
    /// Command Handler for Update Customer operation
    /// </summary>
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerModel, CustomerModel>
    {
        private readonly QSSContext _context;
        private readonly ICustomerRepository _repository;      
        private readonly IMapper _mapper;
        private readonly IUserCustomerRepository _userCustomerRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateCustomerCommandHandler(QSSContext context, ICustomerRepository customerRepository, IMapper mapper, IUserCustomerRepository userCustomerRepository)
        {
            _context = context;
            _repository = customerRepository;            
            _mapper = mapper;
            _userCustomerRepository = userCustomerRepository;
        }

        /// <summary>
        /// Validates the input model and Update Customer entity
        /// </summary>
        /// <param name="request">Input Update Customer model, <see cref="UpdateCustomerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Customer model</returns>
        public async Task<CustomerModel> Handle(UpdateCustomerModel request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request);

            _userCustomerRepository.AddUserCustomers(customer, request.AddedUserIds);


            _userCustomerRepository.RemoveUserCustomers(customer.Id, request.RemovedUserIds);

            await _repository.UpdateAsync(customer, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CustomerModel>(customer);
        }
    }
}
