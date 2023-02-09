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

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Add
{
    /// <summary>
    /// Command Handler for Add SupplierMeasurementSubmission operation
    /// </summary>
    public class AddSupplierMeasurementSubmissionCommandHandler : IRequestHandler<AddSupplierMeasurementSubmissionModel, SupplierMeasurementSubmissionModel>
    {
        private readonly QSSContext _context;
        private readonly ISupplierMeasurementSubmissionRepository _repository;
        private readonly IMapper _mapper;
        private readonly ISupplierFunctionAttributeRepository _supplierFunctionAttributeRepository;
        private readonly ISupplierFunctionAttributeDefectTypeRepository _supplierFunctionAttributeDefectTypeRepository;
        private readonly ISupplierSamplingPlanRepository _supplierSamplingPlanRepository;
        private readonly ISupplierSapBasedParameterRepository _supplierSapBasedParameterRepository;
        private readonly ISupplierSapBasedParameterDefectTypeRepository _supplierSapBasedParameterDefectTypeRepository;
        private readonly IFileExtensionService _fileExtensionService;
        private readonly ISupplierTestReportAttachmentRepository _supplierTestReportAttachmentRepository;
        private readonly ISupplierBowTwistRepository _supplierBowTwistRepository;
        private readonly ISupplierBowTwistActualRepository _supplierBowTwistActualRepository;
        private readonly ISupplierMicrosectionRepository _supplierMicroSectionRepository;
        private readonly ISupplierMicroSectionActualRepository _supplierMicroSectionActualRepository;
        private readonly ISupplierVisualInspectionRepository _supplierVisualInspectionRepository;
        private readonly ISupplierVisualInspectionDefectTypeRepository _supplierVisualInspectionDefectTypeRepository;
        private readonly ISupplierFunctionAttributeActualRepository _supplierFunctionAttributeActualRepository;







        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSupplierMeasurementSubmissionCommandHandler(QSSContext context, ISupplierMeasurementSubmissionRepository repository, IMapper mapper, IFileExtensionService fileExtensionService,
            ISupplierFunctionAttributeRepository supplierFunctionAttributeRepository,
            ISupplierFunctionAttributeDefectTypeRepository supplierFunctionAttributeDefectTypeRepository,
            ISupplierSamplingPlanRepository supplierSamplingPlanRepository,
            ISupplierSapBasedParameterRepository supplierSapBasedParameterRepository,
            ISupplierSapBasedParameterDefectTypeRepository supplierSapBasedParameterDefectTypeRepository,
            ISupplierTestReportAttachmentRepository supplierTestReportAttachmentRepository,
            ISupplierBowTwistRepository SupplierBowTwistRepository,
            ISupplierBowTwistActualRepository SupplierBowTwistActualRepository,
            ISupplierMicroSectionActualRepository SupplierMicroSectionActualRepository,
            ISupplierMicrosectionRepository SupplierMicroSectionRepository,
            ISupplierVisualInspectionRepository SupplierVisualInspectionRepository,
            ISupplierVisualInspectionDefectTypeRepository SupplierVisualInspectionDefectTypeRepository,
            ISupplierFunctionAttributeActualRepository SupplierFunctionAttributeActualRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _fileExtensionService = fileExtensionService;
            _supplierFunctionAttributeRepository = supplierFunctionAttributeRepository;
            _supplierFunctionAttributeDefectTypeRepository = supplierFunctionAttributeDefectTypeRepository;
            _supplierSamplingPlanRepository = supplierSamplingPlanRepository;
            _supplierSapBasedParameterRepository = supplierSapBasedParameterRepository;
            _supplierSapBasedParameterDefectTypeRepository = supplierSapBasedParameterDefectTypeRepository;
            _supplierTestReportAttachmentRepository = supplierTestReportAttachmentRepository;
            _supplierBowTwistRepository = SupplierBowTwistRepository;
            _supplierBowTwistActualRepository = SupplierBowTwistActualRepository;
            _supplierMicroSectionRepository = SupplierMicroSectionRepository;
            _supplierMicroSectionActualRepository = SupplierMicroSectionActualRepository;
            _supplierVisualInspectionRepository = SupplierVisualInspectionRepository;
            _supplierVisualInspectionDefectTypeRepository = SupplierVisualInspectionDefectTypeRepository;
            _supplierFunctionAttributeActualRepository = SupplierFunctionAttributeActualRepository;
        }

        /// <summary>E:\Projects\EIQC\Api\QSS.eIQC\QSS.Handlers\Commands\ReceiveGoodsInfoCommand\
        /// Validates the input model and Add new SupplierMeasurementSubmission entity
        /// </summary>
        /// <param name="request">Add SupplierMeasurementSubmission model, <see cref="AddSupplierMeasurementSubmissionModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SupplierMeasurementSubmission model</returns>
        public async Task<SupplierMeasurementSubmissionModel> Handle(AddSupplierMeasurementSubmissionModel request, CancellationToken cancellationToken)
        {
            var supplierMeasurementSubmission = _mapper.Map<SupplierMeasurementSubmission>(request);

            #region Function Attribute Section
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

            #region Sap Based Section
            supplierMeasurementSubmission.SupplierSapBasedParameters.Clear();
            if (request.SupplierSapBasedParameters != null)
            {
                foreach (var supplierSapBased in request.SupplierSapBasedParameters)
                {
                    var supplierSapBasedParameter = _mapper.Map<SupplierSapBasedParameter>(supplierSapBased);

                    supplierMeasurementSubmission.SupplierSapBasedParameters.Add(supplierSapBasedParameter);

                    _supplierSapBasedParameterDefectTypeRepository.AddSupplierSapBasedParameterDefectTypes(supplierSapBasedParameter, supplierSapBased.AddedDefectTypeIds);
                }
            }
            #endregion


            await AddSupplierTestReportAttachments(request, supplierMeasurementSubmission);

            #region Supplier Bow Twist Section
            supplierMeasurementSubmission.SupplierBowTwists.Clear();

            foreach (var supplierBowTwist in request.SupplierBowTwists)
            {
                var bowTwist = _mapper.Map<SupplierBowTwist>(supplierBowTwist);

                supplierMeasurementSubmission.SupplierBowTwists.Add(bowTwist);

                  var supplierBowTiwstActual = _mapper.Map<IEnumerable<SupplierBowTwistActual>>(supplierBowTwist.SupplierBowTwistActuals);

                _supplierBowTwistActualRepository.AddSupplierBowTwistActuals(bowTwist, supplierBowTiwstActual);
            }

            #endregion

            #region Supplier Visual Inspection Section
            supplierMeasurementSubmission.SupplierVisualInspections.Clear();

            foreach (var supplierVisualInspection in request.SupplierVisualInspections)
            {
                var visualInspection = _mapper.Map<SupplierVisualInspection>(supplierVisualInspection);

                supplierMeasurementSubmission.SupplierVisualInspections.Add(visualInspection);

                _supplierVisualInspectionDefectTypeRepository.AddSupplierVisualInspectionDefectTypes(visualInspection, supplierVisualInspection.AddedDefectTypeIds);
            }

            #endregion

            #region Supplier Micro Section
            supplierMeasurementSubmission.SupplierMicrosectionParameters.Clear();


            foreach (var supplierMicroSection in request.SupplierMicrosectionParameters)
            {
                var supplierMicro = _mapper.Map<SupplierMicrosection>(supplierMicroSection);

                supplierMeasurementSubmission.SupplierMicrosectionParameters.Add(supplierMicro);


                var supplierMicroSectionActual = _mapper.Map<IEnumerable<SupplierMicroSectionActual>>(supplierMicroSection.SupplierMicroSectionActuals);


                _supplierMicroSectionActualRepository.AddSupplierMicroSectionActuals(supplierMicro, supplierMicroSectionActual);
            }

            #endregion

            await _repository.AddAsync(supplierMeasurementSubmission, request.ChangeReason);

            _context.SaveChanges();

            return new SupplierMeasurementSubmissionModel();

            // return _mapper.Map<SupplierMeasurementSubmissionModel>(supplierMeasurementSubmission);
        }


        async Task AddSupplierTestReportAttachments(AddSupplierMeasurementSubmissionModel request, SupplierMeasurementSubmission supplierMeasurementSubmission)
        {
            if (request.SupplierTestReports != null && supplierMeasurementSubmission.SupplierTestReports.Count > 0)
            {
                foreach (var supplierTestReport in request.SupplierTestReports)
                {
                    if (supplierTestReport != null && supplierTestReport.SupplierTestReportAttachments != null)
                    {
                        foreach (var partTestReportAttachment in supplierTestReport.SupplierTestReportAttachments)
                        {
                            if (partTestReportAttachment != null)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(partTestReportAttachment.Attachment.Name, partTestReportAttachment.Attachment.TempSavePath, partTestReportAttachment.Attachment.SavePath);
                            }
                        }
                    }
                }
            }
        }
    }
}
