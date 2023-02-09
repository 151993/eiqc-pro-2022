/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdatePartInspectionSpecAttachmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update PartInspectionSpecAttachment";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdatePartInspectionSpecAttachmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task HandleWithNullPartInspectionSpecAttachmentObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionSpecAttachmentCommand.MappingProfile());
          
            UpdatePartInspectionSpecAttachmentCommandHandler handler = new UpdatePartInspectionSpecAttachmentCommandHandler(fixture.qssContext, mapper, new PartInspectionSpecAttachmentRepository(fixture.qssContext));
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

    }
}
