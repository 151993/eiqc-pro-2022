/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormResultOrientedParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormResultOrientedParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormResultOrientedParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormResultOrientedParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormResultOrientedParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormResultOrientedParameterController(ILogger<SupplierFormResultOrientedParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormResultOrientedParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormResultOrientedParameterModel in a body, <see cref="AddSupplierFormResultOrientedParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormResultOrientedParameterModel <see cref="SupplierFormResultOrientedParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormResultOrientedParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormResultOrientedParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormResultOrientedParameter configuration
        /// </summary>
        /// <param name="id">SupplierFormResultOrientedParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormResultOrientedParameterModel in a body, <see cref="UpdateSupplierFormResultOrientedParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormResultOrientedParameterModel <see cref="SupplierFormResultOrientedParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormResultOrientedParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormResultOrientedParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormResultOrientedParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormResultOrientedParameterModel in a body, <see cref="DeleteSupplierFormResultOrientedParameterModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormResultOrientedParameterResponse <see cref="DeleteSupplierFormResultOrientedParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormResultOrientedParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormResultOrientedParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}