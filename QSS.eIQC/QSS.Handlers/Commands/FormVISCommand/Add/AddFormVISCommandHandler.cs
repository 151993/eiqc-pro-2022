/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.FormVISCommand.Add
{
    /// <summary>
    /// Command Handler for Add FormVIS operation
    /// </summary>
    public class AddFormVISCommandHandler : IRequestHandler<AddFormVISModel, FormVISModel>
    {
        private readonly QSSContext _context;
        private readonly IFormVISRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddFormVISCommandHandler(QSSContext context, IFormVISRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new FormVIS entity
        /// </summary>
        /// <param name="request">Add FormVIS model, <see cref="AddFormVISModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added FormVIS model</returns>
        public async Task<FormVISModel> Handle(AddFormVISModel request, CancellationToken cancellationToken)
        {
            var formVIS = _mapper.Map<FormVIS>(request);            

            await _repository.AddAsync(formVIS, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<FormVISModel>(formVIS);
        }
    }
}
