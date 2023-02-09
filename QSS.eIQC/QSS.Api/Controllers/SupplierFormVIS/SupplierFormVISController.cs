/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormVISCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormVISCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormVIS Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormVISController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormVISController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormVISController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormVISController(ILogger<SupplierFormVISController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormVIS configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormVISModel in a body, <see cref="AddSupplierFormVISModel"/></param>
        /// <returns>If success should return newly added SupplierFormVISModel <see cref="SupplierFormVISModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormVISCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormVISModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormVIS configuration
        /// </summary>
        /// <param name="id">SupplierFormVIS Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormVISModel in a body, <see cref="UpdateSupplierFormVISModel"/></param>
        /// <returns>If success should return newly added SupplierFormVISModel <see cref="SupplierFormVISModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormVISCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormVISModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormVIS configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormVISModel in a body, <see cref="DeleteSupplierFormVISModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormVISResponse <see cref="DeleteSupplierFormVISResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormVISCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormVISModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}