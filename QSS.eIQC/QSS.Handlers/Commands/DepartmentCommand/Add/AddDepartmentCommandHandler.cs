using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand.Add
{
    /// <summary>
    /// Command Handler for Add Department operation
    /// </summary>
    public class AddDepartmentCommandHandler : IRequestHandler<AddDepartmentModel, DepartmentModel>
    {
        private readonly QSSContext _context;
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;
       
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddDepartmentCommandHandler(QSSContext context, IDepartmentRepository repository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;

        }

        /// <summary>
        /// Validates the input model and Add new Department entity
        /// </summary>
        /// <param name="request">Add Department model, <see cref="AddDepartmentModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added Department model</returns>
        public async Task<DepartmentModel> Handle(AddDepartmentModel request, CancellationToken cancellationToken)
        {
            var department = _mapper.Map<Department>(request);

            await _repository.AddAsync(department, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<DepartmentModel>(department);
        }
    }
}
