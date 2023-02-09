/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeletePartInspectionSpecAttachmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeletePartInspectionSpecAttachmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddPartInspectionSpecAttachmentModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionSpecAttachmentCommand.MappingProfile());

            var partInspectionSpecAttachment = mapper.Map<PartInspectionSpecAttachment>(autoMoqData);
            PartInspectionSpecAttachmentMoq partInspectionSpecAttachmentMoq = new PartInspectionSpecAttachmentMoq(fixture);
            partInspectionSpecAttachmentMoq.MoqData(partInspectionSpecAttachment);

            DeletePartInspectionSpecAttachmentModel deleterequest = new DeletePartInspectionSpecAttachmentModel()
            {
                ChangeReason = changeReason,
                Id = partInspectionSpecAttachment.Id
            };
            DeletePartInspectionSpecAttachmentResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeletePartInspectionSpecAttachmentCommandHandler handler = new DeletePartInspectionSpecAttachmentCommandHandler(qssContext, new PartInspectionSpecAttachmentRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeletePartInspectionSpecAttachmentResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullPartInspectionSpecAttachmentObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionSpecAttachmentCommand.MappingProfile());

            DeletePartInspectionSpecAttachmentCommandHandler handler = new DeletePartInspectionSpecAttachmentCommandHandler(fixture.qssContext, new PartInspectionSpecAttachmentRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithPartInspectionSpecAttachmentIdNotExistTest(DeletePartInspectionSpecAttachmentModel deletePartInspectionSpecAttachmentModel)
        {
            //Arrange
            int DeletedId = -1;
            deletePartInspectionSpecAttachmentModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartInspectionSpecAttachmentCommand.MappingProfile());

            DeletePartInspectionSpecAttachmentCommandHandler handler = new DeletePartInspectionSpecAttachmentCommandHandler(fixture.qssContext, new PartInspectionSpecAttachmentRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deletePartInspectionSpecAttachmentModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
