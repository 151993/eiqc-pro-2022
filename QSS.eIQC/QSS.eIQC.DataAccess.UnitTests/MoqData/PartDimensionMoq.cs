/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.AspNetCore.Http;
using Moq;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core;
using System.Security.Claims;
using Xunit;

namespace QSS.eIQC.DataAccess.UnitTests.MoqData
{
    public class PartDimensionMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public PartDimensionMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(PartDimension entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            
            {
                qssContext.PartDimension.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
