using Microsoft.AspNetCore.Http;
using Moq;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core;
using System.Security.Claims;
using Xunit;

namespace QSS.eIQC.DataAccess.UnitTests.MoqData
{
    public class CountryMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public CountryMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(Country entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            {
                qssContext.Country.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
