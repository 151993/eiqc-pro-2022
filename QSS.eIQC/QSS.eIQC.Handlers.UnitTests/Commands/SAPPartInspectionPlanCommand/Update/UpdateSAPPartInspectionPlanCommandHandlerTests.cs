/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateSAPPartInspectionPlanCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update SAPPartInspectionPlan";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateSAPPartInspectionPlanCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task HandleWithNullSAPPartInspectionPlanObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.SAPPartInspectionPlanCommand.MappingProfile());

            UpdateSAPPartInspectionPlanCommandHandler handler = new UpdateSAPPartInspectionPlanCommandHandler(fixture.qssContext,
                new SAPPartInspectionPlanRepository(fixture.qssContext), mapper,
                new SAPPartInspectionPlanSupplierRepository(fixture.qssContext),
                new SAPPartInspectionPlanAdminCertificationRepository(fixture.qssContext),
                new PartInspectionDrawingAttachmentRepository(fixture.qssContext),
                new PartInspectionSpecAttachmentRepository(fixture.qssContext)
                , null
                ,new PartInspectionCertificationAttachmentRepository(fixture.qssContext)
                , new PartMPositionToleranceRepository(fixture.qssContext)
                , new PartLPositionToleranceRepository(fixture.qssContext)
                , new PartMeasurementParameterRepository(fixture.qssContext)
                , new PartMicrosectionRepository(fixture.qssContext)
                , new PartFunParameterRepository(fixture.qssContext)
                , new PartResultOrientedParameterRepository(fixture.qssContext),
                 new PartInspectionBowTwistParameterRepository(fixture.qssContext),
                 new PartTestReportParameterRepository(fixture.qssContext),
                 new PartTestReportAttachmentRepository(fixture.qssContext),
                 new PartDateCodeRepository(fixture.qssContext),
                 new PartCountParameterRepository(fixture.qssContext),
                 new PartInspectionSpecificationRepository(fixture.qssContext),
                 new PartInspectionDrawingRepository(fixture.qssContext),
                 new SAPPartInspectionPlanSamplingPlanRepository(fixture.qssContext)
                );

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }
    }
}
