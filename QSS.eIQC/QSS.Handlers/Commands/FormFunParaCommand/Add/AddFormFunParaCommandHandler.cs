/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormFunParaCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormFunPara operation
    /// </summary>
    public class AddFormFunParaCommandHandler : IRequestHandler<AddFormFunParaModel, FormFunParaModel>
    {
        private readonly QSSContext _context;
        private readonly IFormFunParaRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormFunParaCommandHandler(QSSContext context, IFormFunParaRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormFunPara entity
        /// </summary>
        /// <param name="request">Add FormFunPara model, <see cref="AddFormFunParaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormFunPara model</returns>
        public async Task<FormFunParaModel> Handle(AddFormFunParaModel request, CancellationToken cancellationToken)
        {
            var formFunPara = _mapper.Map<FormFunPara>(request);            

            await _repository.AddAsync(formFunPara, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormFunParaModel>(formFunPara);
        }
    }
}
