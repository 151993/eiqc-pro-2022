/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.Helpers.Http;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using System.Threading.Tasks;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Update;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Delete;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// CertificateType Controller provides ADD, Update and Delete operations
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class CertificateTypeController : BaseController
    {
        /// <summary>
        /// Store ILogger, <see cref="ILogger"/>
        /// </summary>
        private readonly ILogger<CertificateTypeController> _logger;

        private IQSSGatewayAPIClient _qssClient;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of CertificateTypeController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="qssClient">API Gateway, <see cref="IQSSGatewayAPIClient"/></param>
        public CertificateTypeController(ILogger<CertificateTypeController> logger, IMediator mediator, IQSSGatewayAPIClient qssClient) : base(mediator, logger)
        {
            _logger = logger;
            _qssClient = qssClient;
        }

        /// <summary>
        /// Async POST Action method to Add new CertificateType configuration
        /// </summary>
        /// <param name="request">Input parameter AddCertificateTypeModel in a body, <see cref="AddCertificateTypeModel"/></param>
        /// <returns>If success should return newly added CertificateTypeModel <see cref="CertificateTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPost]
        [Authorize(policy: nameof(PermissionType.AdminCertificateTypeCanCreate))]
        public async Task<IActionResult> Add([FromBody] AddCertificateTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async PUT Action method to update CertificateType configuration
        /// </summary>
        /// <param name="id">CertificateType Id as input in URL</param>
        /// <param name="request">Input parameter UpdateCertificateTypeModel in a body, <see cref="UpdateCertificateTypeModel"/></param>
        /// <returns>If success should return newly added CertificateTypeModel <see cref="CertificateTypeModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCertificateTypeCanUpdate))]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCertificateTypeModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }

        /// <summary>
        /// Async DELETE Action method to delete CertificateType configuration
        /// </summary>
        /// <param name="request">Input parameter DeleteCertificateTypeModel in a body, <see cref="DeleteCertificateTypeModel"/></param>
        /// <returns>If success should return newly added DeleteCertificateTypeResponse <see cref="DeleteCertificateTypeResponse"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpDelete]
        [Route("{id}")]
        [Authorize(policy: nameof(PermissionType.AdminCertificateTypeCanDelete))]
        public async Task<IActionResult> Delete(DeleteCertificateTypeModel request)
        {
            return await ExecuteMediatrRequest(request);
        }        
    }
}