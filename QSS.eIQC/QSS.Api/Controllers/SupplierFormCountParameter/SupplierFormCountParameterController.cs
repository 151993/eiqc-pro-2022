/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormCountParameterCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormCountParameter Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormCountParameterController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormCountParameterController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormCountParameterController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormCountParameterController(ILogger<SupplierFormCountParameterController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormCountParameter configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormCountParameterModel in a body, <see cref="AddSupplierFormCountParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormCountParameterModel <see cref="SupplierFormCountParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormCountParameterCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormCountParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormCountParameter configuration
        /// </summary>
        /// <param name="id">SupplierFormCountParameter Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormCountParameterModel in a body, <see cref="UpdateSupplierFormCountParameterModel"/></param>
        /// <returns>If success should return newly added SupplierFormCountParameterModel <see cref="SupplierFormCountParameterModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormCountParameterCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormCountParameterModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormCountParameter configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormCountParameterModel in a body, <see cref="DeleteSupplierFormCountParameterModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormCountParameterResponse <see cref="DeleteSupplierFormCountParameterResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormCountParameterCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormCountParameterModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}