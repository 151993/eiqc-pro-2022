/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormPartDateCodeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormPartDateCode Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormPartDateCodeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormPartDateCodeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormPartDateCodeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormPartDateCodeController(ILogger<SupplierFormPartDateCodeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormPartDateCode configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormPartDateCodeModel in a body, <see cref="AddSupplierFormPartDateCodeModel"/></param>
        /// <returns>If success should return newly added SupplierFormPartDateCodeModel <see cref="SupplierFormPartDateCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormPartDateCodeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormPartDateCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormPartDateCode configuration
        /// </summary>
        /// <param name="id">SupplierFormPartDateCode Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormPartDateCodeModel in a body, <see cref="UpdateSupplierFormPartDateCodeModel"/></param>
        /// <returns>If success should return newly added SupplierFormPartDateCodeModel <see cref="SupplierFormPartDateCodeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormPartDateCodeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormPartDateCodeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormPartDateCode configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormPartDateCodeModel in a body, <see cref="DeleteSupplierFormPartDateCodeModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormPartDateCodeResponse <see cref="DeleteSupplierFormPartDateCodeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormPartDateCodeCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormPartDateCodeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}