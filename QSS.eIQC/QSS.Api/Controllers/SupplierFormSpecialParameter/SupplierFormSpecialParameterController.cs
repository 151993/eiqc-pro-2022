/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormSpecialParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormSpecialParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormSpecialParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormSpecialParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormSpecialParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormSpecialParameterController(ILogger<SupplierFormSpecialParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormSpecialParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormSpecialParameterModel in a body, <see cref="AddSupplierFormSpecialParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormSpecialParameterModel <see cref="SupplierFormSpecialParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormSpecialParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormSpecialParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormSpecialParameter configuration
        /// </summary>
        /// <param name="id">SupplierFormSpecialParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormSpecialParameterModel in a body, <see cref="UpdateSupplierFormSpecialParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormSpecialParameterModel <see cref="SupplierFormSpecialParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormSpecialParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormSpecialParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormSpecialParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormSpecialParameterModel in a body, <see cref="DeleteSupplierFormSpecialParameterModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormSpecialParameterResponse <see cref="DeleteSupplierFormSpecialParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormSpecialParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormSpecialParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}