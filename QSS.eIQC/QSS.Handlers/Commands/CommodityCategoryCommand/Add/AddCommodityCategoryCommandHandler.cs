/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Add
{
    /// <summary>
    /// Command Handler for Add CommodityCategory operation
    /// </summary>
    public class AddCommodityCategoryCommandHandler : IRequestHandler<AddCommodityCategoryModel, CommodityCategoryModel>
    {
        private readonly QSSContext _context;
        private readonly ICommodityCategoryRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddCommodityCategoryCommandHandler(QSSContext context, ICommodityCategoryRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new CommodityCategory entity
        /// </summary>
        /// <param name="request">Add CommodityCategory model, <see cref="AddCommodityCategoryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added CommodityCategory model</returns>
        public async Task<CommodityCategoryModel> Handle(AddCommodityCategoryModel request, CancellationToken cancellationToken)
        {
            var commodityCategory = _mapper.Map<CommodityCategory>(request);            

            await _repository.AddAsync(commodityCategory, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CommodityCategoryModel>(commodityCategory);
        }
    }
}
