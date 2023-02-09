/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.FormFunParaCommand.Add;
using QSS.eIQC.Handlers.Commands.FormFunParaCommand.Update;
using QSS.eIQC.Handlers.Commands.FormFunParaCommand.Delete;
using QSS.eIQC.Handlers.Commands.FormFunParaCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// FormFunPara Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class FormFunParaController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<FormFunParaController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of FormFunParaController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public FormFunParaController(ILogger<FormFunParaController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new FormFunPara configuration
        /// </summary>
        /// <param name="request">Input parameter AddFormFunParaModel in a body, <see cref="AddFormFunParaModel"/></param>
        /// <returns>If success should return newly added FormFunParaModel <see cref="FormFunParaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminFormFunParaCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddFormFunParaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update FormFunPara configuration
        /// </summary>
        /// <param name="id">FormFunPara Id as input in URL</param>
        /// <param name="request">Input parameter UpdateFormFunParaModel in a body, <see cref="UpdateFormFunParaModel"/></param>
        /// <returns>If success should return newly added FormFunParaModel <see cref="FormFunParaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormFunParaCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFormFunParaModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete FormFunPara configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteFormFunParaModel in a body, <see cref="DeleteFormFunParaModel"/></param>
        /// <returns>If success should return newly added DeleteFormFunParaResponse <see cref="DeleteFormFunParaResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminFormFunParaCanDelete))]
        public async Task<IActionResult> Delete(DeleteFormFunParaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}