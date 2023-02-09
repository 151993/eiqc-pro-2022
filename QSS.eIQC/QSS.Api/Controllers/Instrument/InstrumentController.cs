/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.InstrumentCommand.Add;
using QSS.eIQC.Handlers.Commands.InstrumentCommand.Update;
using QSS.eIQC.Handlers.Commands.InstrumentCommand.Delete;
using QSS.eIQC.Handlers.Commands.InstrumentCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Instrument Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<InstrumentController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of InstrumentController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public InstrumentController(ILogger<InstrumentController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Instrument configuration
        /// </summary>
        /// <param name="request">Input parameter AddInstrumentModel in a body, <see cref="AddInstrumentModel"/></param>
        /// <returns>If success should return newly added InstrumentModel <see cref="InstrumentModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminInstrumentCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddInstrumentModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Instrument configuration
        /// </summary>
        /// <param name="id">Instrument Id as input in URL</param>
        /// <param name="request">Input parameter UpdateInstrumentModel in a body, <see cref="UpdateInstrumentModel"/></param>
        /// <returns>If success should return newly added InstrumentModel <see cref="InstrumentModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInstrumentCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateInstrumentModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Instrument configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteInstrumentModel in a body, <see cref="DeleteInstrumentModel"/></param>
        /// <returns>If success should return newly added DeleteInstrumentResponse <see cref="DeleteInstrumentResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminInstrumentCanDelete))]
        public async Task<IActionResult> Delete(DeleteInstrumentModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}