/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete PartBowTwistParameter operation
    /// </summary>
    public class DeletePartInspectionBowTwistParameterCommandHandler : IRequestHandler<DeletePartInspectionBowTwistParameterModel, DeletePartInspectionBowTwistParameterResponse>
    {
        private readonly QSSContext _context;
        private readonly IPartInspectionBowTwistParameterRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeletePartInspectionBowTwistParameterCommandHandler(QSSContext context, IPartInspectionBowTwistParameterRepository partBowTwistParameterRepository)
        {
            _context = context;
            _repository = partBowTwistParameterRepository;
        }

        /// <summary>
        /// Handle the request to Delete PartBowTwistParameter 
        /// </summary>
        /// <param name="request">Input Delete PartBowTwistParameter model, <see cref="DeletePartInspectionBowTwistParameterModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeletePartInspectionBowTwistParameterResponse"/></returns>
        public async Task<DeletePartInspectionBowTwistParameterResponse> Handle(DeletePartInspectionBowTwistParameterModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            _context.SaveChanges();

            return new DeletePartInspectionBowTwistParameterResponse()
            {
                Result = true
            };
        }
    }
}
