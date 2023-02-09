using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand.Delete
{
    public class DeleteCommodityCommandHandler : IRequestHandler<DeleteCommodityModel, DeleteCommodityResponse>
    {
        private readonly QSSContext _context;
        private readonly ICommodityRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteCommodityCommandHandler(QSSContext context, ICommodityRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Commodity 
        /// </summary>
        /// <param name="request">Input Delete Commodity model, <see cref="DeleteCommodityModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteCommodityResponse"/></returns>
        public async Task<DeleteCommodityResponse> Handle(DeleteCommodityModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteCommodityResponse()
            {
                Result = count > 0
            };
        }
    }
}
