/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.BuyerCommand.Add;
using QSS.eIQC.Handlers.Commands.BuyerCommand.Update;
using QSS.eIQC.Handlers.Commands.BuyerCommand.Delete;
using QSS.eIQC.Handlers.Commands.BuyerCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Buyer Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<BuyerController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of BuyerController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public BuyerController(ILogger<BuyerController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Buyer configuration
        /// </summary>
        /// <param name="request">Input parameter AddBuyerModel in a body, <see cref="AddBuyerModel"/></param>
        /// <returns>If success should return newly added BuyerModel <see cref="BuyerModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminBuyerCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddBuyerModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Buyer configuration
        /// </summary>
        /// <param name="id">Buyer Id as input in URL</param>
        /// <param name="request">Input parameter UpdateBuyerModel in a body, <see cref="UpdateBuyerModel"/></param>
        /// <returns>If success should return newly added BuyerModel <see cref="BuyerModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminBuyerCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateBuyerModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Buyer configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteBuyerModel in a body, <see cref="DeleteBuyerModel"/></param>
        /// <returns>If success should return newly added DeleteBuyerResponse <see cref="DeleteBuyerResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminBuyerCanDelete))]
        public async Task<IActionResult> Delete(DeleteBuyerModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}