using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.DivisionCommand;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Add;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Delete;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Update;
using QSS.eIQC.TM1Sync.Interface;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;

namespace QSS.eIQC.Api.Controllers.Division
{
    /// <summary>
    /// Division Controller provides ADD, Update, Delete and SearchAD operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<DivisionController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        private readonly ISyncTM1DataHelper _syncTM1DataHelper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of DivisionController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        /// <param name="syncTM1DataHelper">Sync TM1 Data Helper, <see cref="ISyncTM1DataHelper"/></param>
        public DivisionController(ILogger<DivisionController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient, ISyncTM1DataHelper syncTM1DataHelper) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
            _syncTM1DataHelper = syncTM1DataHelper;
        }

        /// <summary>
        /// Async POST Action method to Add new Division configuration
        /// </summary>
        /// <param name="request">Input parameter AddDivisionModel in a body, <see cref="AddDivisionModel"/></param>
        /// <returns>If success should return newly added DivisionModel <see cref="DivisionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminDivisionCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddDivisionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Division configuration
        /// </summary>
        /// <param name="id">Division Id as input in URL</param>
        /// <param name="request">Input parameter UpdateDivisionModel in a body, <see cref="UpdateDivisionModel"/></param>
        /// <returns>If success should return newly added DivisionModel <see cref="DivisionModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDivisionCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateDivisionModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete Division configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteDivisionModel in a body, <see cref="DeleteDivisionModel"/></param>
        /// <returns>If success should return newly added DeleteDivisionResponse <see cref="DeleteDivisionResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminDivisionCanDelete))]
        public async Task<IActionResult> Delete(DeleteDivisionModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        [HttpGet]
        [Route("SyncDivisionFromTM1")]
        public async Task<bool> SyncDivisionFromTM1()
        {
            try
            {
                var lastsyncdivisiondate = _syncTM1DataHelper.GetTM1LastSyncDate(SyncTM1DataType.Last_Sync_Division);
                var tM1Divisions = await _qssClient.GetDivision(lastsyncdivisiondate);
                return await _syncTM1DataHelper.SyncDivision(tM1Divisions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in SyncDivisionFromTM1");
                throw;
            }
        }

        [HttpGet]
        [Route("GetTM1LastSyncDate")]
        public DateTimeOffset GetTM1LastSyncDateAsync()
        {          
              return _syncTM1DataHelper.GetTM1LastSyncDate(SyncTM1DataType.Last_Sync_Division);
        }
    }
}
