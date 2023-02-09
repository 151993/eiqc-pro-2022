/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormMicroSectionCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormMicroSection Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormMicroSectionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormMicroSectionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormMicroSectionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormMicroSectionController(ILogger<SupplierFormMicroSectionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormMicroSection configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormMicroSectionModel in a body, <see cref="AddSupplierFormMicroSectionModel"/></param>
        /// <returns>If success should return newly added SupplierFormMicroSectionModel <see cref="SupplierFormMicroSectionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMicroSectionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormMicroSectionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormMicroSection configuration
        /// </summary>
        /// <param name="id">SupplierFormMicroSection Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormMicroSectionModel in a body, <see cref="UpdateSupplierFormMicroSectionModel"/></param>
        /// <returns>If success should return newly added SupplierFormMicroSectionModel <see cref="SupplierFormMicroSectionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMicroSectionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormMicroSectionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormMicroSection configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormMicroSectionModel in a body, <see cref="DeleteSupplierFormMicroSectionModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormMicroSectionResponse <see cref="DeleteSupplierFormMicroSectionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMicroSectionCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormMicroSectionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}