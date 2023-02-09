/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierAttachmentCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierAttachment Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierAttachmentController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierAttachmentController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierAttachmentController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierAttachmentController(ILogger<SupplierAttachmentController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierAttachment configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierAttachmentModel in a body, <see cref="AddSupplierAttachmentModel"/></param>
        /// <returns>If success should return newly added SupplierAttachmentModel <see cref="SupplierAttachmentModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierAttachmentCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierAttachmentModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierAttachment configuration
        /// </summary>
        /// <param name="id">SupplierAttachment Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierAttachmentModel in a body, <see cref="UpdateSupplierAttachmentModel"/></param>
        /// <returns>If success should return newly added SupplierAttachmentModel <see cref="SupplierAttachmentModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierAttachmentCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierAttachmentModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierAttachment configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierAttachmentModel in a body, <see cref="DeleteSupplierAttachmentModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierAttachmentResponse <see cref="DeleteSupplierAttachmentResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierAttachmentCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierAttachmentModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}