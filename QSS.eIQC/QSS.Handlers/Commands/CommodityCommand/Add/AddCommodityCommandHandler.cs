using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Add
{
    public class AddCommodityCommandHandler : BaseCommand, IRequestHandler<AddCommodityModel, CommodityModel>
    {
        private readonly QSSContext _context;
        private readonly ICommodityRepository _repository;
        private readonly IMapper _mapper;
        private readonly IFileExtensionService _fileExtensionService;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddCommodityCommandHandler(QSSContext context, ICommodityRepository repository, 
            IMapper mapper) 
        {
            _mapper = mapper;
            _context = context;
            _repository = repository;            
        }

        /// <summary>
        /// Validates the input model and Add new Commodity entity
        /// </summary>
        /// <param name="request">Add Commodity model, <see cref="AddCommodityModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Commodity Model</returns>
        public async Task<CommodityModel> Handle(AddCommodityModel request, CancellationToken cancellationToken)
        {
            var commodity = _mapper.Map<Commodity>(request);
            await _repository.AddAsync(commodity, request.ChangeReason); 
            _context.SaveChanges();
            return _mapper.Map<CommodityModel>(commodity);
        }
    }
}
