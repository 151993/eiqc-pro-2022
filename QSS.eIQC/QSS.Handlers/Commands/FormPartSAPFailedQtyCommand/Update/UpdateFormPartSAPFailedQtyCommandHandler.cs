/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Update
{
    /// <summary>
    /// Command Handler for Update FormPartSAPFailedQty operation
    /// </summary>
    public class UpdateFormPartSAPFailedQtyCommandHandler : IRequestHandler<UpdateFormPartSAPFailedQtyModel, FormPartSAPFailedQtyModel>
    {
        private readonly QSSContext _context;
        private readonly IFormPartSAPFailedQtyRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateFormPartSAPFailedQtyCommandHandler(QSSContext context, IFormPartSAPFailedQtyRepository formPartSAPFailedQtyRepository, IMapper mapper)
        {
            _context = context;
            _repository = formPartSAPFailedQtyRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update FormPartSAPFailedQty entity
        /// </summary>
        /// <param name="request">Input Update FormPartSAPFailedQty model, <see cref="UpdateFormPartSAPFailedQtyModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated FormPartSAPFailedQty model</returns>
        public async Task<FormPartSAPFailedQtyModel> Handle(UpdateFormPartSAPFailedQtyModel request, CancellationToken cancellationToken)
        {
            var formPartSAPFailedQty = _mapper.Map<FormPartSAPFailedQty>(request);          

            await _repository.UpdateAsync(formPartSAPFailedQty, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormPartSAPFailedQtyModel>(formPartSAPFailedQty);
        }
    }
}
