
using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace QSS.Helpers.Filters
{
    /// <summary>
    /// The Global Exception Filter
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Filters.IExceptionFilter" />
    public class GlobalExceptionFilter : IExceptionFilter
    {
        /// <summary>
        /// Called after an action has thrown the exception />.
        /// </summary>
        /// <param name="context">The Context.</param>
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode status;

            string message;

            var exceptionType = context.Exception.GetType();
            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                message = "Unauthorized Access.";
                status = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(NotImplementedException))
            {
                message = "An error occurred on the server. Please retry later.";
                status = HttpStatusCode.NotImplemented;
            }
            else if (exceptionType == typeof(FileNotFoundException))
            {
                message = "Resource does not exist!";
                status = HttpStatusCode.NotFound;
            }
            else
            {
                message = context.Exception.Message;
                status = HttpStatusCode.InternalServerError;
            }

            context.ExceptionHandled = true;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            var err = message + " " + context.Exception.StackTrace;
            response.WriteAsync(err);
        }
    }
}
