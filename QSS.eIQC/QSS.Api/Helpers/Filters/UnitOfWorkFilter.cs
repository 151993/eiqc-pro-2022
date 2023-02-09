using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Storage;

namespace QSS.Helpers.Filters
{
    /// <summary>
    /// Unit Of Work Action Filter
    /// </summary>
    public class UnitOfWorkFilter : IAsyncActionFilter
    {
        /// <summary>
        /// The Injected DBContext Transaction Interface
        /// </summary>
        /// <seealso cref="IDbContextTransaction"/>
        readonly IDbContextTransaction _transaction;

        /// <summary>
        /// Creates an instace of the <see cref="UnitOfWorkFilter"/>
        /// </summary>
        /// <param name="transaction">The <see cref="IDbContextTransaction"/></param>
        public UnitOfWorkFilter(IDbContextTransaction transaction)
        {
            _transaction = transaction;
        }

        /// <summary>
        /// Execute the HTTP Request action and commits or roll back the transaction
        /// </summary>
        /// <param name="context">the <see cref="ActionExecutingContext"/></param>
        /// <param name="next">the context <see cref="ActionExecutionDelegate"/></param>
        /// <returns>The Task</returns>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var executedContext = await next.Invoke().ConfigureAwait(false);

            // Validate if an exception has occured to Commit or Rollback the Transaction
            var result = executedContext.Result as ObjectResult;

            if (result?.StatusCode == 200)
            {
                _transaction.Commit();
            }
            else
            {
                _transaction.Rollback();
            }
        }
    }
}
