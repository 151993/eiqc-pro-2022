using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Add;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteDivisionCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteDivisionCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddDivisionModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DivisionCommand.MappingProfile());

            var workCell = mapper.Map<Division>(autoMoqData);
            DivisionMoq workCellMoq = new DivisionMoq(fixture);
            workCellMoq.MoqData(workCell);

            DeleteDivisionModel deleterequest = new DeleteDivisionModel()
            {
                ChangeReason = changeReason,
                Id = workCell.Id
            };
            DeleteDivisionResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteDivisionCommandHandler handler = new DeleteDivisionCommandHandler(qssContext, new DivisionRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteDivisionResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullDivisionObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DivisionCommand.MappingProfile());

            DeleteDivisionCommandHandler handler = new DeleteDivisionCommandHandler(fixture.qssContext, new DivisionRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithDivisionIdNotExistTest(DeleteDivisionModel deleteDivisionModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteDivisionModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DivisionCommand.MappingProfile());

            DeleteDivisionCommandHandler handler = new DeleteDivisionCommandHandler(fixture.qssContext, new DivisionRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteDivisionModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
