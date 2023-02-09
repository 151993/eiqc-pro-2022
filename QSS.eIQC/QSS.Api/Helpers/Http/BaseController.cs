using System;
using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.Http;
using Microsoft.AspNetCore.Http;
using QSS.Infrastructure;
using System.Threading.Tasks;
using QSS.Infrastructure.Exceptions;

namespace QSS.Helpers.Http
{
    /// <summary>
    /// The Base Controller Class
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// The Mediatr Interface
        /// </summary>
        private IMediator _mediatr;

        /// <summary>
        /// ILogger Interface
        /// </summary>
        private readonly ILogger _logger;

        IHttpContextAccessor _contextAccessor;

        /// <summary>
        /// The Base Controller Contructor
        /// </summary>
        /// <param name="mediatr">The <see cref="IMediator"/></param>
        /// <param name="logger">The <see cref="ILogger"/></param>
        public BaseController(IMediator mediatr, ILogger<BaseController> logger)
        {
            _mediatr = mediatr;
            _logger = logger;
        }

        /// <summary>
        /// The Base Controller Contructor
        /// </summary>
        /// <param name="mediatr">The <see cref="IMediator"/></param>
        /// <param name="logger">The <see cref="ILogger"/></param>
        /// <param name="httpContextAccessor">The <see cref="IHttpContextAccessor"/></param>
        public BaseController(IMediator mediatr, ILogger<BaseController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _mediatr = mediatr;
            _logger = logger;
            _contextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Executes a Mediatr Requests and Handles the response or any exceptions may happen
        /// </summary>
        /// <typeparam name="T">Class Type</typeparam>
        /// <param name="request">Request of Type Class</param>
        /// <returns></returns>
        public async Task<IActionResult> ExecuteMediatrRequest<T>(IRequest<T> request) where T : class
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Input values are not well formed, Please verify parameters.");
                }

                var result = await _mediatr.Send(request);

                if (result == null)
                {
                    throw new NotFoundException("Details are not available.");
                }

                return Ok(new ResponsePayload<T>
                {
                    Data = result,
                    Message = "The request was executed successfully.",
                    Status = ResponseStatus.Success.ToString()
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{ex.Message}.", ex);
                return ExceptionResponse<T>(ex);
            }
        }

        /// <summary>
        /// Exceptions the response.
        /// </summary>
        /// <typeparam name="T">T Class</typeparam>
        /// <param name="ex">The ex.</param>
        /// <returns>
        /// The IActionResult
        /// </returns>
        protected IActionResult ExceptionResponse<T>(Exception ex) where T : class
        {
            if (ex.GetType() == typeof(BadInputValuesException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message,
                    (int)ErrorCode.InputValuesNotGood, ResponseStatus.BadRequest.ToString());
            }
            else if (ex.GetType() == typeof(AlreadyExistsException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message,
                    (int)ErrorCode.KeyAlreadyExists, ResponseStatus.BadRequest.ToString());
            }
            else if (ex.GetType() == typeof(InvalidActionException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message, (int)ErrorCode.InvalidAction,
                    ResponseStatus.InvalidAction.ToString());
            }
            else if (ex.GetType() == typeof(NotFoundException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message, (int)ErrorCode.NotFound,
                    ResponseStatus.NotFound.ToString());
            }
            else if (ex.GetType() == typeof(NullReferenceException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.InternalServerError, ex.Message,
                    (int)ErrorCode.NullReference, ResponseStatus.BadRequest.ToString());
            }
            else if (ex.GetType() == typeof(ArgumentException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message,
                    (int)ErrorCode.InputValuesNotGood, ResponseStatus.BadRequest.ToString());
            }
            else if (ex.GetType() == typeof(UnableToDeleteException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message,
                    (int)ErrorCode.UnableToDelete, ResponseStatus.BadRequest.ToString());
            }
            else if (ex.GetType() == typeof(FluentValidation.ValidationException))
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.BadRequest, ex.Message, (int)ErrorCode.BadRequest,
                    ResponseStatus.BadRequest.ToString());
            }
            else
            {
                return CreateResponse<T>(ex, (int)HttpStatusCode.InternalServerError, ex.Message,
                    (int)ErrorCode.InternalServerError, ResponseStatus.Failed.ToString());
            }
        }

        /// <summary>
        /// Creates the response.
        /// </summary>
        /// <typeparam name="T"> The generic type</typeparam>
        /// <param name="ex">Exception</param>
        /// <param name="statusCode">The status code.</param>
        /// <param name="message">The message.</param>
        /// <param name="errorcode">The error code.</param>
        /// <param name="status">The status.</param>
        /// <returns>
        /// The ObjectResult
        /// </returns>
        private ObjectResult CreateResponse<T>(Exception ex, int statusCode, string message, int errorcode,
            string status) where T : class
        {
            return StatusCode(
                statusCode,
                new ResponsePayload<T>
                {
                    Message = message,
                    ErrorCode = errorcode,
                    Status = status,
                    Exception = ex
                });
        }
    }
}
