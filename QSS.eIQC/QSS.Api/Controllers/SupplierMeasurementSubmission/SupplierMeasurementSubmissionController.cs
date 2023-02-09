/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using QSS.eIQC.DataAccess.DataContext;
using System.Linq;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.ApproveReject;
using QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierMeasurementSubmission Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierMeasurementSubmissionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierMeasurementSubmissionController> _logger;

        private IQSSGatewayAPIClient _qssClient;
        private readonly IQSSContext _context;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierMeasurementSubmissionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        /// <param name="context"></param>
        public SupplierMeasurementSubmissionController(ILogger<SupplierMeasurementSubmissionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient, IQSSContext context) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
            _context = context;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierMeasurementSubmission configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierMeasurementSubmissionModel in a body, <see cref="AddSupplierMeasurementSubmissionModel"/></param>
        /// <returns>If success should return newly added SupplierMeasurementSubmissionModel <see cref="SupplierMeasurementSubmissionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierMeasurementSubmissionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierMeasurementSubmissionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierMeasurementSubmission configuration
        /// </summary>
        /// <param name="id">SupplierMeasurementSubmission Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierMeasurementSubmissionModel in a body, <see cref="UpdateSupplierMeasurementSubmissionModel"/></param>
        /// <returns>If success should return newly added SupplierMeasurementSubmissionModel <see cref="SupplierMeasurementSubmissionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierMeasurementSubmissionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierMeasurementSubmissionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierMeasurementSubmission configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierMeasurementSubmissionModel in a body, <see cref="DeleteSupplierMeasurementSubmissionModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierMeasurementSubmissionResponse <see cref="DeleteSupplierMeasurementSubmissionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierMeasurementSubmissionCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierMeasurementSubmissionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        [HttpGet("GetTotalSubmittedApprovedBatchQty")]
        public decimal GetTotalSubmittedApprovedBatchQty(int sapPartInspectionPlanId, int purchaseOrderId)
        {
            return (decimal)_context.SupplierMeasurementSubmission.Where(s => s.SAPPartInspectionPlanId == sapPartInspectionPlanId && s.PurchaseOrderId == purchaseOrderId && (s.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || s.StateTypeId == (int)StateType.Approved_By_SQE || s.StateTypeId == (int)StateType.Approved_By_DCC)).Sum(s => s.BatchQuantity);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierMeasurementSubmission configuration
        /// </summary>
        /// <param name="id">SupplierMeasurementSubmission Id as input in URL</param>
        /// <param name="request">Input parameter ApproveRejectSupplierMeasurementSubmissionPlanModel in a body, <see cref="ApproveRejectSupplierMeasurementSubmissionPlanModel"/></param>
        /// <returns>If success should return newly added SupplierMeasurementSubmissionModel <see cref="SupplierMeasurementSubmissionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("ApproveReject/{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierMeasurementSubmissionCanUpdate))]
        public async Task<IActionResult> ApproveReject(int id, [FromBody] ApproveRejectSupplierMeasurementSubmissionPlanModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }
            return await ExecuteMediatrRequest(request);
        }

    }
}