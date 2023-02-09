/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormFunParaCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormFunPara operation
    /// </summary>
    public class UpdateFormFunParaCommandHandler : IRequestHandler<UpdateFormFunParaModel, FormFunParaModel>
    {
        private readonly QSSContext _context;
        private readonly IFormFunParaRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormFunParaCommandHandler(QSSContext context, IFormFunParaRepository formFunParaRepository, IMapper mapper)
        {
            _context = context;
            _repository = formFunParaRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormFunPara entity
        /// </summary>
        /// <param name="request">Input Update FormFunPara model, <see cref="UpdateFormFunParaModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormFunPara model</returns>
        public async Task<FormFunParaModel> Handle(UpdateFormFunParaModel request, CancellationToken cancellationToken)
        {
            var formFunPara = _mapper.Map<FormFunPara>(request);          

            await _repository.UpdateAsync(formFunPara, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormFunParaModel>(formFunPara);
        }
    }
}
