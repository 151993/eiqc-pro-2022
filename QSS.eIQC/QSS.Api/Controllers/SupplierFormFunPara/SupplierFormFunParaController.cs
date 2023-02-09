/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormFunParaCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormFunPara Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormFunParaController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormFunParaController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormFunParaController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormFunParaController(ILogger<SupplierFormFunParaController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormFunPara configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormFunParaModel in a body, <see cref="AddSupplierFormFunParaModel"/></param>
        /// <returns>If success should return newly added SupplierFormFunParaModel <see cref="SupplierFormFunParaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormFunParaCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormFunParaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormFunPara configuration
        /// </summary>
        /// <param name="id">SupplierFormFunPara Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormFunParaModel in a body, <see cref="UpdateSupplierFormFunParaModel"/></param>
        /// <returns>If success should return newly added SupplierFormFunParaModel <see cref="SupplierFormFunParaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormFunParaCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormFunParaModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormFunPara configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormFunParaModel in a body, <see cref="DeleteSupplierFormFunParaModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormFunParaResponse <see cref="DeleteSupplierFormFunParaResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormFunParaCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormFunParaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}