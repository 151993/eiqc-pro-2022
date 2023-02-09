using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using QSS.eIQC.Handlers.Commands.RoleCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateRoleCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update Role";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateRoleCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateRoleModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RoleCommand.MappingProfile());

            var workCell = mapper.Map<Role>(autoMoqData);
            RoleMoq workCellMoq = new RoleMoq(fixture);
            workCellMoq.MoqData(workCell);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = workCell.LastUpdated;

            RoleModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateRoleCommandHandler handler = new UpdateRoleCommandHandler(qssContext, new RoleRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<RoleModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullRoleObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RoleCommand.MappingProfile());
          
            UpdateRoleCommandHandler handler = new UpdateRoleCommandHandler(fixture.qssContext, new RoleRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithRoleIdNotExistTest(UpdateRoleModel autoMoqData)
        {
            //Arrange
            int UpdatedId = 10;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.RoleCommand.MappingProfile());

            var workCell = mapper.Map<Role>(autoMoqData);
            RoleMoq workCellMoq = new RoleMoq(fixture);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.Id = UpdatedId;

            UpdateRoleCommandHandler handler = new UpdateRoleCommandHandler(fixture.qssContext, new RoleRepository(fixture.qssContext), mapper);
            //Act
            Task act() => handler.Handle(autoMoqData, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        }
    }
}
