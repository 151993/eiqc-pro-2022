using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Api.Security;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.eIQC.Handlers.Commands.UserCommand.Add;
using QSS.eIQC.Handlers.Commands.UserCommand.Delete;
using QSS.eIQC.Handlers.Commands.UserCommand.Update;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.Controllers
{
	/// <summary>
	/// User Controller provides ADD, Update, Delete and SearchAD operations
	/// </summary>
	 
	[Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<UserController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of UserController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public UserController(ILogger<UserController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new User configuration
        /// </summary>
        /// <param name="request">Input parameter AddUserModel in a body, <see cref="AddUserModel"/></param>
        /// <returns>If success should return newly added UserModel <see cref="UserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [MultiplePoliciesAuthorize(policies: "AdminUserCanCreate;AdminNonJabilUserCanCreate")]
        public async Task<IActionResult> Add([FromBody] AddUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update User configuration
        /// </summary>
        /// <param name="id">User Id as input in URL</param>
        /// <param name="request">Input parameter UpdateUserModel in a body, <see cref="UpdateUserModel"/></param>
        /// <returns>If success should return newly added UserModel <see cref="UserModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [MultiplePoliciesAuthorize(policies: "AdminUserCanUpdate;AdminNonJabilUserCanUpdate")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUserModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete User configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteUserModel in a body, <see cref="DeleteUserModel"/></param>
        /// <returns>If success should return newly added DeleteUserResponse <see cref="DeleteUserResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [MultiplePoliciesAuthorize(policies: "AdminUserCanDelete;AdminNonJabilUserCanDelete")]
        public async Task<IActionResult> Delete(DeleteUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async GET Action method to get user info from ActiveDirectory
        /// </summary>
        /// <param name="input"></param>
        [HttpGet]
        [Route("SearchBySamAccountOrName/{input}")]
        public async Task<List<ADUserModel>> SearchBySamAccountOrName(string input)
        {
            var res = await _qssClient.SearchBySamAccountOrName(input);

            return res.Result;
        }

        /// <summary>
        /// Async GET Action method to get user info from ActiveDirectory
        /// </summary>
        /// <param name="email"></param>
        [HttpGet]
        [Route("SearchByEmail/{email}")]
        public async Task<List<ADUserModel>> SearchByEmail(string email)
        {
            var res = await _qssClient.SearchByEmail(email);

            return res.Result;
        }
        [HttpPost]
        [Route("CreateOktaUser")]
        public async Task<IActionResult> CreateOktaUser([FromBody] AddUserModel request)
        {
            return await ExecuteMediatrRequest(request);
        }
    }
}