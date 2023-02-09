/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Update
{
    /// <summary>
    /// Command Handler for Update SupplierMeasurementSubmission operation
    /// </summary>
    public class UpdateSupplierMeasurementSubmissionCommandHandler : IRequestHandler<UpdateSupplierMeasurementSubmissionModel, SupplierMeasurementSubmissionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierMeasurementSubmissionRepository _repository;
        private readonly IMapper _mapper;
        private readonly ISupplierFunctionAttributeRepository _supplierFunctionAttributeRepository;
        private readonly ISupplierFunctionAttributeDefectTypeRepository _supplierFunctionAttributeDefectTypeRepository;
        private readonly ISupplierMicrosectionRepository _supplierMicrosectionRepository;
        private readonly ISupplierSapBasedParameterRepository _supplierSapBasedParameterRepository;
        private readonly ISupplierSapBasedParameterDefectTypeRepository _supplierSapBasedParameterDefectTypeRepository;
        private readonly ISupplierDimensionMeasurementRepository _supplierDimensionMeasurementRepository;
        private readonly ISupplierFunctionVariableRepository _supplierFunctionVariableRepository;
        private readonly ISupplierDateCodeRepository _supplierDateCodeRepository;
        private readonly ISupplierTestReportRepository _supplierTestReportRepository;
        private readonly ISupplierTestReportAttachmentRepository _supplierTestReportAttachmentRepository;
        private readonly ISupplierMPositionRepository _supplierMPositionRepository;
        private readonly ISupplierMPositionActualRepository _supplierMPositionActualRepository;
        private readonly ISupplierLPositionRepository _supplierLPositionRepository;
        private readonly ISupplierLPositionActualRepository _supplierLPositionActualRepository;


        private readonly IFileExtensionService _fileExtensionService;
        private readonly ISupplierBowTwistRepository _supplierBowTwistRepository;
        private readonly ISupplierBowTwistActualRepository _supplierBowTwistActualRepository;
        private readonly ISupplierMicroSectionActualRepository _supplierMicroSectionActualRepository;
        private readonly ISupplierMicrosectionRepository _supplierMicroSectionRepository;
        private readonly ISupplierVisualInspectionRepository _supplierVisualInspectionRepository;
        private readonly ISupplierVisualInspectionDefectTypeRepository _supplierVisualInspectionDefectTypeRepository;
        private readonly ISupplierFunctionAttributeActualRepository _supplierFunctionAttributeActualRepository;
        private readonly ISMSCommentAttachmentRepository _smsCommentAttachmentRepository;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSupplierMeasurementSubmissionCommandHandler(QSSContext context, ISupplierMeasurementSubmissionRepository repository, IMapper mapper,
             IFileExtensionService fileExtensionService,
             ISupplierFunctionAttributeRepository supplierFunctionAttributeRepository,
            ISupplierFunctionAttributeDefectTypeRepository supplierFunctionAttributeDefectTypeRepository,
            ISupplierMicrosectionRepository supplierMicrosectionRepository,
            ISupplierSapBasedParameterRepository supplierSapBasedParameterRepository,
            ISupplierSapBasedParameterDefectTypeRepository supplierSapBasedParameterDefectTypeRepository,
            ISupplierDimensionMeasurementRepository supplierDimensionMeasurementRepository,
            ISupplierFunctionVariableRepository supplierFunctionVariableRepository,
            ISupplierTestReportRepository supplierTestReportRepository,
            ISupplierTestReportAttachmentRepository supplierTestReportAttachmentRepository
            ,ISupplierDateCodeRepository supplierDateCodeRepository,
            ISupplierBowTwistRepository SupplierBowTwistRepository,
            ISupplierBowTwistActualRepository SupplierBowTwistActualRepository,
            ISupplierMPositionRepository supplierMPositionRepository, 
            ISupplierMPositionActualRepository supplierMPositionActualRepository,
            ISupplierLPositionRepository supplierLPositionRepository,
            ISupplierLPositionActualRepository supplierLPositionActualRepository,
            ISupplierMicroSectionActualRepository SupplierMicroSectionActualRepository,
            ISupplierMicrosectionRepository SupplierMicroSectionRepository,
            ISupplierVisualInspectionRepository SupplierVisualInspectionRepository,
            ISupplierVisualInspectionDefectTypeRepository SupplierVisualInspectionDefectTypeRepository,
            ISupplierFunctionAttributeActualRepository SupplierFunctionAttributeActualRepository,
            ISMSCommentAttachmentRepository smsCommentAttachmentRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _fileExtensionService = fileExtensionService;
            _supplierFunctionAttributeRepository = supplierFunctionAttributeRepository;
            _supplierFunctionAttributeDefectTypeRepository = supplierFunctionAttributeDefectTypeRepository;
            _supplierMicrosectionRepository = supplierMicrosectionRepository;
            _supplierSapBasedParameterRepository = supplierSapBasedParameterRepository;
            _supplierSapBasedParameterDefectTypeRepository = supplierSapBasedParameterDefectTypeRepository;
            _supplierDimensionMeasurementRepository = supplierDimensionMeasurementRepository;
            _supplierFunctionVariableRepository = supplierFunctionVariableRepository;
            _supplierTestReportRepository = supplierTestReportRepository;
            _supplierTestReportAttachmentRepository = supplierTestReportAttachmentRepository;
            _supplierDateCodeRepository = supplierDateCodeRepository;
            _supplierBowTwistRepository = SupplierBowTwistRepository;
            _supplierBowTwistActualRepository = SupplierBowTwistActualRepository;
            _supplierMPositionRepository = supplierMPositionRepository;
            _supplierMPositionActualRepository = supplierMPositionActualRepository;
            _supplierLPositionRepository = supplierLPositionRepository;
            _supplierLPositionActualRepository = supplierLPositionActualRepository;
            _supplierMicroSectionActualRepository = SupplierMicroSectionActualRepository;
            _supplierMicroSectionRepository = SupplierMicroSectionRepository;
            _supplierFunctionAttributeActualRepository = SupplierFunctionAttributeActualRepository;
            _supplierVisualInspectionRepository = SupplierVisualInspectionRepository;
            _supplierVisualInspectionDefectTypeRepository = SupplierVisualInspectionDefectTypeRepository;
            _smsCommentAttachmentRepository = smsCommentAttachmentRepository;
        }

        /// <summary>
        /// Validates the input model and Update SupplierMeasurementSubmission entity
        /// </summary>
        /// <param name="request">Input Update SupplierMeasurementSubmission model, <see cref="UpdateSupplierMeasurementSubmissionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SupplierMeasurementSubmission model</returns>
        public async Task<SupplierMeasurementSubmissionModel> Handle(UpdateSupplierMeasurementSubmissionModel request, CancellationToken cancellationToken)
        {
            var supplierMeasurementSubmission = _mapper.Map<SupplierMeasurementSubmission>(request);

           #region Function Attribute Section
            _supplierFunctionAttributeRepository.RemoveRange(supplierMeasurementSubmission);

            supplierMeasurementSubmission.SupplierFunctionAttributes.Clear();

            foreach (var functionAttribute in request.SupplierFunctionAttributes)
            {

                var supplierFunctionAttribute = _mapper.Map<SupplierFunctionAttribute>(functionAttribute);

                supplierMeasurementSubmission.SupplierFunctionAttributes.Add(supplierFunctionAttribute);

                _supplierFunctionAttributeDefectTypeRepository.AddSupplierFunctionAttributeDefectTypes(supplierFunctionAttribute, functionAttribute.AddedDefectTypeIds);

                var supplierFunctionAttributeActual = _mapper.Map<IEnumerable<SupplierFunctionAttributeActual>>(functionAttribute.SupplierFunctionAttributeActuals);

                _supplierFunctionAttributeActualRepository.AddSupplierFunctionAttributeActuals(supplierFunctionAttribute, supplierFunctionAttributeActual);
            }

            #endregion

            #region Sap-Based Section
            _supplierSapBasedParameterRepository.RemoveRange(supplierMeasurementSubmission);

            supplierMeasurementSubmission.SupplierSapBasedParameters.Clear();
            foreach (var supplierSapbased in request.SupplierSapBasedParameters)
            {

                var supplierSapbasedParameter = _mapper.Map<SupplierSapBasedParameter>(supplierSapbased);

                supplierMeasurementSubmission.SupplierSapBasedParameters.Add(supplierSapbasedParameter);

                _supplierSapBasedParameterDefectTypeRepository.AddSupplierSapBasedParameterDefectTypes(supplierSapbasedParameter, supplierSapbased.AddedDefectTypeIds);
            }
            #endregion

            #region Microsection

            if (request.SupplierMicrosectionParameters != null)
            {
                _supplierMicrosectionRepository.RemoveRange(supplierMeasurementSubmission);
            }
            #endregion

            #region DimensionMeasurements
            if (request.SupplierDimensionMeasurements != null)
            {
                _supplierDimensionMeasurementRepository.RemoveRange(supplierMeasurementSubmission);
            }
            #endregion

            #region FunctionVariables
            if (request.SupplierFunctionVariables != null)
            {
                _supplierFunctionVariableRepository.RemoveRange(supplierMeasurementSubmission);
            }
            #endregion


            #region Spec with MMC
            if (request.SupplierMPositions!=null)
            {
                _supplierMPositionRepository.RemoveRange(supplierMeasurementSubmission);

                supplierMeasurementSubmission.SupplierMPositions.Clear();

                foreach (var supplierBowTwist in request.SupplierMPositions)
                {
                    var mPosition = _mapper.Map<SupplierMPosition>(supplierBowTwist);

                    supplierMeasurementSubmission.SupplierMPositions.Add(mPosition);

                    var SupplierMPositionActual = _mapper.Map<IEnumerable<SupplierMPositionActual>>(supplierBowTwist.SupplierMPositionActuals);

                    _supplierMPositionActualRepository.AddSupplierMPositionActuals(mPosition, SupplierMPositionActual);
                }
            }
            #endregion

            #region Spec with LMC

            if (request.SupplierLPositions != null)
            {
                _supplierLPositionRepository.RemoveRange(supplierMeasurementSubmission);

                supplierMeasurementSubmission.SupplierLPositions.Clear();

                foreach (var supplierBowTwist in request.SupplierLPositions)
                {
                    var lPosition = _mapper.Map<SupplierLPosition>(supplierBowTwist);

                    supplierMeasurementSubmission.SupplierLPositions.Add(lPosition);

                    var SupplierLPositionActual = _mapper.Map<IEnumerable<SupplierLPositionActual>>(supplierBowTwist.SupplierLPositionActuals);

                    _supplierLPositionActualRepository.AddSupplierLPositionActuals(lPosition, SupplierLPositionActual);
                }
            }

            #endregion

            #region SupplierBowTwist Section
            _supplierBowTwistRepository.RemoveRange(supplierMeasurementSubmission);

            supplierMeasurementSubmission.SupplierBowTwists.Clear();

            foreach (var supplierBowTwist in request.SupplierBowTwists)
            {

                var bowTwist = _mapper.Map<SupplierBowTwist>(supplierBowTwist);

                supplierMeasurementSubmission.SupplierBowTwists.Add(bowTwist);

                var supplierBowTiwstActual = _mapper.Map<IEnumerable<SupplierBowTwistActual>>(supplierBowTwist.SupplierBowTwistActuals);

                _supplierBowTwistActualRepository.AddSupplierBowTwistActuals(bowTwist, supplierBowTiwstActual);
            }

            #endregion

            #region Supplier Micro Section
            supplierMeasurementSubmission.SupplierMicrosectionParameters.Clear();

            if(request.SupplierMicrosectionParameters!=null)
            {
                foreach (var supplierMicroSection in request.SupplierMicrosectionParameters)
                {
                    var supplierMicro = _mapper.Map<SupplierMicrosection>(supplierMicroSection);

                    supplierMeasurementSubmission.SupplierMicrosectionParameters.Add(supplierMicro);


                    var supplierMicroSectionActual = _mapper.Map<IEnumerable<SupplierMicroSectionActual>>(supplierMicroSection.SupplierMicroSectionActuals);


                    _supplierMicroSectionActualRepository.AddSupplierMicroSectionActuals(supplierMicro, supplierMicroSectionActual);
                }
            }
           

            #endregion


            #region  Supplier Visual Inspection Section
            _supplierVisualInspectionRepository.RemoveRange(supplierMeasurementSubmission);

            supplierMeasurementSubmission.SupplierVisualInspections.Clear();

            foreach (var supplierVisualInspection in request.SupplierVisualInspections)
            {

                var visualInspection = _mapper.Map<SupplierVisualInspection>(supplierVisualInspection);

                supplierMeasurementSubmission.SupplierVisualInspections.Add(visualInspection);

                _supplierVisualInspectionDefectTypeRepository.AddSupplierVisualInspectionDefectTypes(visualInspection, supplierVisualInspection.AddedDefectTypeIds);
            }


            #endregion

            UpdateSMSCommentAttachments(request, supplierMeasurementSubmission);

            _supplierDateCodeRepository.RemoveRange(supplierMeasurementSubmission);

            UpdateSupplierTestReportParametersAttachments(request, supplierMeasurementSubmission);

            await _repository.UpdateAsync(supplierMeasurementSubmission, request.ChangeReason);

            _context.SaveChanges();

            return new SupplierMeasurementSubmissionModel();

            // return _mapper.Map<SupplierMeasurementSubmissionModel>(supplierMeasurementSubmission);
        }


        void UpdateSMSCommentAttachments(UpdateSupplierMeasurementSubmissionModel request, SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            _smsCommentAttachmentRepository.RemoveRange(supplierMeasurementSubmission.Id, request.RemovedSMSCommentAttachmentIds);

            if (request.UploadSMSCommentAttachments != null)
            {
                foreach (var file in request.UploadSMSCommentAttachments)
                {
                    _fileExtensionService.MoveFileToPermanentStorage(file.Name, file.TempSavePath, file.SavePath);
                }
            }
        }

        void UpdateSupplierTestReportParametersAttachments(UpdateSupplierMeasurementSubmissionModel request, SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            _supplierTestReportRepository.RemoveRange(supplierMeasurementSubmission);

            if (request.SupplierTestReports != null)
            {
                foreach (var supplierTestReport in request.SupplierTestReports)
                {

                    if (supplierTestReport != null && supplierTestReport.SupplierTestReportAttachments != null)
                    {                       
                        _supplierTestReportAttachmentRepository.RemoveRange(supplierTestReport.Id, supplierTestReport.RemovedSupplierTestReportAttachmentIds);

                        foreach (var supplierTestReportAttachment in supplierTestReport.SupplierTestReportAttachments)
                        {
                            if (supplierTestReportAttachment != null && supplierTestReportAttachment.Attachment != null && supplierTestReportAttachment.Attachment.Id == 0)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(supplierTestReportAttachment.Attachment.Name, supplierTestReportAttachment.Attachment.TempSavePath, supplierTestReportAttachment.Attachment.SavePath);
                            }
                        }
                    }
                }
            }
        }
    }
}