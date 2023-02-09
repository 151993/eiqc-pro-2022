using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RegionCommand.Add;
using QSS.eIQC.Handlers.Commands.RegionCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteRegionCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteRegionCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddRegionModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RegionCommand.MappingProfile());

            var region = mapper.Map<Region>(autoMoqData);
            RegionMoq regionMoq = new RegionMoq(fixture);
            regionMoq.MoqData(region);

            DeleteRegionModel deleterequest = new DeleteRegionModel()
            {
                ChangeReason = changeReason,
                Id = region.Id
            };
            DeleteRegionResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteRegionCommandHandler handler = new DeleteRegionCommandHandler(qssContext, new RegionRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteRegionResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullRegionObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RegionCommand.MappingProfile());

            DeleteRegionCommandHandler handler = new DeleteRegionCommandHandler(fixture.qssContext, new RegionRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithRegionIdNotExistTest(DeleteRegionModel deleteRegionModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteRegionModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RegionCommand.MappingProfile());

            DeleteRegionCommandHandler handler = new DeleteRegionCommandHandler(fixture.qssContext, new RegionRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteRegionModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
