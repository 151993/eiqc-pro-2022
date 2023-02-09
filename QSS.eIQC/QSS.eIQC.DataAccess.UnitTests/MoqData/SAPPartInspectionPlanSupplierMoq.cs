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
    public class SAPPartInspectionPlanSupplierMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public SAPPartInspectionPlanSupplierMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(SAPPartInspectionPlanSupplier entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            
            {
                qssContext.SAPPartInspectionPlanSupplier.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
