/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormFunParaActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormFunParaActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormFunParaActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormFunParaActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormFunParaActualController(ILogger<SupplierFormFunParaActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormFunParaActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormFunParaActualModel in a body, <see cref="AddSupplierFormFunParaActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormFunParaActualModel <see cref="SupplierFormFunParaActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormFunParaActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormFunParaActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormFunParaActual configuration
        /// </summary>
        /// <param name="id">SupplierFormFunParaActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormFunParaActualModel in a body, <see cref="UpdateSupplierFormFunParaActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormFunParaActualModel <see cref="SupplierFormFunParaActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormFunParaActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormFunParaActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormFunParaActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormFunParaActualModel in a body, <see cref="DeleteSupplierFormFunParaActualModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormFunParaActualResponse <see cref="DeleteSupplierFormFunParaActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormFunParaActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormFunParaActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}