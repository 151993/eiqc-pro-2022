using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Add;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteDepartmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteDepartmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddDepartmentModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());

            var workCell = mapper.Map<Department>(autoMoqData);
            DepartmentMoq workCellMoq = new DepartmentMoq(fixture);
            workCellMoq.MoqData(workCell);

            DeleteDepartmentModel deleterequest = new DeleteDepartmentModel()
            {
                ChangeReason = changeReason,
                Id = workCell.Id
            };
            DeleteDepartmentResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteDepartmentCommandHandler handler = new DeleteDepartmentCommandHandler(qssContext, new DepartmentRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteDepartmentResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullDepartmentObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());

            DeleteDepartmentCommandHandler handler = new DeleteDepartmentCommandHandler(fixture.qssContext, new DepartmentRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithDepartmentIdNotExistTest(DeleteDepartmentModel deleteDepartmentModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteDepartmentModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());

            DeleteDepartmentCommandHandler handler = new DeleteDepartmentCommandHandler(fixture.qssContext, new DepartmentRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteDepartmentModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
