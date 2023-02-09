/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Update;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Delete;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// BowTwistFormula Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class BowTwistFormulaController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<BowTwistFormulaController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of BowTwistFormulaController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public BowTwistFormulaController(ILogger<BowTwistFormulaController> logger, IMediator mediator) : base(mediator, logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Async POST Action method to Add new BowTwistFormula configuration
        /// </summary>
        /// <param name="request">Input parameter AddBowTwistFormulaModel in a body, <see cref="AddBowTwistFormulaModel"/></param>
        /// <returns>If success should return newly added BowTwistFormulaModel <see cref="BowTwistFormulaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminBowTwistFormulaCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddBowTwistFormulaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update BowTwistFormula configuration
        /// </summary>
        /// <param name="id">BowTwistFormula Id as input in URL</param>
        /// <param name="request">Input parameter UpdateBowTwistFormulaModel in a body, <see cref="UpdateBowTwistFormulaModel"/></param>
        /// <returns>If success should return newly added BowTwistFormulaModel <see cref="BowTwistFormulaModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminBowTwistFormulaCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateBowTwistFormulaModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete BowTwistFormula configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteBowTwistFormulaModel in a body, <see cref="DeleteBowTwistFormulaModel"/></param>
        /// <returns>If success should return newly added DeleteBowTwistFormulaResponse <see cref="DeleteBowTwistFormulaResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminBowTwistFormulaCanDelete))]
        public async Task<IActionResult> Delete(DeleteBowTwistFormulaModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}