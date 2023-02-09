using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Helpers.Claim;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QSS.Security
{
	/// <summary>
	/// Validate user permission to certificate if the user is able to perform specific action
	/// </summary>
	public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IQSSContext _context;

        public PermissionHandler(IQSSContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Validate user permission to certificate if the user is able to perform specific action
        /// </summary>
        /// <param name="context">database context<see cref="AuthorizationHandlerContext"/></param>
        /// <param name="requirement">requirement to satisfy<see cref="PermissionRequirement"/></param>
        /// <returns>Validation</returns>
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            PermissionRequirement requirement)
        {
            // get user claims
            var userIdentity = ClaimsTransformation.Transform(context.User as ClaimsPrincipal);
            // retrieves role id from user
            var roles = _context.User
	            .Join(_context.UserRole,
		            user => user.Id,
		            userRole => userRole.UserId,
		            (user, userRole) => new {User = user, UserRole = userRole})
	            .Where(condition => condition.User.Email.ToLower().Contains(userIdentity.Email.ToLower()))
	            .Select(select=> select.UserRole.RoleId).ToList();
            // retrieves permissions
            var isPermissionExists = _context.Role.Include(r => r.Permissions)
                .Where(r => roles.Contains(r.Id))
                .SelectMany(r => r.Permissions)
                .Any(p => p.PermissionType == requirement.Permission);

            if(isPermissionExists)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
