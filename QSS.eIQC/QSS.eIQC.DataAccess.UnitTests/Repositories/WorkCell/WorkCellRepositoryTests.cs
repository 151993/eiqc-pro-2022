using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using Moq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class WorkCellRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update WorkCell";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public WorkCellRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.WorkCellCommand.MappingProfile());
        }

        //[Theory, AutoMoqData]
        //public async Task AddAsyncTest(WorkCell workCell, string changeReason)
        //{
        //    //Arrange
        //    IWorkCellRepository repository = new WorkCellRepository(fixture.qssContext);

        //    //Act
        //    var result = await repository.AddAsync(workCell, changeReason);

        //    //Assert
        //    Assert.NotNull(result);
        //    Assert.IsAssignableFrom<WorkCell>(result);
        //    Assert.Equal(workCell.Name, result.Name);
        //    Assert.Equal(workCell.Id, result.Id);

        //}

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullWorkCellObjectTest(string changeReason)
        {
            //Arrange
            IWorkCellRepository repository = new WorkCellRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddWorkCellModel addWorkCellModel, string changeReason)
        {
            //Arrange
            var workCell = mapper.Map<WorkCell>(addWorkCellModel);
            WorkCellMoq workCellMoq= new WorkCellMoq(fixture);
            workCellMoq.MoqData(workCell);
            workCell.Name = UpdatedValue;
          
            //Act
            WorkCell result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IWorkCellRepository repository = new WorkCellRepository(qssContext);
                result = await repository.UpdateAsync(workCell, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<WorkCell>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullWorkCellObjectTest(string changeReason)
        {
            //Arrange
            IWorkCellRepository repository = new WorkCellRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithWorkCellIdNotExistTest(AddWorkCellModel addWorkCellModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var workCell = mapper.Map<WorkCell>(addWorkCellModel);
            workCell.Name = UpdatedValue;
            workCell.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IWorkCellRepository repository = new WorkCellRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(workCell, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddWorkCellModel addWorkCellModel, string changeReason)
        {
            //Arrange
            var workCell = mapper.Map<WorkCell>(addWorkCellModel);
            WorkCellMoq workCellMoq = new WorkCellMoq(fixture);
            workCellMoq.MoqData(workCell);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IWorkCellRepository repository = new WorkCellRepository(qssContext);
                result = await repository.RemoveByIdAsync(workCell.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithWorkCellIdNotExist(string changeReason)
        {
            //Arrange
            IWorkCellRepository repository = new WorkCellRepository(fixture.qssContext);
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
