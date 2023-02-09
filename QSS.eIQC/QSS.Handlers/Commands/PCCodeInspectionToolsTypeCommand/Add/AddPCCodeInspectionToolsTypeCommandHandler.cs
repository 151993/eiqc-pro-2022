/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Add
{
    /// <summary>
    /// Command Handler for Add PCCodeInspectionToolsType operation
    /// </summary>
    public class AddPCCodeInspectionToolsTypeCommandHandler : IRequestHandler<AddPCCodeInspectionToolsTypeModel, PCCodeInspectionToolsTypeModel>
    {
        private readonly QSSContext _context;
        private readonly IPCCodeInspectionToolsTypeRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddPCCodeInspectionToolsTypeCommandHandler(QSSContext context, IPCCodeInspectionToolsTypeRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new PCCodeInspectionToolsType entity
        /// </summary>
        /// <param name="request">Add PCCodeInspectionToolsType model, <see cref="AddPCCodeInspectionToolsTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added PCCodeInspectionToolsType model</returns>
        public async Task<PCCodeInspectionToolsTypeModel> Handle(AddPCCodeInspectionToolsTypeModel request, CancellationToken cancellationToken)
        {
            var pCCodeInspectionToolsType = _mapper.Map<PCCodeInspectionToolsType>(request);            

            await _repository.AddAsync(pCCodeInspectionToolsType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PCCodeInspectionToolsTypeModel>(pCCodeInspectionToolsType);
        }
    }
}
