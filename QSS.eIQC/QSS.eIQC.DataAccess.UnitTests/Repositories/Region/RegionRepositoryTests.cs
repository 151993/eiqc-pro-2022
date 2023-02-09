using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.RegionCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using Moq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class RegionRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update Region";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public RegionRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.RegionCommand.MappingProfile());
        }

        //[Theory, AutoMoqData]
        //public async Task AddAsyncTest(Region region, string changeReason)
        //{
        //    //Arrange
        //    IRegionRepository repository = new RegionRepository(fixture.qssContext);

        //    //Act
        //    var result = await repository.AddAsync(region, changeReason);

        //    //Assert
        //    Assert.NotNull(result);
        //    Assert.IsAssignableFrom<Region>(result);
        //    Assert.Equal(region.Name, result.Name);
        //    Assert.Equal(region.Id, result.Id);

        //}

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullRegionObjectTest(string changeReason)
        {
            //Arrange
            IRegionRepository repository = new RegionRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddRegionModel addRegionModel, string changeReason)
        {
            //Arrange
            var region = mapper.Map<Region>(addRegionModel);
            RegionMoq regionMoq= new RegionMoq(fixture);
            regionMoq.MoqData(region);
            region.Name = UpdatedValue;
          
            //Act
            Region result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IRegionRepository repository = new RegionRepository(qssContext);
                result = await repository.UpdateAsync(region, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<Region>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullRegionObjectTest(string changeReason)
        {
            //Arrange
            IRegionRepository repository = new RegionRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithRegionIdNotExistTest(AddRegionModel addRegionModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var region = mapper.Map<Region>(addRegionModel);
            region.Name = UpdatedValue;
            region.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IRegionRepository repository = new RegionRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(region, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddRegionModel addRegionModel, string changeReason)
        {
            //Arrange
            var region = mapper.Map<Region>(addRegionModel);
            RegionMoq regionMoq = new RegionMoq(fixture);
            regionMoq.MoqData(region);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IRegionRepository repository = new RegionRepository(qssContext);
                result = await repository.RemoveByIdAsync(region.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithRegionIdNotExist(string changeReason)
        {
            //Arrange
            IRegionRepository repository = new RegionRepository(fixture.qssContext);
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
