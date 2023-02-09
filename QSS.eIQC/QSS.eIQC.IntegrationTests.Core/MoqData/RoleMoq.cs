using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class RoleMoq
    {
        public static Role[] Roles = new[] {
            new Role { Id = 1, Name= "Admin"},
            new Role { Id = 2, Name= "DefaultAccess"},
          
        };
    }
}
