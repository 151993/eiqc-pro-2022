/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Delete;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject;
using QSS.eIQC.Api.Security;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SAPPartInspectionPlan Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SAPPartInspectionPlanController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SAPPartInspectionPlanController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SAPPartInspectionPlanController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SAPPartInspectionPlanController(ILogger<SAPPartInspectionPlanController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SAPPartInspectionPlan configuration
        /// </summary>
        /// <param name="request">Input parameter AddSAPPartInspectionPlanModel in a body, <see cref="AddSAPPartInspectionPlanModel"/></param>
        /// <returns>If success should return newly added SAPPartInspectionPlanModel <see cref="SAPPartInspectionPlanModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [MultiplePoliciesAuthorize(policies: "AdminSAPPartInspectionPlanCanUpdate;AdminSupplierTaskCanUpdate;AdminDCCTaskCanUpdate;AdminSQETaskCanUpdate")]
        public async Task<IActionResult> Add([FromBody] AddSAPPartInspectionPlanModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SAPPartInspectionPlan configuration
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSAPPartInspectionPlanModel in a body, <see cref="UpdateSAPPartInspectionPlanModel"/></param>
        /// <returns>If success should return newly added SAPPartInspectionPlanModel <see cref="SAPPartInspectionPlanModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [MultiplePoliciesAuthorize(policies: "AdminSAPPartInspectionPlanCanUpdate;AdminSupplierTaskCanUpdate;AdminDCCTaskCanUpdate;AdminSQETaskCanUpdate")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSAPPartInspectionPlanModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SAPPartInspectionPlan configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSAPPartInspectionPlanModel in a body, <see cref="DeleteSAPPartInspectionPlanModel"/></param>
        /// <returns>If success should return newly added DeleteSAPPartInspectionPlanResponse <see cref="DeleteSAPPartInspectionPlanResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [MultiplePoliciesAuthorize(policies: "AdminSAPPartInspectionPlanCanUpdate;AdminSupplierTaskCanUpdate;AdminDCCTaskCanUpdate;AdminSQETaskCanUpdate")]
        public async Task<IActionResult> Delete(DeleteSAPPartInspectionPlanModel request)
        {
            return await ExecuteMediatrRequest(request);
        }


        /// <summary>
        /// Async PUT Action method to update SAPPartInspectionPlan configuration
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id as input in URL</param>
        /// <param name="request">Input parameter ApproveRejectSAPPartInspectionPlanModel in a body, <see cref="ApproveRejectSAPPartInspectionPlanModel"/></param>
        /// <returns>If success should return newly added SAPPartInspectionPlanModel <see cref="SAPPartInspectionPlanModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("ApproveReject/{id}")]
        [MultiplePoliciesAuthorize(policies: "AdminSAPPartInspectionPlanCanUpdate;AdminSupplierTaskCanUpdate;AdminDCCTaskCanUpdate;AdminSQETaskCanUpdate")]
        public async Task<IActionResult> ApproveReject(int id, [FromBody] ApproveRejectSAPPartInspectionPlanModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SAPPartInspectionPlan configuration assigned user
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id as input in URL</param>
        /// <param name="request">Input parameter AssignReassignToUserSAPPartInspectionPlanModel in a body, <see cref="AssignReassignSAPPartInspectionPlanToUserModel"/></param>
        /// <returns>If success should return newly added SAPPartInspectionPlanModel <see cref="SAPPartInspectionPlanModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("AssignReassign/{id}")]
        [MultiplePoliciesAuthorize(policies: "AdminSAPPartInspectionPlanCanUpdate;AdminSupplierTaskCanUpdate;AdminDCCTaskCanUpdate;AdminSQETaskCanUpdate")]
        public async Task<IActionResult> AssignReassign(int id, [FromBody] AssignReassignSAPPartInspectionPlanToUserModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }
    }
}