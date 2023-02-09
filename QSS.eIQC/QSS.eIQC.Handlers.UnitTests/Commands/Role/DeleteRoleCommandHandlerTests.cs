using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using QSS.eIQC.Handlers.Commands.RoleCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteRoleCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteRoleCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddRoleModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RoleCommand.MappingProfile());

            var workCell = mapper.Map<Role>(autoMoqData);
            RoleMoq workCellMoq = new RoleMoq(fixture);
            workCellMoq.MoqData(workCell);

            DeleteRoleModel deleterequest = new DeleteRoleModel()
            {
                ChangeReason = changeReason,
                Id = workCell.Id
            };
            DeleteRoleResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteRoleCommandHandler handler = new DeleteRoleCommandHandler(qssContext, new RoleRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteRoleResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullRoleObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RoleCommand.MappingProfile());

            DeleteRoleCommandHandler handler = new DeleteRoleCommandHandler(fixture.qssContext, new RoleRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithRoleIdNotExistTest(DeleteRoleModel deleteRoleModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteRoleModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RoleCommand.MappingProfile());

            DeleteRoleCommandHandler handler = new DeleteRoleCommandHandler(fixture.qssContext, new RoleRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteRoleModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
