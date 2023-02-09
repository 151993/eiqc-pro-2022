/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Add;
using QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Update;
using QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormPartSAPFailedQtyCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormPartSAPFailedQty Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormPartSAPFailedQtyController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormPartSAPFailedQtyController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormPartSAPFailedQtyController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormPartSAPFailedQtyController(ILogger<FormPartSAPFailedQtyController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormPartSAPFailedQty configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormPartSAPFailedQtyModel in a body, <see cref="AddFormPartSAPFailedQtyModel"/></param>
        /// <returns>If success should return newly added FormPartSAPFailedQtyModel <see cref="FormPartSAPFailedQtyModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormPartSAPFailedQtyCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormPartSAPFailedQtyModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormPartSAPFailedQty configuration
        /// </summary>
        /// <param name="id">FormPartSAPFailedQty Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormPartSAPFailedQtyModel in a body, <see cref="UpdateFormPartSAPFailedQtyModel"/></param>
        /// <returns>If success should return newly added FormPartSAPFailedQtyModel <see cref="FormPartSAPFailedQtyModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormPartSAPFailedQtyCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormPartSAPFailedQtyModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormPartSAPFailedQty configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormPartSAPFailedQtyModel in a body, <see cref="DeleteFormPartSAPFailedQtyModel"/></param>
        /// <returns>If success should return newly added DeleteFormPartSAPFailedQtyResponse <see cref="DeleteFormPartSAPFailedQtyResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormPartSAPFailedQtyCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormPartSAPFailedQtyModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}