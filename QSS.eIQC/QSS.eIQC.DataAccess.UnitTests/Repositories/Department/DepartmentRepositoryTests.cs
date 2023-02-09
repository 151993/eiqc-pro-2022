using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using Moq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class DepartmentRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update Department";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public DepartmentRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.DepartmentCommand.MappingProfile());
        }

        //[Theory, AutoMoqData]
        //public async Task AddAsyncTest(Department department, string changeReason)
        //{
        //    //Arrange
        //    IDepartmentRepository repository = new DepartmentRepository(fixture.qssContext);

        //    //Act
        //    var result = await repository.AddAsync(department, changeReason);

        //    //Assert
        //    Assert.NotNull(result);
        //    Assert.IsAssignableFrom<Department>(result);
        //    Assert.Equal(department.Name, result.Name);
        //    Assert.Equal(department.Id, result.Id);

        //}

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullDepartmentObjectTest(string changeReason)
        {
            //Arrange
            IDepartmentRepository repository = new DepartmentRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddDepartmentModel addDepartmentModel, string changeReason)
        {
            //Arrange
            var department = mapper.Map<Department>(addDepartmentModel);
            DepartmentMoq departmentMoq= new DepartmentMoq(fixture);
            departmentMoq.MoqData(department);
            department.Name = UpdatedValue;
          
            //Act
            Department result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDepartmentRepository repository = new DepartmentRepository(qssContext);
                result = await repository.UpdateAsync(department, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<Department>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullDepartmentObjectTest(string changeReason)
        {
            //Arrange
            IDepartmentRepository repository = new DepartmentRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithDepartmentIdNotExistTest(AddDepartmentModel addDepartmentModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var department = mapper.Map<Department>(addDepartmentModel);
            department.Name = UpdatedValue;
            department.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDepartmentRepository repository = new DepartmentRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(department, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddDepartmentModel addDepartmentModel, string changeReason)
        {
            //Arrange
            var department = mapper.Map<Department>(addDepartmentModel);
            DepartmentMoq departmentMoq = new DepartmentMoq(fixture);
            departmentMoq.MoqData(department);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDepartmentRepository repository = new DepartmentRepository(qssContext);
                result = await repository.RemoveByIdAsync(department.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithDepartmentIdNotExist(string changeReason)
        {
            //Arrange
            IDepartmentRepository repository = new DepartmentRepository(fixture.qssContext);
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
