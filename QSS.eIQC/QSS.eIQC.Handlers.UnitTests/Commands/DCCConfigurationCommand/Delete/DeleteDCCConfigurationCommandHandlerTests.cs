/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteDCCConfigurationCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteDCCConfigurationCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddDCCConfigurationModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());

            var dCCConfiguration = mapper.Map<DCCConfiguration>(autoMoqData);
            DCCConfigurationMoq dCCConfigurationMoq = new DCCConfigurationMoq(fixture);
            dCCConfigurationMoq.MoqData(dCCConfiguration);

            DeleteDCCConfigurationModel deleterequest = new DeleteDCCConfigurationModel()
            {
                ChangeReason = changeReason,
                Id = dCCConfiguration.Id
            };
            DeleteDCCConfigurationResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteDCCConfigurationCommandHandler handler = new DeleteDCCConfigurationCommandHandler(qssContext, new DCCConfigurationRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteDCCConfigurationResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullDCCConfigurationObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());

            DeleteDCCConfigurationCommandHandler handler = new DeleteDCCConfigurationCommandHandler(fixture.qssContext, new DCCConfigurationRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithDCCConfigurationIdNotExistTest(DeleteDCCConfigurationModel deleteDCCConfigurationModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteDCCConfigurationModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DCCConfigurationCommand.MappingProfile());

            DeleteDCCConfigurationCommandHandler handler = new DeleteDCCConfigurationCommandHandler(fixture.qssContext, new DCCConfigurationRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteDCCConfigurationModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
