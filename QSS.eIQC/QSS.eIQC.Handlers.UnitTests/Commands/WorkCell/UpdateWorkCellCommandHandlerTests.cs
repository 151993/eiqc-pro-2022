using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateWorkCellCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update WorkCell";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateWorkCellCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateWorkCellModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());

            var workCell = mapper.Map<WorkCell>(autoMoqData);
            WorkCellMoq workCellMoq = new WorkCellMoq(fixture);
            workCellMoq.MoqData(workCell);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = workCell.LastUpdated;

            WorkCellModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateWorkCellCommandHandler handler = new UpdateWorkCellCommandHandler(qssContext, new WorkCellRepository(qssContext), mapper, null);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<WorkCellModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullWorkCellObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());
          
            UpdateWorkCellCommandHandler handler = new UpdateWorkCellCommandHandler(fixture.qssContext, new WorkCellRepository(fixture.qssContext), mapper, null);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithWorkCellIdNotExistTest(UpdateWorkCellModel autoMoqData)
        {
            //Arrange
            int UpdatedId = 10;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());

            var workCell = mapper.Map<WorkCell>(autoMoqData);
            WorkCellMoq workCellMoq = new WorkCellMoq(fixture);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.Id = UpdatedId;

            UpdateWorkCellCommandHandler handler = new UpdateWorkCellCommandHandler(fixture.qssContext, new WorkCellRepository(fixture.qssContext), mapper, null);
            //Act
            Task act() => handler.Handle(autoMoqData, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        }
    }
}
