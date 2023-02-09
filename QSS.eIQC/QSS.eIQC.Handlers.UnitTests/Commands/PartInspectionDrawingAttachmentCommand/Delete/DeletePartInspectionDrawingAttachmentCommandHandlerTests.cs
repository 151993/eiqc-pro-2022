/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeletePartInspectionDrawingAttachmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeletePartInspectionDrawingAttachmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddPartInspectionDrawingAttachmentModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionDrawingAttachmentCommand.MappingProfile());

            var partInspectionDrawingAttachment = mapper.Map<PartInspectionDrawingAttachment>(autoMoqData);
            PartInspectionDrawingAttachmentMoq partInspectionDrawingAttachmentMoq = new PartInspectionDrawingAttachmentMoq(fixture);
            partInspectionDrawingAttachmentMoq.MoqData(partInspectionDrawingAttachment);

            DeletePartInspectionDrawingAttachmentModel deleterequest = new DeletePartInspectionDrawingAttachmentModel()
            {
                ChangeReason = changeReason,
                Id = partInspectionDrawingAttachment.Id
            };
            DeletePartInspectionDrawingAttachmentResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeletePartInspectionDrawingAttachmentCommandHandler handler = new DeletePartInspectionDrawingAttachmentCommandHandler(qssContext, new PartInspectionDrawingAttachmentRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeletePartInspectionDrawingAttachmentResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullPartInspectionDrawingAttachmentObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionDrawingAttachmentCommand.MappingProfile());

            DeletePartInspectionDrawingAttachmentCommandHandler handler = new DeletePartInspectionDrawingAttachmentCommandHandler(fixture.qssContext, new PartInspectionDrawingAttachmentRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithPartInspectionDrawingAttachmentIdNotExistTest(DeletePartInspectionDrawingAttachmentModel deletePartInspectionDrawingAttachmentModel)
        {
            //Arrange
            int DeletedId = -1;
            deletePartInspectionDrawingAttachmentModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionDrawingAttachmentCommand.MappingProfile());

            DeletePartInspectionDrawingAttachmentCommandHandler handler = new DeletePartInspectionDrawingAttachmentCommandHandler(fixture.qssContext, new PartInspectionDrawingAttachmentRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deletePartInspectionDrawingAttachmentModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
