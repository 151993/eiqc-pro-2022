/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddPartInspectionDrawingAttachmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddPartInspectionDrawingAttachmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }



        [Theory, AutoMoqData]
        public async Task HandleWithNullPartInspectionDrawingAttachmentObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionDrawingAttachmentCommand.MappingProfile());

            AddPartInspectionDrawingAttachmentCommandHandler handler = new AddPartInspectionDrawingAttachmentCommandHandler(fixture.qssContext, mapper, new PartInspectionDrawingAttachmentRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
