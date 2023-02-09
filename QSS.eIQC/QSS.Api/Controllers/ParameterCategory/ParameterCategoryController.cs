/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Add;
using QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Update;
using QSS.eIQC.Handlers.Commands.ParameterCategoryCommand.Delete;
using QSS.eIQC.Handlers.Commands.ParameterCategoryCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ParameterCategory Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class ParameterCategoryController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<ParameterCategoryController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of ParameterCategoryController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public ParameterCategoryController(ILogger<ParameterCategoryController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new ParameterCategory configuration
        /// </summary>
        /// <param name="request">Input parameter AddParameterCategoryModel in a body, <see cref="AddParameterCategoryModel"/></param>
        /// <returns>If success should return newly added ParameterCategoryModel <see cref="ParameterCategoryModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminParameterCategoryCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddParameterCategoryModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update ParameterCategory configuration
        /// </summary>
        /// <param name="id">ParameterCategory Id as input in URL</param>
        /// <param name="request">Input parameter UpdateParameterCategoryModel in a body, <see cref="UpdateParameterCategoryModel"/></param>
        /// <returns>If success should return newly added ParameterCategoryModel <see cref="ParameterCategoryModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterCategoryCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateParameterCategoryModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete ParameterCategory configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteParameterCategoryModel in a body, <see cref="DeleteParameterCategoryModel"/></param>
        /// <returns>If success should return newly added DeleteParameterCategoryResponse <see cref="DeleteParameterCategoryResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminParameterCategoryCanDelete))]
        public async Task<IActionResult> Delete(DeleteParameterCategoryModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}