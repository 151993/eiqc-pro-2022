using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.CountryCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using Moq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class CountryRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update Country";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public CountryRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.CountryCommand.MappingProfile());
        }

        //[Theory, AutoMoqData]
        //public async Task AddAsyncTest(Country country, string changeReason)
        //{
        //    //Arrange
        //    ICountryRepository repository = new CountryRepository(fixture.qssContext);

        //    //Act
        //    var result = await repository.AddAsync(country, changeReason);

        //    //Assert
        //    Assert.NotNull(result);
        //    Assert.IsAssignableFrom<Country>(result);
        //    Assert.Equal(country.Name, result.Name);
        //    Assert.Equal(country.Id, result.Id);

        //}

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullCountryObjectTest(string changeReason)
        {
            //Arrange
            ICountryRepository repository = new CountryRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddCountryModel addCountryModel, string changeReason)
        {
            //Arrange
            var country = mapper.Map<Country>(addCountryModel);
            CountryMoq countryMoq= new CountryMoq(fixture);
            countryMoq.MoqData(country);
            country.Name = UpdatedValue;
          
            //Act
            Country result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ICountryRepository repository = new CountryRepository(qssContext);
                result = await repository.UpdateAsync(country, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<Country>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullCountryObjectTest(string changeReason)
        {
            //Arrange
            ICountryRepository repository = new CountryRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithCountryIdNotExistTest(AddCountryModel addCountryModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var country = mapper.Map<Country>(addCountryModel);
            country.Name = UpdatedValue;
            country.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ICountryRepository repository = new CountryRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(country, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddCountryModel addCountryModel, string changeReason)
        {
            //Arrange
            var country = mapper.Map<Country>(addCountryModel);
            CountryMoq countryMoq = new CountryMoq(fixture);
            countryMoq.MoqData(country);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ICountryRepository repository = new CountryRepository(qssContext);
                result = await repository.RemoveByIdAsync(country.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithCountryIdNotExist(string changeReason)
        {
            //Arrange
            ICountryRepository repository = new CountryRepository(fixture.qssContext);
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
