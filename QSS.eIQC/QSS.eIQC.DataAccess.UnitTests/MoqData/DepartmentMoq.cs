using Microsoft.AspNetCore.Http;
using Moq;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core;
using System.Security.Claims;
using Xunit;

namespace QSS.eIQC.DataAccess.UnitTests.MoqData
{
    public class DepartmentMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public DepartmentMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(Department entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            {
                qssContext.Department.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
