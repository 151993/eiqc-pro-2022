/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddPartInspectionSpecAttachmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddPartInspectionSpecAttachmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }



        [Theory, AutoMoqData]
        public async Task HandleWithNullPartInspectionSpecAttachmentObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionSpecAttachmentCommand.MappingProfile());

            AddPartInspectionSpecAttachmentCommandHandler handler = new AddPartInspectionSpecAttachmentCommandHandler(fixture.qssContext, mapper, new PartInspectionSpecAttachmentRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
