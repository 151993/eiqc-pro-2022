using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.SupplierCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierCommand.Delete;
using QSS.eIQC.Handlers.Commands.SupplierCommand.Update;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPSync.Interface;
using QSS.Helpers.Http;

namespace QSS.eIQC.Api.Controllers.Supplier
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<SupplierController> _logger;
        private readonly ISAPeHanaClient _sapHanaClient;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of MaterialGroupController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public SupplierController(ILogger<SupplierController> logger, IMapper mapper, IMediator mediator,
            ISyncSAPDataHelper syncSAPDataHelper, ISAPeHanaClient sapHanaClient) : base(mediator, logger)
        {
            _logger = logger;
            _syncSAPDataHelper = syncSAPDataHelper;
            _sapHanaClient = sapHanaClient;
            _mapper = mapper;
        }

        /// <summary>
        /// Async POST Action method to Add new Supplier configuration
        /// </summary>
        /// <param name="request">Input parameter AddSupplierModel in a body, <see cref="AddSupplierModel"/></param>
        /// <returns>If success should return newly added SupplierModel <see cref="SupplierModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminSupplierCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddSupplierModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update Supplier configuration
        /// </summary>
        /// <param name="id">Supplier Id as input in URL</param>
        /// <param name="request">Input parameter UpdateSupplierModel in a body, <see cref="UpdateSupplierModel"/></param>
        /// <returns>If success should return newly added SupplierModel <see cref="SupplierModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminSupplierCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSupplierModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }
      

        [HttpGet]
        [Route("GetSAPLastSyncDate")]
        public DateTimeOffset GetSAPLastSyncDateAsync()
        {
            return _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_Supplier);
        }
    }
}
