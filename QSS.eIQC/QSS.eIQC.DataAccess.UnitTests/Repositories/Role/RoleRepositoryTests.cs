using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using Moq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class RoleRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update Role";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public RoleRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.RoleCommand.MappingProfile());
        }

        //[Theory, AutoMoqData]
        //public async Task AddAsyncTest(Role role, string changeReason)
        //{
        //    //Arrange
        //    IRoleRepository repository = new RoleRepository(fixture.qssContext);

        //    //Act
        //    var result = await repository.AddAsync(role, changeReason);

        //    //Assert
        //    Assert.NotNull(result);
        //    Assert.IsAssignableFrom<Role>(result);
        //    Assert.Equal(role.Name, result.Name);
        //    Assert.Equal(role.Id, result.Id);

        //}

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullRoleObjectTest(string changeReason)
        {
            //Arrange
            IRoleRepository repository = new RoleRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddRoleModel addRoleModel, string changeReason)
        {
            //Arrange
            var role = mapper.Map<Role>(addRoleModel);
            RoleMoq roleMoq= new RoleMoq(fixture);
            roleMoq.MoqData(role);
            role.Name = UpdatedValue;
          
            //Act
            Role result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IRoleRepository repository = new RoleRepository(qssContext);
                result = await repository.UpdateAsync(role, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<Role>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullRoleObjectTest(string changeReason)
        {
            //Arrange
            IRoleRepository repository = new RoleRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithRoleIdNotExistTest(AddRoleModel addRoleModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var role = mapper.Map<Role>(addRoleModel);
            role.Name = UpdatedValue;
            role.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IRoleRepository repository = new RoleRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(role, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddRoleModel addRoleModel, string changeReason)
        {
            //Arrange
            var role = mapper.Map<Role>(addRoleModel);
            RoleMoq roleMoq = new RoleMoq(fixture);
            roleMoq.MoqData(role);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IRoleRepository repository = new RoleRepository(qssContext);
                result = await repository.RemoveByIdAsync(role.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithRoleIdNotExist(string changeReason)
        {
            //Arrange
            IRoleRepository repository = new RoleRepository(fixture.qssContext);
            int DeleteId = -1;
            //Act
            Task act() => repository.RemoveByIdAsync(DeleteId, changeReason);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeleteId.ToString()), exception.Result.Message);

        }
       
    }
}
