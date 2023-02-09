using Microsoft.AspNetCore.Http;
using Moq;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core;
using System.Security.Claims;
using Xunit;

namespace QSS.eIQC.DataAccess.UnitTests.MoqData
{
    public class RoleMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public RoleMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(Role entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            {
                qssContext.Role.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
