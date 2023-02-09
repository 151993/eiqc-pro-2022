/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormPackaging Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormPackagingController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormPackagingController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormPackagingController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormPackagingController(ILogger<SupplierFormPackagingController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormPackaging configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormPackagingModel in a body, <see cref="AddSupplierFormPackagingModel"/></param>
        /// <returns>If success should return newly added SupplierFormPackagingModel <see cref="SupplierFormPackagingModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormPackagingCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormPackagingModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormPackaging configuration
        /// </summary>
        /// <param name="id">SupplierFormPackaging Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormPackagingModel in a body, <see cref="UpdateSupplierFormPackagingModel"/></param>
        /// <returns>If success should return newly added SupplierFormPackagingModel <see cref="SupplierFormPackagingModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormPackagingCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormPackagingModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormPackaging configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormPackagingModel in a body, <see cref="DeleteSupplierFormPackagingModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormPackagingResponse <see cref="DeleteSupplierFormPackagingResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormPackagingCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormPackagingModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}