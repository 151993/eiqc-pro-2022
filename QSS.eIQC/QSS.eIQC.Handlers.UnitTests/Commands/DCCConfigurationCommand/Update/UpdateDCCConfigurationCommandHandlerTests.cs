/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateDCCConfigurationCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update DCCConfiguration";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateDCCConfigurationCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateDCCConfigurationModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());

            var dCCConfiguration = mapper.Map<DCCConfiguration>(autoMoqData);
            DCCConfigurationMoq dCCConfigurationMoq = new DCCConfigurationMoq(fixture);
            dCCConfigurationMoq.MoqData(dCCConfiguration);
            autoMoqData.SiteNo = UpdatedValue;
            autoMoqData.LastUpdated = dCCConfiguration.LastUpdated;

            DCCConfigurationModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateDCCConfigurationCommandHandler handler = new UpdateDCCConfigurationCommandHandler(qssContext, new DCCConfigurationRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DCCConfigurationModel>(result);
            Assert.Equal(UpdatedValue, result.SiteNo);
        }

        [Fact]
        public async Task HandleWithNullDCCConfigurationObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());
          
            UpdateDCCConfigurationCommandHandler handler = new UpdateDCCConfigurationCommandHandler(fixture.qssContext, new DCCConfigurationRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        //[Theory, AutoMoqData]
        //public async Task HandleWithDCCConfigurationIdNotExistTest(UpdateDCCConfigurationModel autoMoqData)
        //{
        //    //Arrange
        //    int UpdatedId = 10;
        //    //auto mapper configuration
        //    AutoMapping autoMapping = new AutoMapping();
        //    var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());

        //    var dCCConfiguration = mapper.Map<DCCConfiguration>(autoMoqData);
        //    DCCConfigurationMoq dCCConfigurationMoq = new DCCConfigurationMoq(fixture);
        //    autoMoqData.SiteNo = UpdatedValue;
        //    autoMoqData.Id = UpdatedId;

        //    UpdateDCCConfigurationCommandHandler handler = new UpdateDCCConfigurationCommandHandler(fixture.qssContext, new DCCConfigurationRepository(fixture.qssContext), mapper);
        //    //Act
        //    Task act() => handler.Handle(autoMoqData, CancellationToken.None);

        //    ////Assert
        //    await Assert.ThrowsAsync<Exception>(act);
        //    var exception = Assert.ThrowsAsync<Exception>(() => act());
        //    Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);

        //}
    }
}
