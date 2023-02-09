/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class DCCConfigurationRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update DCCConfiguration";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public DCCConfigurationRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.DCCConfigurationCommand.MappingProfile());
        }

        [Theory, AutoMoqData]
        public async Task AddAsyncTest(DCCConfiguration dCCConfiguration, string changeReason)
        {
            //Arrange
            IDCCConfigurationRepository repository = new DCCConfigurationRepository(fixture.qssContext);

            //Act
            var result = await repository.AddAsync(dCCConfiguration, changeReason);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DCCConfiguration>(result);
            Assert.Equal(dCCConfiguration.SiteNo, result.SiteNo);
            Assert.Equal(dCCConfiguration.Id, result.Id);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullDCCConfigurationObjectTest(string changeReason)
        {
            //Arrange
            IDCCConfigurationRepository repository = new DCCConfigurationRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddDCCConfigurationModel addDCCConfigurationModel, string changeReason)
        {
            //Arrange
            var dCCConfiguration = mapper.Map<DCCConfiguration>(addDCCConfigurationModel);
            DCCConfigurationMoq dCCConfigurationMoq= new DCCConfigurationMoq(fixture);
            dCCConfigurationMoq.MoqData(dCCConfiguration);
            dCCConfiguration.SiteNo = UpdatedValue;
          
            //Act
            DCCConfiguration result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDCCConfigurationRepository repository = new DCCConfigurationRepository(qssContext);
                result = await repository.UpdateAsync(dCCConfiguration, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DCCConfiguration>(result);
            Assert.Equal(UpdatedValue, result.SiteNo);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullDCCConfigurationObjectTest(string changeReason)
        {
            //Arrange
            IDCCConfigurationRepository repository = new DCCConfigurationRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithDCCConfigurationIdNotExistTest(AddDCCConfigurationModel addDCCConfigurationModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var dCCConfiguration = mapper.Map<DCCConfiguration>(addDCCConfigurationModel);
            dCCConfiguration.SiteNo = UpdatedValue;
            dCCConfiguration.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDCCConfigurationRepository repository = new DCCConfigurationRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(dCCConfiguration, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddDCCConfigurationModel addDCCConfigurationModel, string changeReason)
        {
            //Arrange
            var dCCConfiguration = mapper.Map<DCCConfiguration>(addDCCConfigurationModel);
            DCCConfigurationMoq dCCConfigurationMoq = new DCCConfigurationMoq(fixture);
            dCCConfigurationMoq.MoqData(dCCConfiguration);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IDCCConfigurationRepository repository = new DCCConfigurationRepository(qssContext);
                result = await repository.RemoveByIdAsync(dCCConfiguration.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithDCCConfigurationIdNotExist(string changeReason)
        {
            //Arrange
            IDCCConfigurationRepository repository = new DCCConfigurationRepository(fixture.qssContext);
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
