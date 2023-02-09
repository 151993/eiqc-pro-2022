using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RegionCommand;
using QSS.eIQC.Handlers.Commands.RegionCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateRegionCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update Region";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateRegionCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateRegionModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RegionCommand.MappingProfile());

            var workCell = mapper.Map<Region>(autoMoqData);
            RegionMoq workCellMoq = new RegionMoq(fixture);
            workCellMoq.MoqData(workCell);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = workCell.LastUpdated;

            RegionModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateRegionCommandHandler handler = new UpdateRegionCommandHandler(qssContext, new RegionRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<RegionModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullRegionObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RegionCommand.MappingProfile());
          
            UpdateRegionCommandHandler handler = new UpdateRegionCommandHandler(fixture.qssContext, new RegionRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        //[Theory, AutoMoqData]
        //public async Task HandleWithRegionIdNotExistTest(UpdateRegionModel autoMoqData)
        //{
        //    //Arrange
        //    int UpdatedId = 10;
        //    //auto mapper configuration
        //    AutoMapping autoMapping = new AutoMapping();
        //    var mapper = autoMapping.GetMapper(new Commands.RegionCommand.MappingProfile());

        //    var workCell = mapper.Map<Region>(autoMoqData);
        //    RegionMoq workCellMoq = new RegionMoq(fixture);
        //    autoMoqData.Name = UpdatedValue;
        //    autoMoqData.Id = UpdatedId;

        //    UpdateRegionCommandHandler handler = new UpdateRegionCommandHandler(fixture.qssContext, new RegionRepository(fixture.qssContext), mapper);
        //    //Act
        //    Task act() => handler.Handle(autoMoqData, CancellationToken.None);

        //    ////Assert
        //    await Assert.ThrowsAsync<Exception>(act);
        //    var exception = Assert.ThrowsAsync<Exception>(() => act());
        //    Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        //}
    }
}
