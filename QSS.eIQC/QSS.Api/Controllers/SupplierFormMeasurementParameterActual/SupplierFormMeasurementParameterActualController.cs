/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierFormMeasurementParameterActualCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SupplierFormMeasurementParameterActual Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierFormMeasurementParameterActualController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierFormMeasurementParameterActualController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of SupplierFormMeasurementParameterActualController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public SupplierFormMeasurementParameterActualController(ILogger<SupplierFormMeasurementParameterActualController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new SupplierFormMeasurementParameterActual configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierFormMeasurementParameterActualModel in a body, <see cref="AddSupplierFormMeasurementParameterActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormMeasurementParameterActualModel <see cref="SupplierFormMeasurementParameterActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMeasurementParameterActualCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierFormMeasurementParameterActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update SupplierFormMeasurementParameterActual configuration
        /// </summary>
        /// <param name="id">SupplierFormMeasurementParameterActual Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierFormMeasurementParameterActualModel in a body, <see cref="UpdateSupplierFormMeasurementParameterActualModel"/></param>
        /// <returns>If success should return newly added SupplierFormMeasurementParameterActualModel <see cref="SupplierFormMeasurementParameterActualModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMeasurementParameterActualCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierFormMeasurementParameterActualModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete SupplierFormMeasurementParameterActual configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteSupplierFormMeasurementParameterActualModel in a body, <see cref="DeleteSupplierFormMeasurementParameterActualModel"/></param>
        /// <returns>If success should return newly added DeleteSupplierFormMeasurementParameterActualResponse <see cref="DeleteSupplierFormMeasurementParameterActualResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierFormMeasurementParameterActualCanDelete))]
        public async Task<IActionResult> Delete(DeleteSupplierFormMeasurementParameterActualModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}