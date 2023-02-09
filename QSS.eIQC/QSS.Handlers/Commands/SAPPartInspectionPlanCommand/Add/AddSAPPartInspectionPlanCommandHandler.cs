/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using FluentValidation;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add
{
    /// <summary>
    /// Command Handler for Add SAPPartInspectionPlan operation
    /// </summary>
    public class AddSAPPartInspectionPlanCommandHandler : IRequestHandler<AddSAPPartInspectionPlanModel, SAPPartInspectionPlanModel>
    {
        private readonly QSSContext _context;
        private readonly ISAPPartInspectionPlanRepository _repository;
        private readonly IMapper _mapper;
        private readonly ISAPPartInspectionPlanSupplierRepository _sapPartInspectionPlanSupplierRepository;
        private readonly IPartInspectionDrawingAttachmentRepository _partInspectionDrawingAttachmentRepository;
        private readonly IPartInspectionSpecAttachmentRepository _partInspectionSpecAttachmentRepository;
        private readonly ISAPPartInspectionPlanAdminCertificationRepository _sapPartInspectionPlanAdminCertificationRepository;
        private readonly IPartInspectionCertificationAttachmentRepository _sapPartInspectionPlanCertificationAttachmentRepository;
        private readonly IPartTestReportAttachmentRepository _partTestReportAttachmentRepository;


        private readonly IFileExtensionService _fileExtensionService;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AddSAPPartInspectionPlanCommandHandler(QSSContext context, ISAPPartInspectionPlanRepository repository, IMapper mapper,
            ISAPPartInspectionPlanSupplierRepository sapPartInspectionPlanSupplierRepository,
            IPartInspectionDrawingAttachmentRepository partInspectionDrawingAttachmentRepository, IPartInspectionSpecAttachmentRepository partInspectionSpecAttachmentRepository,
            ISAPPartInspectionPlanAdminCertificationRepository sapPartInspectionPlanAdminCertificationRepository, IFileExtensionService fileExtensionService,
            IPartInspectionCertificationAttachmentRepository sapPartInspectionPlanCertificationAttachmentRepository,
            IPartTestReportAttachmentRepository partTestReportAttachmentRepository)
        {
            _context = context;
            _repository = repository;
            _mapper = mapper;
            _sapPartInspectionPlanSupplierRepository = sapPartInspectionPlanSupplierRepository;
            _partInspectionDrawingAttachmentRepository = partInspectionDrawingAttachmentRepository;
            _partInspectionSpecAttachmentRepository = partInspectionSpecAttachmentRepository;
            _sapPartInspectionPlanAdminCertificationRepository = sapPartInspectionPlanAdminCertificationRepository;
            _sapPartInspectionPlanCertificationAttachmentRepository = sapPartInspectionPlanCertificationAttachmentRepository;
            _partTestReportAttachmentRepository = partTestReportAttachmentRepository;
            _fileExtensionService = fileExtensionService;
        }

        /// <summary>
        /// Validates the input model and Add new SAPPartInspectionPlan entity
        /// </summary>
        /// <param name="request">Add SAPPartInspectionPlan model, <see cref="AddSAPPartInspectionPlanModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Newly added SAPPartInspectionPlan model</returns>
        public async Task<SAPPartInspectionPlanModel> Handle(AddSAPPartInspectionPlanModel request, CancellationToken cancellationToken)
        {
            ValidateIPForExistance(request);

            var sAPPartInspectionPlan = _mapper.Map<SAPPartInspectionPlan>(request);

            await AddDrawingAttachments(request, sAPPartInspectionPlan);

            await AddTestReportAttachments(request, sAPPartInspectionPlan);

            await AddSpecAttachments(request, sAPPartInspectionPlan);

            await AddCertificationAttachments(request, sAPPartInspectionPlan);

            await _sapPartInspectionPlanAdminCertificationRepository.AddSAPPartInspectionPlanAdminCertifications(sAPPartInspectionPlan, request.AddedAdminCertificateIds);

            await _repository.AddAsync(sAPPartInspectionPlan, request.ChangeReason, false);

            _context.SaveChanges();

            return new SAPPartInspectionPlanModel();
            // return _mapper.Map<SAPPartInspectionPlanModel>(sAPPartInspectionPlan);
        }

        private void ValidateIPForExistance(AddSAPPartInspectionPlanModel request)
        {
            List<SAPPartInspectionPlan> existingPartNoIP = _context.SAPPartInspectionPlan
                         .Where(k => k.PartNo == request.PartNo  &&
                         k.ManufacturePartNumber ==request.ManufacturePartNumber && k.ReferenceSAPPartInspectionPlanId == null).ToList();
            if (existingPartNoIP.Count > 0)
            {
                throw new Exception(CustomValidationErrors.IPAlreadyExists);
            }
        }

        async Task AddCertificationAttachments(AddSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            var uploadCertificationAttachments = _mapper.Map<IEnumerable<Attachment>>(request.UploadCertificationAttachments);

            await _sapPartInspectionPlanCertificationAttachmentRepository.AddPartInspectionCertificationAttachments(sAPPartInspectionPlan, uploadCertificationAttachments, request.ChangeReason);

            if (request.UploadCertificationAttachments != null)
            {
                foreach (var file in request.UploadCertificationAttachments)
                {
                    _fileExtensionService.MoveFileToPermanentStorage(file.Name, file.TempSavePath, file.SavePath);
                }
            }
        }

        async Task AddSpecAttachments(AddSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (request.PartInspectionSpecifications != null && sAPPartInspectionPlan.PartInspectionSpecifications.Count > 0)
            {
                sAPPartInspectionPlan.PartInspectionSpecifications.Clear();

                foreach (var inspectionSpecification in request.PartInspectionSpecifications)
                {
                    var partInspectionSpecification = _mapper.Map<PartInspectionSpecification>(inspectionSpecification);

                    sAPPartInspectionPlan.PartInspectionSpecifications.Add(partInspectionSpecification);

                    if (inspectionSpecification != null && inspectionSpecification.SpecAttachments != null)
                    {
                        var specAttachments = _mapper.Map<IEnumerable<Attachment>>(inspectionSpecification.SpecAttachments);

                        await _partInspectionSpecAttachmentRepository.AddPartInspectionSpecAttachments(partInspectionSpecification, specAttachments, request.ChangeReason);

                        foreach (var partSpecAttachment in inspectionSpecification.SpecAttachments)
                        {
                            if (partSpecAttachment != null)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(partSpecAttachment.Name, partSpecAttachment.TempSavePath, partSpecAttachment.SavePath);
                            }
                        }
                    }
                }
            }
        }

        async Task AddDrawingAttachments(AddSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (request.PartInspectionDrawings != null && sAPPartInspectionPlan.PartInspectionDrawings.Count > 0)
            {
                sAPPartInspectionPlan.PartInspectionDrawings.Clear();

                foreach (var inspectionDrawing in request.PartInspectionDrawings)
                {
                    var partInspectionDrawing = _mapper.Map<PartInspectionDrawing>(inspectionDrawing);

                    sAPPartInspectionPlan.PartInspectionDrawings.Add(partInspectionDrawing);

                    if (inspectionDrawing != null && inspectionDrawing.DrawingAttachments != null)
                    {
                        var drawingAttachments = _mapper.Map<IEnumerable<Attachment>>(inspectionDrawing.DrawingAttachments);

                        await _partInspectionDrawingAttachmentRepository.AddPartInspectionDrawingAttachments(partInspectionDrawing, drawingAttachments, request.ChangeReason);

                        foreach (var partDrawingAttachment in inspectionDrawing.DrawingAttachments)
                        {
                            if (partDrawingAttachment != null)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(partDrawingAttachment.Name, partDrawingAttachment.TempSavePath, partDrawingAttachment.SavePath);
                            }
                        }
                    }
                }
            }
        }

        async Task AddTestReportAttachments(AddSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (request.PartTestReportParameters != null && sAPPartInspectionPlan.PartTestReportParameters.Count > 0)
            {
                sAPPartInspectionPlan.PartTestReportParameters.Clear();

                foreach (var testReportParameter in request.PartTestReportParameters)
                {
                    var partTestReportParameter = _mapper.Map<PartTestReportParameter>(testReportParameter);

                    sAPPartInspectionPlan.PartTestReportParameters.Add(partTestReportParameter);

                    if (testReportParameter != null && testReportParameter.TestReportAttachments != null)
                    {
                        var testReportAttachments = _mapper.Map<IEnumerable<Attachment>>(testReportParameter.TestReportAttachments);

                        await _partTestReportAttachmentRepository.AddPartTestReportAttachments(partTestReportParameter, testReportAttachments, request.ChangeReason);

                        foreach (var partTestReportAttachment in testReportParameter.TestReportAttachments)
                        {
                            if (partTestReportAttachment != null)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(partTestReportAttachment.Name, partTestReportAttachment.TempSavePath, partTestReportAttachment.SavePath);
                            }
                        }
                    }
                }
            }
        }
    }
}
