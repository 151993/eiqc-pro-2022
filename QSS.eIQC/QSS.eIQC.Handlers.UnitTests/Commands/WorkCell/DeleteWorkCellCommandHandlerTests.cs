using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Add;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteWorkCellCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteWorkCellCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddWorkCellModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());

            var workCell = mapper.Map<WorkCell>(autoMoqData);
            WorkCellMoq workCellMoq = new WorkCellMoq(fixture);
            workCellMoq.MoqData(workCell);

            DeleteWorkCellModel deleterequest = new DeleteWorkCellModel()
            {
                ChangeReason = changeReason,
                Id = workCell.Id
            };
            DeleteWorkCellResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteWorkCellCommandHandler handler = new DeleteWorkCellCommandHandler(qssContext, new WorkCellRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteWorkCellResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullWorkCellObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());

            DeleteWorkCellCommandHandler handler = new DeleteWorkCellCommandHandler(fixture.qssContext, new WorkCellRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithWorkCellIdNotExistTest(DeleteWorkCellModel deleteWorkCellModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteWorkCellModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());

            DeleteWorkCellCommandHandler handler = new DeleteWorkCellCommandHandler(fixture.qssContext, new WorkCellRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteWorkCellModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
