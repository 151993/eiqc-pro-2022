/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Update
{
    /// <summary>
    /// Command Handler for Update AdminCertification operation
    /// </summary>
    public class UpdateAdminCertificationCommandHandler : IRequestHandler<UpdateAdminCertificationModel, AdminCertificationModel>
    {
        private readonly QSSContext _context;    
        private readonly IMapper _mapper;
        private readonly IAdminCertificationRepository _repository;
        private readonly IAdminCertificationAttachmentRepository _adminCertificationAttachmentRepository;
        private readonly IFileExtensionService _fileExtensionService;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateAdminCertificationCommandHandler(QSSContext context, IAdminCertificationRepository adminCertificationRepository, IMapper mapper,
            IAdminCertificationAttachmentRepository adminCertificationAttachmentRepository, IFileExtensionService fileExtensionService)
        {
            _mapper = mapper;
            _context = context;
            _repository = adminCertificationRepository;         
            this._adminCertificationAttachmentRepository = adminCertificationAttachmentRepository;
            this._fileExtensionService = fileExtensionService;
        }

        /// <summary>
        /// Validates the input model and Update AdminCertification entity
        /// </summary>
        /// <param name="request">Input Update AdminCertification model, <see cref="UpdateAdminCertificationModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated AdminCertification model</returns>
        public async Task<AdminCertificationModel> Handle(UpdateAdminCertificationModel request, CancellationToken cancellationToken)
        {
            var adminCertification = _mapper.Map<AdminCertification>(request);

            _adminCertificationAttachmentRepository.RemoveRange(adminCertification.Id, request.RemovedAttachmentIds);

            foreach (var file in adminCertification.AdminCertificationAttachments)
            {
                _fileExtensionService.MoveFileToPermanentStorage(file.Attachment.Name, file.Attachment.TempSavePath, file.Attachment.SavePath);
            }

            await _repository.UpdateAsync(adminCertification, request.ChangeReason);

            _context.SaveChanges();

            return _mapper.Map<AdminCertificationModel>(adminCertification);
        }
    }
}
