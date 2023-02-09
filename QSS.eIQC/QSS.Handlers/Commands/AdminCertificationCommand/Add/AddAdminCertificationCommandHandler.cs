/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Add
{
    /// <summary>
    /// Command Handler for Add AdminCertification operation
    /// </summary>
    public class AddAdminCertificationCommandHandler : IRequestHandler<AddAdminCertificationModel, AdminCertificationModel>
    {
        private readonly IMapper _mapper;
        private readonly QSSContext _context;
        private readonly IAdminCertificationRepository _repository;        
        private readonly IAdminCertificationAttachmentRepository _adminCertificationAttachmentRepository;
        private readonly IFileExtensionService _fileExtensionService;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddAdminCertificationCommandHandler(QSSContext context, IAdminCertificationRepository repository, IMapper mapper, 
            IAdminCertificationAttachmentRepository adminCertificationAttachmentRepository, IFileExtensionService fileExtensionService)
        {
            _mapper = mapper;
            _context = context;
            _repository = repository;
            this._adminCertificationAttachmentRepository = adminCertificationAttachmentRepository;
            this._fileExtensionService = fileExtensionService;
        }

        /// <summary>
        /// Validates the input model and Add new AdminCertification entity
        /// </summary>
        /// <param name="request">Add AdminCertification model, <see cref="AddAdminCertificationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added AdminCertification model</returns>
        public async Task<AdminCertificationModel> Handle(AddAdminCertificationModel request, CancellationToken cancellationToken)
        {
            var adminCertification = _mapper.Map<AdminCertification>(request);

            var attachments = _mapper.Map<IEnumerable<Attachment>>(request.Attachments);
            _adminCertificationAttachmentRepository.AddAdminCertificationAttachments(adminCertification, attachments, request.ChangeReason);

            foreach (var file in request.Attachments)
            {
                _fileExtensionService.MoveFileToPermanentStorage(file.Name, file.TempSavePath, file.SavePath);
            }

            await _repository.AddAsync(adminCertification, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<AdminCertificationModel>(adminCertification);
        }
    }
}
