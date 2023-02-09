using Microsoft.AspNetCore.Http;
using Moq;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core;
using System.Security.Claims;
using Xunit;

namespace QSS.eIQC.DataAccess.UnitTests.MoqData
{
    public class WorkCellMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public WorkCellMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(WorkCell entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            {
                qssContext.WorkCell.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
