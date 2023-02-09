/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.UserCustomerCommand.Add;
using QSS.eIQC.Handlers.Commands.UserCustomerCommand.Update;
using QSS.eIQC.Handlers.Commands.UserCustomerCommand.Delete;
using QSS.eIQC.Handlers.Commands.UserCustomerCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// UserCustomer Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class UserCustomerController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<UserCustomerController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of UserCustomerController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public UserCustomerController(ILogger<UserCustomerController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new UserCustomer configuration
        /// </summary>
        /// <param name="request">Input parameter AddUserCustomerModel in a body, <see cref="AddUserCustomerModel"/></param>
        /// <returns>If success should return newly added UserCustomerModel <see cref="UserCustomerModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
      //  [Authorize(policy: nameof(PermissionType.AdminUserCustomerCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddUserCustomerModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update UserCustomer configuration
        /// </summary>
        /// <param name="id">UserCustomer Id as input in URL</param>
        /// <param name="request">Input parameter UpdateUserCustomerModel in a body, <see cref="UpdateUserCustomerModel"/></param>
        /// <returns>If success should return newly added UserCustomerModel <see cref="UserCustomerModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
       // [Authorize(policy: nameof(PermissionType.AdminUserCustomerCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUserCustomerModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete UserCustomer configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteUserCustomerModel in a body, <see cref="DeleteUserCustomerModel"/></param>
        /// <returns>If success should return newly added DeleteUserCustomerResponse <see cref="DeleteUserCustomerResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
       // [Authorize(policy: nameof(PermissionType.AdminUserCustomerCanDelete))]
        public async Task<IActionResult> Delete(DeleteUserCustomerModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}