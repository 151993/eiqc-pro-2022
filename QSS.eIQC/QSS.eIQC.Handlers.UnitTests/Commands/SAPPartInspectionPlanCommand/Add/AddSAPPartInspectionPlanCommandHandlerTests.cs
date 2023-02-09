/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;
using QSS.eIQC.Infrastucture.Core.Services.FileService;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddSAPPartInspectionPlanCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddSAPPartInspectionPlanCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory, AutoMoqData]
        public async Task HandleWithNullSAPPartInspectionPlanObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.SAPPartInspectionPlanCommand.MappingProfile());

            AddSAPPartInspectionPlanCommandHandler handler = new AddSAPPartInspectionPlanCommandHandler(fixture.qssContext,
                new SAPPartInspectionPlanRepository(fixture.qssContext), mapper,
                new SAPPartInspectionPlanSupplierRepository(fixture.qssContext),
                new PartInspectionDrawingAttachmentRepository(fixture.qssContext),
                new PartInspectionSpecAttachmentRepository(fixture.qssContext),
                new SAPPartInspectionPlanAdminCertificationRepository(fixture.qssContext), null
                , new PartInspectionCertificationAttachmentRepository(fixture.qssContext)
                , new PartTestReportAttachmentRepository(fixture.qssContext)
                );

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        } 
    }
}
