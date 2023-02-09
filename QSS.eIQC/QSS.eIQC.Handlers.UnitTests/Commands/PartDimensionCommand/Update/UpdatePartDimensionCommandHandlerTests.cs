/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdatePartDimensionCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update PartDimension";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdatePartDimensionCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdatePartDimensionModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartDimensionCommand.MappingProfile());

            var partDimension = mapper.Map<PartDimension>(autoMoqData);
            PartDimensionMoq partDimensionMoq = new PartDimensionMoq(fixture);
            partDimensionMoq.MoqData(partDimension);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = partDimension.LastUpdated;

            PartDimensionModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdatePartDimensionCommandHandler handler = new UpdatePartDimensionCommandHandler(qssContext, new PartDimensionRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartDimensionModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullPartDimensionObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.PartDimensionCommand.MappingProfile());
          
            UpdatePartDimensionCommandHandler handler = new UpdatePartDimensionCommandHandler(fixture.qssContext, new PartDimensionRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        //[Theory, AutoMoqData]
        //public async Task HandleWithPartDimensionIdNotExistTest(UpdatePartDimensionModel autoMoqData)
        //{
        //    //Arrange
        //    int UpdatedId = 10;
        //    //auto mapper configuration
        //    AutoMapping autoMapping = new AutoMapping();
        //    var mapper = autoMapping.GetMapper(new Commands.PartDimensionCommand.MappingProfile());

        //    var partDimension = mapper.Map<PartDimension>(autoMoqData);
        //    PartDimensionMoq partDimensionMoq = new PartDimensionMoq(fixture);
        //    autoMoqData.Name = UpdatedValue;
        //    autoMoqData.Id = UpdatedId;

        //    UpdatePartDimensionCommandHandler handler = new UpdatePartDimensionCommandHandler(fixture.qssContext, new PartDimensionRepository(fixture.qssContext), mapper);
        //    //Act
        //    Task act() => handler.Handle(autoMoqData, CancellationToken.None);

        //    ////Assert
        //    await Assert.ThrowsAsync<Exception>(act);
        //    var exception = Assert.ThrowsAsync<Exception>(() => act());
        //    Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        //}
    }
}
