/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.PartDateCodeCommand.Update
{
    /// <summary>
    /// Command Handler for Update DateCode operation
    /// </summary>
    public class UpdatePartDateCodeCommandHandler : IRequestHandler<UpdatePartDateCodeModel, PartDateCodeModel>
    {
        private readonly QSSContext _context;
        private readonly IPartDateCodeRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdatePartDateCodeCommandHandler(QSSContext context, IPartDateCodeRepository dateCodeRepository, IMapper mapper)
        {
            _context = context;
            _repository = dateCodeRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update DateCode entity
        /// </summary>
        /// <param name="request">Input Update DateCode model, <see cref="UpdatePartDateCodeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated DateCode model</returns>
        public async Task<PartDateCodeModel> Handle(UpdatePartDateCodeModel request, CancellationToken cancellationToken)
        {
            var dateCode = _mapper.Map<PartDateCode>(request);          

            await _repository.UpdateAsync(dateCode, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<PartDateCodeModel>(dateCode);
        }
    }
}
