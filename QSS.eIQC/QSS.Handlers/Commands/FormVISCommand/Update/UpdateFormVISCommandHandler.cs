/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormVIS operation
    /// </summary>
    public class UpdateFormVISCommandHandler : IRequestHandler<UpdateFormVISModel, FormVISModel>
    {
        private readonly QSSContext _context;
        private readonly IFormVISRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormVISCommandHandler(QSSContext context, IFormVISRepository formVISRepository, IMapper mapper)
        {
            _context = context;
            _repository = formVISRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormVIS entity
        /// </summary>
        /// <param name="request">Input Update FormVIS model, <see cref="UpdateFormVISModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormVIS model</returns>
        public async Task<FormVISModel> Handle(UpdateFormVISModel request, CancellationToken cancellationToken)
        {
            var formVIS = _mapper.Map<FormVIS>(request);          

            await _repository.UpdateAsync(formVIS, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormVISModel>(formVIS);
        }
    }
}
