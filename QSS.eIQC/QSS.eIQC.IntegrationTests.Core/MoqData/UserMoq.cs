using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class UserMoq
    {
        public static User[] Users = new[] {

            new User { Id = 1, UserName= "System User", Email= "system_user@jabil.com", EmployeeId= "0",Status= Domain.Enums.StatusType.Active},
            new User { Id = 2, UserName= "Default Access", Email= "default_access@jabil.com", EmployeeId= "0",Status= Domain.Enums.StatusType.Active}

        };
    }
}
