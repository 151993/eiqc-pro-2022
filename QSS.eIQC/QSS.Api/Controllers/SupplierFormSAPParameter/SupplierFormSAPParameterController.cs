/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormSAPParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormSAPParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormSAPParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormSAPParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormSAPParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormSAPParameterController(ILogger<SupplierFormSAPParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormSAPParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormSAPParameterModel in a body, <see cref="AddSupplierFormSAPParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormSAPParameterModel <see cref="SupplierFormSAPParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormSAPParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormSAPParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormSAPParameter configuration
        /// </summary>
        /// <param name="id">SupplierFormSAPParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormSAPParameterModel in a body, <see cref="UpdateSupplierFormSAPParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormSAPParameterModel <see cref="SupplierFormSAPParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormSAPParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormSAPParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormSAPParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormSAPParameterModel in a body, <see cref="DeleteSupplierFormSAPParameterModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormSAPParameterResponse <see cref="DeleteSupplierFormSAPParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormSAPParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormSAPParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}