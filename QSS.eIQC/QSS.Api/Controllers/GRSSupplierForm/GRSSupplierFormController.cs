/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Add;
using QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Update;
using QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand.Delete;
using QSS.eIQC.Handlers.Commands.GRSSupplierFormCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// GRSSupplierForm Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class GRSSupplierFormController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<GRSSupplierFormController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of GRSSupplierFormController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public GRSSupplierFormController(ILogger<GRSSupplierFormController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new GRSSupplierForm configuration
        /// </summary>
        /// <param name="request">Input parameter AddGRSSupplierFormModel in a body, <see cref="AddGRSSupplierFormModel"/></param>
        /// <returns>If success should return newly added GRSSupplierFormModel <see cref="GRSSupplierFormModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminGRSSupplierFormCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddGRSSupplierFormModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update GRSSupplierForm configuration
        /// </summary>
        /// <param name="id">GRSSupplierForm Id as input in URL</param>
        /// <param name="request">Input parameter UpdateGRSSupplierFormModel in a body, <see cref="UpdateGRSSupplierFormModel"/></param>
        /// <returns>If success should return newly added GRSSupplierFormModel <see cref="GRSSupplierFormModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGRSSupplierFormCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateGRSSupplierFormModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete GRSSupplierForm configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteGRSSupplierFormModel in a body, <see cref="DeleteGRSSupplierFormModel"/></param>
        /// <returns>If success should return newly added DeleteGRSSupplierFormResponse <see cref="DeleteGRSSupplierFormResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminGRSSupplierFormCanDelete))]
        public async Task<IActionResult> Delete(DeleteGRSSupplierFormModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}