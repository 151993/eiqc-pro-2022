/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Update
{
    /// <summary>
    /// Command Handler for Update CommodityCategory operation
    /// </summary>
    public class UpdateCommodityCategoryCommandHandler : IRequestHandler<UpdateCommodityCategoryModel, CommodityCategoryModel>
    {
        private readonly QSSContext _context;
        private readonly ICommodityCategoryRepository _repository;      
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateCommodityCategoryCommandHandler(QSSContext context, ICommodityCategoryRepository commodityCategoryRepository, IMapper mapper)
        {
            _context = context;
            _repository = commodityCategoryRepository;            
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update CommodityCategory entity
        /// </summary>
        /// <param name="request">Input Update CommodityCategory model, <see cref="UpdateCommodityCategoryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated CommodityCategory model</returns>
        public async Task<CommodityCategoryModel> Handle(UpdateCommodityCategoryModel request, CancellationToken cancellationToken)
        {
            var commodityCategory = _mapper.Map<CommodityCategory>(request);          

            await _repository.UpdateAsync(commodityCategory, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CommodityCategoryModel>(commodityCategory);
        }
    }
}
