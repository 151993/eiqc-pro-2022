using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using Moq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class DivisionRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update Division";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public DivisionRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.DivisionCommand.MappingProfile());
        }

        //[Theory, AutoMoqData]
        //public async Task AddAsyncTest(Division division, string changeReason)
        //{
        //    //Arrange
        //    IDivisionRepository repository = new DivisionRepository(fixture.qssContext);

        //    //Act
        //    var result = await repository.AddAsync(division, changeReason);

        //    //Assert
        //    Assert.NotNull(result);
        //    Assert.IsAssignableFrom<Division>(result);
        //    Assert.Equal(division.Name, result.Name);
        //    Assert.Equal(division.Id, result.Id);

        //}

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullDivisionObjectTest(string changeReason)
        {
            //Arrange
            IDivisionRepository repository = new DivisionRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddDivisionModel addDivisionModel, string changeReason)
        {
            //Arrange
            var division = mapper.Map<Division>(addDivisionModel);
            DivisionMoq divisionMoq= new DivisionMoq(fixture);
            divisionMoq.MoqData(division);
            division.Name = UpdatedValue;
          
            //Act
            Division result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDivisionRepository repository = new DivisionRepository(qssContext);
                result = await repository.UpdateAsync(division, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<Division>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullDivisionObjectTest(string changeReason)
        {
            //Arrange
            IDivisionRepository repository = new DivisionRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithDivisionIdNotExistTest(AddDivisionModel addDivisionModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var division = mapper.Map<Division>(addDivisionModel);
            division.Name = UpdatedValue;
            division.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDivisionRepository repository = new DivisionRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(division, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddDivisionModel addDivisionModel, string changeReason)
        {
            //Arrange
            var division = mapper.Map<Division>(addDivisionModel);
            DivisionMoq divisionMoq = new DivisionMoq(fixture);
            divisionMoq.MoqData(division);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDivisionRepository repository = new DivisionRepository(qssContext);
                result = await repository.RemoveByIdAsync(division.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithDivisionIdNotExist(string changeReason)
        {
            //Arrange
            IDivisionRepository repository = new DivisionRepository(fixture.qssContext);
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
