/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Add;
using QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Update;
using QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand.Delete;
using QSS.eIQC.Handlers.Commands.LotInspectionQtyCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// LotInspectionQty Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class LotInspectionQtyController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<LotInspectionQtyController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of LotInspectionQtyController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public LotInspectionQtyController(ILogger<LotInspectionQtyController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new LotInspectionQty configuration
        /// </summary>
        /// <param name="request">Input parameter AddLotInspectionQtyModel in a body, <see cref="AddLotInspectionQtyModel"/></param>
        /// <returns>If success should return newly added LotInspectionQtyModel <see cref="LotInspectionQtyModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminLotInspectionQtyCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddLotInspectionQtyModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update LotInspectionQty configuration
        /// </summary>
        /// <param name="id">LotInspectionQty Id as input in URL</param>
        /// <param name="request">Input parameter UpdateLotInspectionQtyModel in a body, <see cref="UpdateLotInspectionQtyModel"/></param>
        /// <returns>If success should return newly added LotInspectionQtyModel <see cref="LotInspectionQtyModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminLotInspectionQtyCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateLotInspectionQtyModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete LotInspectionQty configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteLotInspectionQtyModel in a body, <see cref="DeleteLotInspectionQtyModel"/></param>
        /// <returns>If success should return newly added DeleteLotInspectionQtyResponse <see cref="DeleteLotInspectionQtyResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminLotInspectionQtyCanDelete))]
        public async Task<IActionResult> Delete(DeleteLotInspectionQtyModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}