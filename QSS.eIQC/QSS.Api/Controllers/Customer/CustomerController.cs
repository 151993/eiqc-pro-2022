/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.CustomerCommand.Add;
using QSS.eIQC.Handlers.Commands.CustomerCommand.Update;
using QSS.eIQC.Handlers.Commands.CustomerCommand.Delete;
using QSS.eIQC.Handlers.Commands.CustomerCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Customer Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CustomerController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of CustomerController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public CustomerController(ILogger<CustomerController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new Customer configuration
        /// </summary>
        /// <param name="request">Input parameter AddCustomerModel in a body, <see cref="AddCustomerModel"/></param>
        /// <returns>If success should return newly added CustomerModel <see cref="CustomerModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCustomerCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCustomerModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Customer configuration
        /// </summary>
        /// <param name="id">Customer Id as input in URL</param>
        /// <param name="request">Input parameter UpdateCustomerModel in a body, <see cref="UpdateCustomerModel"/></param>
        /// <returns>If success should return newly added CustomerModel <see cref="CustomerModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCustomerCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCustomerModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Customer configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCustomerModel in a body, <see cref="DeleteCustomerModel"/></param>
        /// <returns>If success should return newly added DeleteCustomerResponse <see cref="DeleteCustomerResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCustomerCanDelete))]
        public async Task<IActionResult> Delete(DeleteCustomerModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}