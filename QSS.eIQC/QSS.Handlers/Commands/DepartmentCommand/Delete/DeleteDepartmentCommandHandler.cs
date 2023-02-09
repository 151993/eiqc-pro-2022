using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand.Delete
{
    /// <summary>
    /// Command Handler for Delete Department operation
    /// </summary>
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentModel, DeleteDepartmentResponse>
    {
        private readonly QSSContext _context;
        private readonly IDepartmentRepository _repository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        public DeleteDepartmentCommandHandler(QSSContext context, IDepartmentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        /// <summary>
        /// Handle the request to Delete Department 
        /// </summary>
        /// <param name="request">Input Delete Department model, <see cref="DeleteDepartmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Returns result, <see cref="DeleteDepartmentResponse"/></returns>
        public async Task<DeleteDepartmentResponse> Handle(DeleteDepartmentModel request, CancellationToken cancellationToken)
        {
            await _repository.RemoveByIdAsync(request.Id, request.ChangeReason);

            var count = _context.SaveChanges();

            return new DeleteDepartmentResponse()
            {
                Result = count > 0
            };
        }
    }
}
