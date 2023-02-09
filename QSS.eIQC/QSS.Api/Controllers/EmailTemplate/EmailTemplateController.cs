using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.EmailTemplateCommand;
using QSS.eIQC.Handlers.Commands.EmailTemplateCommand.Update;
using QSS.Helpers.Http;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Controllers.EmailTemplate
{
	/// <summary>
	/// EmailTemplate Controller provides ADD, Update and Delete operations
	/// </summary>
	
    [Route("api/emailTemplate")]
    [ApiController]
    public class EmailTemplateController : BaseController
    {
        /// <summary>
        /// Contructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of EmailTemplateController on runtime, <see cref="ILogger"/></param>
        /// <param name="mediator">Injected instance of mediator on runtime, <see cref="IMediator"/></param>
        /// <param name="contextAccessor">Injected instance of IHttpContextAccessor on runtime, <see cref="IHttpContextAccessor"/></param>
        public EmailTemplateController(ILogger<EmailTemplateController> logger, IMediator mediator, IHttpContextAccessor contextAccessor) : base(mediator, logger, contextAccessor)
        {
        }

        /// <summary>
        /// Async PUT Action method to update EmailTemplate configuration
        /// </summary>
        /// <param name="id">EmailTemplate Id as input in URL</param>
        /// <param name="request">Input parameter UpdateEmailTemplateModel in a body, <see cref="UpdateEmailTemplateModel"/></param>
        /// <returns>If success should return newly added EmailTemplateModel <see cref="EmailTemplateModel"/> as IActionResult, <see cref="IActionResult"/></returns>
        [HttpPut]
        [Authorize(policy: nameof(PermissionType.AdminEmailTemplateCanUpdate))]
        [Route("{id}")]
        [SwaggerOperation(
            Summary = "Update EmailTemplate configuration",
            Description = "This endpoint update EmailTemplate configuration.")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateEmailTemplateModel request)
        {
            if (id != request.Id || request == null)
            {
                return BadRequest();
            }

            return await ExecuteMediatrRequest(request);
        }
    }
}
