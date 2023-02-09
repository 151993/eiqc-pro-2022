/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add
{
    /// <summary>
    /// Command Handler for Add CertificateType operation
    /// </summary>
    public class AddCertificateTypeCommandHandler : IRequestHandler<AddCertificateTypeModel, CertificateTypeModel>
    {
        private readonly QSSContext _context;
        private readonly ICertificateTypeRepository _repository;
        private readonly ICertificateTypeParameterRepository _icertificateTypeParameterRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddCertificateTypeCommandHandler(QSSContext context, ICertificateTypeRepository repository, ICertificateTypeParameterRepository icertificateTypeParameterRepository, IMapper mapper)
        {
            _context = context;
            _repository = repository;
            _icertificateTypeParameterRepository = icertificateTypeParameterRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Validates the input model and Add new CertificateType entity
        /// </summary>
        /// <param name="request">Add CertificateType model, <see cref="AddCertificateTypeModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added CertificateType model</returns>
        public async Task<CertificateTypeModel> Handle(AddCertificateTypeModel request, CancellationToken cancellationToken)
        {
            var certificateType = _mapper.Map<CertificateType>(request);

            _icertificateTypeParameterRepository.AddCertificateTypeParameters(certificateType, request.AddedCertificateTypeParameters);

            await _repository.AddAsync(certificateType, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<CertificateTypeModel>(certificateType);
        }
    }
}
