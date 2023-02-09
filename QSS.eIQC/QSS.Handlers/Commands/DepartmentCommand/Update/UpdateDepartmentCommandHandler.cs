using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand.Update
{
    /// <summary>
    /// Command Handler for Update Department operation
    /// </summary>
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentModel, DepartmentModel>
    {
        private readonly QSSContext _context;
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateDepartmentCommandHandler(QSSContext context, IDepartmentRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Update Department entity
        /// </summary>
        /// <param name="request">Input Update Department model, <see cref="UpdateDepartmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated Department model</returns>
        public async Task<DepartmentModel> Handle(UpdateDepartmentModel request, CancellationToken cancellationToken)
        {
            var department = _mapper.Map<Department>(request);
            
            await _repository.UpdateAsync(department, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DepartmentModel>(department);
        }
    }
}
