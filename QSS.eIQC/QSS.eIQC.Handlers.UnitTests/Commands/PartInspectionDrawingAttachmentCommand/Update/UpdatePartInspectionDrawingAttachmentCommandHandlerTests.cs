/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdatePartInspectionDrawingAttachmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update PartInspectionDrawingAttachment";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdatePartInspectionDrawingAttachmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Fact]
        public async Task HandleWithNullPartInspectionDrawingAttachmentObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionDrawingAttachmentCommand.MappingProfile());
          
            UpdatePartInspectionDrawingAttachmentCommandHandler handler = new UpdatePartInspectionDrawingAttachmentCommandHandler(fixture.qssContext, mapper, new PartInspectionDrawingAttachmentRepository(fixture.qssContext) );
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

    }
}
