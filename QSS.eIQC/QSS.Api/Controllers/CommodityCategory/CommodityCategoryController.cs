/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Add;
using QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Update;
using QSS.eIQC.Handlers.Commands.CommodityCategoryCommand.Delete;
using QSS.eIQC.Handlers.Commands.CommodityCategoryCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// CommodityCategory Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CommodityCategoryController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CommodityCategoryController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of CommodityCategoryController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public CommodityCategoryController(ILogger<CommodityCategoryController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new CommodityCategory configuration
        /// </summary>
        /// <param name="request">Input parameter AddCommodityCategoryModel in a body, <see cref="AddCommodityCategoryModel"/></param>
        /// <returns>If success should return newly added CommodityCategoryModel <see cref="CommodityCategoryModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCommodityCategoryCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCommodityCategoryModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update CommodityCategory configuration
        /// </summary>
        /// <param name="id">CommodityCategory Id as input in URL</param>
        /// <param name="request">Input parameter UpdateCommodityCategoryModel in a body, <see cref="UpdateCommodityCategoryModel"/></param>
        /// <returns>If success should return newly added CommodityCategoryModel <see cref="CommodityCategoryModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCommodityCategoryCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCommodityCategoryModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete CommodityCategory configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCommodityCategoryModel in a body, <see cref="DeleteCommodityCategoryModel"/></param>
        /// <returns>If success should return newly added DeleteCommodityCategoryResponse <see cref="DeleteCommodityCategoryResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCommodityCategoryCanDelete))]
        public async Task<IActionResult> Delete(DeleteCommodityCategoryModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}