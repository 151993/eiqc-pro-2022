using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Update
{
    public class UpdateCommodityCommandHandler : IRequestHandler<UpdateCommodityModel, CommodityModel>
    {
        private readonly QSSContext _context;
        private readonly ICommodityRepository _repository;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateCommodityCommandHandler(QSSContext context, ICommodityRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Validates the input model and Update Commodity entity
        /// </summary>
        /// <param name="request">Input Update Commodity model, <see cref="UpdateCommodityModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Commodity model</returns>
        public async Task<CommodityModel> Handle(UpdateCommodityModel request, CancellationToken cancellationToken)
        {
            var commodity = _mapper.Map<Commodity>(request);

            await _repository.UpdateAsync(commodity, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CommodityModel>(commodity);
        }
    }
}
