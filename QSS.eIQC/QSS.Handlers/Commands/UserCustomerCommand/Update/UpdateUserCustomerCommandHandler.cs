/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.UserCustomerCommand.Update
{
    /// <summary>
    /// Command Handler for Update UserCustomer operation
    /// </summary>
    public class UpdateUserCustomerCommandHandler : IRequestHandler<UpdateUserCustomerModel, UserCustomerModel>
    {
        private readonly QSSContext _context;
        private readonly IUserCustomerRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateUserCustomerCommandHandler(QSSContext context, IUserCustomerRepository userCustomerRepository, IMapper mapper)
        {
            _context = context;
            _repository = userCustomerRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update UserCustomer entity
        /// </summary>
        /// <param name="request">Input Update UserCustomer model, <see cref="UpdateUserCustomerModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated UserCustomer model</returns>
        public async Task<UserCustomerModel> Handle(UpdateUserCustomerModel request, CancellationToken cancellationToken)
        {
            var userCustomer = _mapper.Map<UserCustomer>(request);          

            await _repository.UpdateAsync(userCustomer, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<UserCustomerModel>(userCustomer);
        }
    }
}
