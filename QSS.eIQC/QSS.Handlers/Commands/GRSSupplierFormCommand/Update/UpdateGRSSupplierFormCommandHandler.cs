/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Update
{
    /// <summary>
    /// Command Handler for Update GRSSupplierForm operation
    /// </summary>
    public class UpdateGRSSupplierFormCommandHandler : IRequestHandler<UpdateGRSSupplierFormModel, GRSSupplierFormModel>
    {
        private readonly QSSContext _context;
        private readonly IGRSSupplierFormRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateGRSSupplierFormCommandHandler(QSSContext context, IGRSSupplierFormRepository gRSSupplierFormRepository, IMapper mapper)
        {
            _context = context;
            _repository = gRSSupplierFormRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update GRSSupplierForm entity
        /// </summary>
        /// <param name="request">Input Update GRSSupplierForm model, <see cref="UpdateGRSSupplierFormModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated GRSSupplierForm model</returns>
        public async Task<GRSSupplierFormModel> Handle(UpdateGRSSupplierFormModel request, CancellationToken cancellationToken)
        {
            var gRSSupplierForm = _mapper.Map<GRSSupplierForm>(request);          

            await _repository.UpdateAsync(gRSSupplierForm, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<GRSSupplierFormModel>(gRSSupplierForm);
        }
    }
}
