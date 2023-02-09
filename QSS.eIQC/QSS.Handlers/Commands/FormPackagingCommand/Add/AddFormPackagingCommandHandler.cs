/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormPackagingCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormPackaging operation
    /// </summary>
    public class AddFormPackagingCommandHandler : IRequestHandler<AddFormPackagingModel, FormPackagingModel>
    {
        private readonly QSSContext _context;
        private readonly IFormPackagingRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormPackagingCommandHandler(QSSContext context, IFormPackagingRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormPackaging entity
        /// </summary>
        /// <param name="request">Add FormPackaging model, <see cref="AddFormPackagingModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormPackaging model</returns>
        public async Task<FormPackagingModel> Handle(AddFormPackagingModel request, CancellationToken cancellationToken)
        {
            var formPackaging = _mapper.Map<FormPackaging>(request);            

            await _repository.AddAsync(formPackaging, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormPackagingModel>(formPackaging);
        }
    }
}
