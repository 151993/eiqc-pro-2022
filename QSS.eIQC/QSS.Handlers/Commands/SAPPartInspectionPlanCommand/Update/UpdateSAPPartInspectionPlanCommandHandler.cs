/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Services.FileService;
using QSS.eIQC.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static QSS.eIQC.Handlers.Common.Constants;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update
{
    /// <summary>
    /// Command Handler for Update SAPPartInspectionPlan operation
    /// </summary>
    public class UpdateSAPPartInspectionPlanCommandHandler : IRequestHandler<UpdateSAPPartInspectionPlanModel, SAPPartInspectionPlanModel>
    {
        private readonly QSSContext _context;
        private readonly ISAPPartInspectionPlanRepository _repository;
        private readonly IMapper _mapper;
        private readonly ISAPPartInspectionPlanSupplierRepository _sapPartInspectionPlanSupplierRepository;
        private readonly IPartInspectionDrawingAttachmentRepository _partInspectionDrawingAttachmentRepository;
        private readonly IPartInspectionSpecAttachmentRepository _partInspectionSpecAttachmentRepository;
        private readonly ISAPPartInspectionPlanAdminCertificationRepository _sapPartInspectionPlanAdminCertificationRepository;
        private readonly IFileExtensionService _fileExtensionService;
        private readonly IPartInspectionCertificationAttachmentRepository _sapPartInspectionPlanCertificationAttachmentRepository;
        private readonly IPartMPositionToleranceRepository _partMPositionToleranceRepository;
        private readonly IPartLPositionToleranceRepository _partLPositionToleranceRepository;
        private readonly IPartMeasurementParameterRepository _partMeasurementParameterRepository;
        private readonly IPartMicrosectionRepository _partMicrosectionRepository;
        private readonly IPartFunParameterRepository _partFunParameterRepository;
        private readonly IPartResultOrientedParameterRepository _partResultOrientedParameterRepository;
        private readonly IPartInspectionBowTwistParameterRepository _partInspectionBowTwistParameterRepository;
        private readonly IPartTestReportParameterRepository _partTestReportParameterRepository;
        private readonly IPartTestReportAttachmentRepository _partTestReportAttachmentRepository;
        private readonly IPartDateCodeRepository _partDateCodeRepository;
        private readonly IPartCountParameterRepository _partCountParameterRepository;
        private readonly IPartInspectionSpecificationRepository _partInspectionSpecificationRepository;
        private readonly IPartInspectionDrawingRepository _partInspectionDrawingRepository;
        private readonly ISAPPartInspectionPlanSamplingPlanRepository _partInspectionPlanSamplingPlanRepository;


        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of QSSContext on runtime, <see cref="QSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public UpdateSAPPartInspectionPlanCommandHandler(QSSContext context, ISAPPartInspectionPlanRepository sAPPartInspectionPlanRepository, IMapper mapper,
            ISAPPartInspectionPlanSupplierRepository sapPartInspectionPlanSupplierRepository, ISAPPartInspectionPlanAdminCertificationRepository sapPartInspectionPlanAdminCertificationRepository
            , IPartInspectionDrawingAttachmentRepository partInspectionDrawingAttachmentRepository, IPartInspectionSpecAttachmentRepository partInspectionSpecAttachmentRepository
            , IFileExtensionService fileExtensionService, IPartInspectionCertificationAttachmentRepository sapPartInspectionPlanCertificationAttachmentRepository
            , IPartMPositionToleranceRepository partMPositionToleranceRepository
            , IPartLPositionToleranceRepository partLPositionToleranceRepository, IPartMeasurementParameterRepository partMeasurementParameterRepository
            , IPartMicrosectionRepository partMicrosectionRepository, IPartFunParameterRepository partFunParameterRepository
            , IPartResultOrientedParameterRepository partResultOrientedParameterRepository, IPartInspectionBowTwistParameterRepository partInspectionBowTwistParameterRepository
            , IPartTestReportParameterRepository partTestReportParameterRepository, IPartTestReportAttachmentRepository partTestReportAttachmentRepository, IPartDateCodeRepository partDateCodeRepository
            , IPartCountParameterRepository partCountParameterRepository, IPartInspectionSpecificationRepository partInspectionSpecificationRepository,
            IPartInspectionDrawingRepository partInspectionDrawingRepository, ISAPPartInspectionPlanSamplingPlanRepository partInspectionPlanSamplingPlanRepository)
        {
            _context = context;
            _repository = sAPPartInspectionPlanRepository;
            _mapper = mapper;
            _sapPartInspectionPlanSupplierRepository = sapPartInspectionPlanSupplierRepository;
            _sapPartInspectionPlanAdminCertificationRepository = sapPartInspectionPlanAdminCertificationRepository;
            _partInspectionDrawingAttachmentRepository = partInspectionDrawingAttachmentRepository;
            _partInspectionSpecAttachmentRepository = partInspectionSpecAttachmentRepository;
            _sapPartInspectionPlanCertificationAttachmentRepository = sapPartInspectionPlanCertificationAttachmentRepository;
            _fileExtensionService = fileExtensionService;
            _partMPositionToleranceRepository = partMPositionToleranceRepository;
            _partLPositionToleranceRepository = partLPositionToleranceRepository;
            _partMeasurementParameterRepository = partMeasurementParameterRepository;
            _partMicrosectionRepository = partMicrosectionRepository;
            _partFunParameterRepository = partFunParameterRepository;
            _partResultOrientedParameterRepository = partResultOrientedParameterRepository;
            _partInspectionBowTwistParameterRepository = partInspectionBowTwistParameterRepository;
            _partTestReportParameterRepository = partTestReportParameterRepository;
            _partTestReportAttachmentRepository = partTestReportAttachmentRepository;
            _partDateCodeRepository = partDateCodeRepository;
            _partCountParameterRepository = partCountParameterRepository;
            _partInspectionSpecificationRepository = partInspectionSpecificationRepository;
            _partInspectionDrawingRepository = partInspectionDrawingRepository;
            _partInspectionPlanSamplingPlanRepository = partInspectionPlanSamplingPlanRepository;
        }

        /// <summary>
        /// Validates the input model and Update SAPPartInspectionPlan entity
        /// </summary>
        /// <param name="request">Input Update SAPPartInspectionPlan model, <see cref="UpdateSAPPartInspectionPlanModel"/></param>
        /// <param name="cancellationToken">Cancellation token to cancel and abort the operation, <see cref="CancellationToken"/></param>
        /// <returns>Updated SAPPartInspectionPlan model</returns>
        public async Task<SAPPartInspectionPlanModel> Handle(UpdateSAPPartInspectionPlanModel request, CancellationToken cancellationToken)
        {
            ValidateIPForExistance(request);

            var sAPPartInspectionPlanNew = _mapper.Map<SAPPartInspectionPlan>(request);

            await SaveRedefineHistory(request, sAPPartInspectionPlanNew);

            var sAPPartInspectionPlan = _context.SAPPartInspectionPlan.FirstOrDefault(x => x.IP == request.IP);

            if (request.IsRedefine)
            {
                sAPPartInspectionPlan.PartLPositionTolerances = new List<PartLPositionTolerance>();
                sAPPartInspectionPlan.PartMPositionTolerances = new List<PartMPositionTolerance>();
                sAPPartInspectionPlan.PartMeasurementParameters = new List<PartMeasurementParameter>();
                sAPPartInspectionPlan.PartMicrosectionParameters = new List<PartMicrosection>();
                sAPPartInspectionPlan.PartFunParameters = new List<PartFunParameter>();
                sAPPartInspectionPlan.PartResultOrientedParameters = new List<PartResultOrientedParameter>();
                sAPPartInspectionPlan.PartCountParameters = new List<PartCountParameter>();
                sAPPartInspectionPlan.PartInspectionBowTwistParameters = new List<PartInspectionBowTwistParameter>();
                sAPPartInspectionPlan.SAPPartInspectionPlanSamplingPlans = new List<SAPPartInspectionPlanSamplingPlan>();
            }

            if (request.SAPPartInspectionPlanSamplingPlans != null && !request.IsRedefine)
            {
                List<int> samplingPlanIds = request.SAPPartInspectionPlanSamplingPlans.Select(k => k.Id).ToList();

                await _partInspectionPlanSamplingPlanRepository.RemoveSAPPartInspectionPlanSamplingPlans(request.Id, samplingPlanIds);
            }

            if (request.PartMPositionTolerances != null && !request.IsRedefine)
            {
                _partMPositionToleranceRepository.RemoveRange(sAPPartInspectionPlan);
            }

            if (request.PartLPositionTolerances != null && !request.IsRedefine)
            {
                _partLPositionToleranceRepository.RemoveRange(sAPPartInspectionPlan);
            }

            if (request.PartMeasurementParameters != null && !request.IsRedefine)
            {
                _partMeasurementParameterRepository.RemoveRange(sAPPartInspectionPlan);
            }

            if (request.PartMicrosectionParameters != null && !request.IsRedefine)
            {
                _partMicrosectionRepository.RemoveRange(sAPPartInspectionPlan);
            }

            if (request.PartFunParameters != null && !request.IsRedefine)
            {
                _partFunParameterRepository.RemoveRange(sAPPartInspectionPlan);
            }

            if (request.PartResultOrientedParameters != null && !request.IsRedefine)
            {
                _partResultOrientedParameterRepository.RemoveRange(sAPPartInspectionPlan);
            }

            _partInspectionBowTwistParameterRepository.RemoveRange(sAPPartInspectionPlan);

            if (request.PartCountParameters != null && !request.IsRedefine)
            {
                _partCountParameterRepository.RemoveRange(sAPPartInspectionPlan);
            }

            UpdatePartTestReportParametersAttachments(request, sAPPartInspectionPlan);

            UpdateDrawingAttachments(request, sAPPartInspectionPlan);

            UpdateSpecAttachments(request, sAPPartInspectionPlan);

            UpdateCertificationAttachments(request, sAPPartInspectionPlan);

            _partDateCodeRepository.RemoveRange(sAPPartInspectionPlan);

            await _sapPartInspectionPlanSupplierRepository.AddSAPPartInspectionPlanSuppliers(sAPPartInspectionPlan, request.AddedSupplierIds);

            await _sapPartInspectionPlanSupplierRepository.RemoveSAPPartInspectionPlanSuppliers(sAPPartInspectionPlan.Id, request.RemovedSupplierIds);

            await _sapPartInspectionPlanAdminCertificationRepository.AddSAPPartInspectionPlanAdminCertifications(sAPPartInspectionPlan, request.AddedAdminCertificateIds);

            await _sapPartInspectionPlanAdminCertificationRepository.RemoveSAPPartInspectionPlanAdminCertifications(sAPPartInspectionPlan.Id, request.RemovedAdminCertificateIds);

            if (request.IsRedefine && sAPPartInspectionPlan.ReferenceSAPPartInspectionPlanId != null)
            {
                sAPPartInspectionPlan.Status = StatusType.Inactive;
                sAPPartInspectionPlan.StateTypeId = (int)StateType.Redefined_By_SQE;
            }

            await _repository.UpdateAsync(sAPPartInspectionPlan, request.ChangeReason);

            _context.SaveChanges();

            return new SAPPartInspectionPlanModel();

            // return _mapper.Map<SAPPartInspectionPlanModel>(sAPPartInspectionPlan);
        }

        private void ValidateIPForExistance(UpdateSAPPartInspectionPlanModel request)
        {
                List<SAPPartInspectionPlan> existingPartNoIP = _context.SAPPartInspectionPlan
                           .Where(k => k.PartNo == request.PartNo && k.Id != request.Id && !string.IsNullOrEmpty(request.ManufacturePartNumber) &&
                           k.ManufacturePartNumber == request.ManufacturePartNumber && k.ReferenceSAPPartInspectionPlanId==null).ToList();
                if (existingPartNoIP.Count > 0)
                {
                    throw new Exception(CustomValidationErrors.IPAlreadyExists);
                }
        } 
        
        private async Task SaveRedefineHistory(UpdateSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            if (request.IsRedefine && sAPPartInspectionPlan.ReferenceSAPPartInspectionPlanId != null)
            {
                sAPPartInspectionPlan.Id = 0;
                SAPPartInspectionPlan redefinedSAPPartInspectionPlan = sAPPartInspectionPlan.DeepCopy();

                redefinedSAPPartInspectionPlan.Status = StatusType.Active;
                redefinedSAPPartInspectionPlan.StateTypeId = (int)StateType.New_Inspection_Plan_Submission_Required_By_Supplier;
                if (redefinedSAPPartInspectionPlan.SAPPartInspectionPlanSamplingPlans!=null)
                {
                    redefinedSAPPartInspectionPlan.SAPPartInspectionPlanSamplingPlans.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.SAPPartInspectionPlanSamplingPlans.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.SAPPartInspectionPlanAdminCertifications != null)
                {
                    redefinedSAPPartInspectionPlan.SAPPartInspectionPlanAdminCertifications.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.SAPPartInspectionPlanAdminCertifications.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartInspectionCertificationAttachments != null)
                {
                    redefinedSAPPartInspectionPlan.PartInspectionCertificationAttachments.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartInspectionCertificationAttachments.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartInspectionDrawings != null)
                {
                    redefinedSAPPartInspectionPlan.PartInspectionDrawings.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartInspectionDrawings.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartInspectionSpecifications != null)
                {
                    redefinedSAPPartInspectionPlan.PartInspectionSpecifications.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartInspectionSpecifications.ToList().ForEach(k => k.Id = 0);
                }
              

                if (redefinedSAPPartInspectionPlan.PartComments != null)
                {
                   
                    redefinedSAPPartInspectionPlan.PartComments.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartComments.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.SAPPartInspectionPlanSuppliers != null)
                {
                    redefinedSAPPartInspectionPlan.SAPPartInspectionPlanSuppliers.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.SAPPartInspectionPlanSuppliers.ToList().ForEach(k => k.Id = 0);
                }

                redefinedSAPPartInspectionPlan.PartDateCode.Id = 0;

                if (redefinedSAPPartInspectionPlan.PartMeasurementParameters != null)
                {
                    redefinedSAPPartInspectionPlan.PartMeasurementParameters.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartMeasurementParameters.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartResultOrientedParameters != null)
                {
                    redefinedSAPPartInspectionPlan.PartResultOrientedParameters.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartResultOrientedParameters.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartFunParameters != null)
                {
                    redefinedSAPPartInspectionPlan.PartFunParameters.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartFunParameters.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartMicrosectionParameters != null)
                {
                    redefinedSAPPartInspectionPlan.PartMicrosectionParameters.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartMicrosectionParameters.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartInspectionBowTwistParameters != null)
                {
                    redefinedSAPPartInspectionPlan.PartInspectionBowTwistParameters.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartInspectionBowTwistParameters.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartMPositionTolerances != null)
                {
                    redefinedSAPPartInspectionPlan.PartMPositionTolerances.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartMPositionTolerances.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartLPositionTolerances != null)
                {
                    redefinedSAPPartInspectionPlan.PartLPositionTolerances.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartLPositionTolerances.ToList().ForEach(k => k.Id = 0);
                }

                if (redefinedSAPPartInspectionPlan.PartTestReportParameters != null)
                {
                    redefinedSAPPartInspectionPlan.PartTestReportParameters.ToList().ForEach(k => k.SAPPartInspectionPlanId = 0);
                    redefinedSAPPartInspectionPlan.PartTestReportParameters.ToList().ForEach(k => k.Id = 0);
                }             

                await _repository.AddAsync(redefinedSAPPartInspectionPlan, request.ChangeReason,request.IsRedefine);
            }
        }

        void UpdateCertificationAttachments(UpdateSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            _sapPartInspectionPlanCertificationAttachmentRepository.RemoveRange(sAPPartInspectionPlan.Id, request.RemovedCertificationAttachmentIds);

            if (request.PartInspectionCertificationAttachments != null)
            {
                foreach (var file in request.PartInspectionCertificationAttachments)
                {
                    _fileExtensionService.MoveFileToPermanentStorage(file.Attachment.Name, file.Attachment.TempSavePath, file.Attachment.SavePath);
                }
            }
        }

        void UpdateSpecAttachments(UpdateSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            _partInspectionSpecificationRepository.RemoveRange(sAPPartInspectionPlan);

            if (request.PartInspectionSpecifications != null)
            {
                foreach (var inspectionSpecification in request.PartInspectionSpecifications)
                {
                    if (inspectionSpecification != null && inspectionSpecification.PartInspectionSpecAttachments != null)
                    {
                        _partInspectionSpecAttachmentRepository.RemoveRange(inspectionSpecification.Id, inspectionSpecification.RemovedSpecAttachmentIds);

                        foreach (var partInspectionSpecAttachment in inspectionSpecification.PartInspectionSpecAttachments)
                        {
                            if (partInspectionSpecAttachment != null && partInspectionSpecAttachment.Attachment != null && partInspectionSpecAttachment.Attachment.Id == 0)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(partInspectionSpecAttachment.Attachment.Name, partInspectionSpecAttachment.Attachment.TempSavePath, partInspectionSpecAttachment.Attachment.SavePath);
                            }
                        }
                    }
                }
            }
        }


        void UpdateDrawingAttachments(UpdateSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            _partInspectionDrawingRepository.RemoveRange(sAPPartInspectionPlan);

            if (request.PartInspectionDrawings != null)
            {
                foreach (var inspectionDrawing in request.PartInspectionDrawings)
                {
                    if (inspectionDrawing != null && inspectionDrawing.PartInspectionDrawingAttachments != null)
                    {
                        _partInspectionDrawingAttachmentRepository.RemoveRange(inspectionDrawing.Id, inspectionDrawing.RemovedDrawingAttachmentIds);

                        foreach (var partInspectionDrawingAttachment in inspectionDrawing.PartInspectionDrawingAttachments)
                        {
                            if (partInspectionDrawingAttachment != null && partInspectionDrawingAttachment.Attachment != null && partInspectionDrawingAttachment.Attachment.Id == 0)
                            {
                                _fileExtensionService.MoveFileToPermanentStorage(partInspectionDrawingAttachment.Attachment.Name, partInspectionDrawingAttachment.Attachment.TempSavePath, partInspectionDrawingAttachment.Attachment.SavePath);
                            }
                        }
                    }
                }
            }
        }

        void UpdatePartTestReportParametersAttachments(UpdateSAPPartInspectionPlanModel request, SAPPartInspectionPlan sAPPartInspectionPlan)
        {
            _partTestReportParameterRepository.RemoveRange(sAPPartInspectionPlan);

            if (request.PartTestReportParameters != null)
            {
                foreach (var testReportParameter in request.PartTestReportParameters)
                {
                    if (testReportParameter != null && testReportParameter.PartTestReportAttachments != null)
                    {
                        _partTestReportAttachmentRepository.RemoveRange(testReportParameter.Id, testReportParameter.RemovedTestReportAttachmentIds);

                        foreach (var partTestReportAttachment in testReportParameter.PartTestReportAttachments)
                        {
                            if (partTestReportAttachment != null && partTestReportAttachment.Attachment != null && partTestReportAttachment.Attachment.Id == 0)
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
