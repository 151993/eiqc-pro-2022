using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateDepartmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update Department";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateDepartmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateDepartmentModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());

            var workCell = mapper.Map<Department>(autoMoqData);
            DepartmentMoq workCellMoq = new DepartmentMoq(fixture);
            workCellMoq.MoqData(workCell);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = workCell.LastUpdated;

            DepartmentModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateDepartmentCommandHandler handler = new UpdateDepartmentCommandHandler(qssContext, new DepartmentRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DepartmentModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullDepartmentObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());
          
            UpdateDepartmentCommandHandler handler = new UpdateDepartmentCommandHandler(fixture.qssContext, new DepartmentRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        //[Theory, AutoMoqData]
        //public async Task HandleWithDepartmentIdNotExistTest(UpdateDepartmentModel autoMoqData)
        //{
        //    //Arrange
        //    int UpdatedId = 10;
        //    //auto mapper configuration
        //    AutoMapping autoMapping = new AutoMapping();
        //    var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());

        //    var workCell = mapper.Map<Department>(autoMoqData);
        //    DepartmentMoq workCellMoq = new DepartmentMoq(fixture);
        //    autoMoqData.Name = UpdatedValue;
        //    autoMoqData.Id = UpdatedId;

        //    UpdateDepartmentCommandHandler handler = new UpdateDepartmentCommandHandler(fixture.qssContext, new DepartmentRepository(fixture.qssContext), mapper);
        //    //Act
        //    Task act() => handler.Handle(autoMoqData, CancellationToken.None);

        //    ////Assert
        //    await Assert.ThrowsAsync<Exception>(act);
        //    var exception = Assert.ThrowsAsync<Exception>(() => act());
        //    Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        //}
    }
}
