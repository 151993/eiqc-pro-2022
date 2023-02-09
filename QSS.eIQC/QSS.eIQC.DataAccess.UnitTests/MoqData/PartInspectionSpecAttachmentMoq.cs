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
    public class PartInspectionSpecAttachmentMoq : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public PartInspectionSpecAttachmentMoq(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }
        public void MoqData(PartInspectionSpecAttachment entity)
        {  
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))            
            {
                qssContext.PartInspectionSpecAttachment.Add(entity);
                qssContext.SaveChanges();
            }
        }
    }
}
