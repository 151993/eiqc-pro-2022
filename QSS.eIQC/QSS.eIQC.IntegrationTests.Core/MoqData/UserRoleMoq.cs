using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class UserRoleMoq
    {
        public static UserRole[] UserRoles = new[] {
            new UserRole { RoleId = 1, UserId= 1},
            new UserRole { RoleId = 2, UserId= 2}

        };
    }
}
