/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Add;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeletePartDimensionCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeletePartDimensionCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddPartDimensionModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartDimensionCommand.MappingProfile());

            var partDimension = mapper.Map<PartDimension>(autoMoqData);
            PartDimensionMoq partDimensionMoq = new PartDimensionMoq(fixture);
            partDimensionMoq.MoqData(partDimension);

            DeletePartDimensionModel deleterequest = new DeletePartDimensionModel()
            {
                ChangeReason = changeReason,
                Id = partDimension.Id
            };
            DeletePartDimensionResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeletePartDimensionCommandHandler handler = new DeletePartDimensionCommandHandler(qssContext, new PartDimensionRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeletePartDimensionResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullPartDimensionObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartDimensionCommand.MappingProfile());

            DeletePartDimensionCommandHandler handler = new DeletePartDimensionCommandHandler(fixture.qssContext, new PartDimensionRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithPartDimensionIdNotExistTest(DeletePartDimensionModel deletePartDimensionModel)
        {
            //Arrange
            int DeletedId = -1;
            deletePartDimensionModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartDimensionCommand.MappingProfile());

            DeletePartDimensionCommandHandler handler = new DeletePartDimensionCommandHandler(fixture.qssContext, new PartDimensionRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deletePartDimensionModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
