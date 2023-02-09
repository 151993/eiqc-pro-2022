/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete CommodityCategory operation
    /// </summary>
    public class DeleteCommodityCategoryCommandHandler : IRequestHandler<DeleteCommodityCategoryModel, DeleteCommodityCategoryResponse>
    {
        private readonly QSSContext _context;
        private readonly ICommodityCategoryRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCommodityCategoryCommandHandler(QSSContext context, ICommodityCategoryRepository commodityCategoryRepository)
        {
            _context = context;
            _repository = commodityCategoryRepository;
        }

        /// <summary>
        /// Handle the request to Delete CommodityCategory 
        /// </summary>
        /// <param name="request">Input Delete CommodityCategory model, <see cref="DeleteCommodityCategoryModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCommodityCategoryResponse"/></returns>
        public async Task<DeleteCommodityCategoryResponse> Handle(DeleteCommodityCategoryModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeleteCommodityCategoryResponse()
            {
                Result = true
            };
        }
    }
}
