/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Update;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.ApproveReject
{
    /// <summary>
    /// Command Handler for Update SAPPartInspectionPlan operation
    /// </summary>
    public class ApproveRejectSupplierMeasurementSubmissionPlanCommandHandler : IRequestHandler<ApproveRejectSupplierMeasurementSubmissionPlanModel, SupplierMeasurementSubmissionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierMeasurementSubmissionRepository _repository;      
        private readonly IMapper _mapper;
        private readonly ISMSCommentAttachmentRepository _smsCommentAttachmentRepository;
        private readonly IFileExtensionService _fileExtensionService;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param> 
        public ApproveRejectSupplierMeasurementSubmissionPlanCommandHandler(QSSContext context, ISupplierMeasurementSubmissionRepository supplierMeasurementSubmissionRepository, 
            IMapper mapper, ISMSCommentAttachmentRepository smsCommentAttachmentRepository, IFileExtensionService fileExtensionService)
        {
            _context = context;
            _repository = supplierMeasurementSubmissionRepository;            
            _mapper = mapper;
            _smsCommentAttachmentRepository = smsCommentAttachmentRepository;
            _fileExtensionService = fileExtensionService;
        }

        /// <summary>
        /// Validates the input model and Update SupplierMeasurementSubmission entity
        /// </summary>
        /// <param name="request">Input Update SupplierMeasurementSubmission model, <see cref="UpdateSupplierMeasurementSubmissionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierMeasurementSubmission model</returns>
        public async Task<SupplierMeasurementSubmissionModel> Handle(ApproveRejectSupplierMeasurementSubmissionPlanModel request, CancellationToken cancellationToken)
        {
            var supplierMeasurementSubmission = _mapper.Map<SupplierMeasurementSubmission>(request);

            AddSMSCommentAttachments(request, supplierMeasurementSubmission);

            await _repository.UpdateAsync(supplierMeasurementSubmission, string.Empty);

            _context.SaveChanges();
            return new SupplierMeasurementSubmissionModel();
            //return _mapper.Map<SupplierMeasurementSubmissionModel>(supplierMeasurementSubmission);
        }



        async Task AddSMSCommentAttachments(ApproveRejectSupplierMeasurementSubmissionPlanModel request, SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            var uploadSMSCommentAttachments = _mapper.Map<IEnumerable<Attachment>>(request.UploadSMSCommentAttachments);

            await _smsCommentAttachmentRepository.AddSMSCommentAttachments(supplierMeasurementSubmission, uploadSMSCommentAttachments, request.ChangeReason);

            if (request.UploadSMSCommentAttachments != null)
            {
                foreach (var file in request.UploadSMSCommentAttachments)
                {
                    _fileExtensionService.MoveFileToPermanentStorage(file.Name, file.TempSavePath, file.SavePath);
                }
            }
        }


    }
}
