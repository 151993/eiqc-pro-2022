/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddDCCConfigurationCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddDCCConfigurationCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(AddDCCConfigurationModel autoMoqData, CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper= autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());
          
            AddDCCConfigurationCommandHandler handler = new AddDCCConfigurationCommandHandler(fixture.qssContext, new DCCConfigurationRepository(fixture.qssContext), mapper);
            
            //Act
            var result = await handler.Handle(autoMoqData, cancellationToken);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DCCConfigurationModel>(result);
            Assert.Equal(autoMoqData.SiteNo, result.SiteNo);

        }

        [Theory, AutoMoqData]
        public async Task HandleWithNullDCCConfigurationObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());

            AddDCCConfigurationCommandHandler handler = new AddDCCConfigurationCommandHandler(fixture.qssContext, new DCCConfigurationRepository(fixture.qssContext), mapper);

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
