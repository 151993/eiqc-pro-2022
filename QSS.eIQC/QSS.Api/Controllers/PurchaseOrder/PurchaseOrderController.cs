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

namespace QSS.eIQC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<PurchaseOrderController> _logger;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of MaterialGroupController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        public PurchaseOrderController(ILogger<PurchaseOrderController> logger, IMapper mapper, IMediator mediator,
            ISyncSAPDataHelper syncSAPDataHelper) : base(mediator, logger)
        {
            _logger = logger;
            _syncSAPDataHelper = syncSAPDataHelper;
            _mapper = mapper;
        }


       

        [HttpGet]
        [Route("GetSAPLastSyncDate")]
        public DateTimeOffset GetSAPLastSyncDateAsync()
        {
            return _syncSAPDataHelper.GetSAPLastSyncDate(SyncSAPDataType.Last_Sync_PurchaseOrder);
        }
    }
}
