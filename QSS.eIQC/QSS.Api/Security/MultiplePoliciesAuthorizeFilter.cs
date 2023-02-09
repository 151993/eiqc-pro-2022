using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Helpers.Claim;
using QSS.eIQC.Domain.Enums;
using QSS.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Security
{
    public class MultiplePoliciesAuthorizeFilter : IAsyncAuthorizationFilter
    {
        private readonly IQSSContext _context;
        public string Policies { get; private set; }
        public bool IsAnd { get; private set; }

        public MultiplePoliciesAuthorizeFilter(string policies, bool isAnd, IAuthorizationService authorization, IQSSContext context)
        {
            Policies = policies;
            IsAnd = isAnd;
            _context = context;
        }

        
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var policys = Policies.Split(";").ToList();

            var userIdentity = ClaimsTransformation.Transform(context.HttpContext.User as ClaimsPrincipal);
            // retrieves role id from user
            var roles = _context.User
                .Join(_context.UserRole,
                    user => user.Id,
                    userRole => userRole.UserId,
                    (user, userRole) => new { User = user, UserRole = userRole })
                .Where(condition => condition.User.Email.ToLower().Contains(userIdentity.Email.ToLower()))
                .Select(select => select.UserRole.RoleId).ToList();
            // retrieves permissions
            foreach (var item in policys)
            {
                
                Enum.TryParse(item, out PermissionType permissionType);
                var isPermissionExists = _context.Role.Include(r => r.Permissions)
                                   .Where(r => roles.Contains(r.Id))
                                   .SelectMany(r => r.Permissions)
                                   .Any(p => p.PermissionType == permissionType);
                if(isPermissionExists)
                {
                    return;
                }
                
            }
            context.Result = new ForbidResult();
            return;
        }
    }

    public class MultiplePoliciesAuthorizeAttribute : TypeFilterAttribute
    {
        public MultiplePoliciesAuthorizeAttribute(string policies, bool isAnd = false) : base(typeof(MultiplePoliciesAuthorizeFilter))
        {
            Arguments = new object[] { policies, isAnd };
        }
    }
}
