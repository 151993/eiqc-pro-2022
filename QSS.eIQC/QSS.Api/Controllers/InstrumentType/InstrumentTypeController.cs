/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Update;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand.Delete;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// InstrumentType Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentTypeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<InstrumentTypeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of InstrumentTypeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public InstrumentTypeController(ILogger<InstrumentTypeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new InstrumentType configuration
        /// </summary>
        /// <param name="request">Input parameter AddInstrumentTypeModel in a body, <see cref="AddInstrumentTypeModel"/></param>
        /// <returns>If success should return newly added InstrumentTypeModel <see cref="InstrumentTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminInstrumentTypeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddInstrumentTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update InstrumentType configuration
        /// </summary>
        /// <param name="id">InstrumentType Id as input in URL</param>
        /// <param name="request">Input parameter UpdateInstrumentTypeModel in a body, <see cref="UpdateInstrumentTypeModel"/></param>
        /// <returns>If success should return newly added InstrumentTypeModel <see cref="InstrumentTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInstrumentTypeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateInstrumentTypeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete InstrumentType configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteInstrumentTypeModel in a body, <see cref="DeleteInstrumentTypeModel"/></param>
        /// <returns>If success should return newly added DeleteInstrumentTypeResponse <see cref="DeleteInstrumentTypeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInstrumentTypeCanDelete))]
        public async Task<IActionResult> Delete(DeleteInstrumentTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}