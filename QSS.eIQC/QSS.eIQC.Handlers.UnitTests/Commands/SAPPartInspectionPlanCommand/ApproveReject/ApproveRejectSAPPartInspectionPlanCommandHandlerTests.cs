/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using MediatR;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using QSS.eIQC.UnitTests.Core;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    /// <summary>
    /// Command Handler for Update SAPPartInspectionPlan operation
    /// </summary>
    public class ApproveRejectSAPPartInspectionPlanCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public ApproveRejectSAPPartInspectionPlanCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }



        [Theory, AutoMoqData]
        public async Task HandleWithNullApproveRejectSAPPartInspectionPlanObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.SAPPartInspectionPlanCommand.MappingProfile());

            ApproveRejectSAPPartInspectionPlanCommandHandler handler = new ApproveRejectSAPPartInspectionPlanCommandHandler(fixture.qssContext,
                new SAPPartInspectionPlanRepository(fixture.qssContext), mapper);

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
