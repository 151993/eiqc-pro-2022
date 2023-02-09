/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateBowTwistFormulaCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update BowTwistFormula";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateBowTwistFormulaCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateBowTwistFormulaModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());

            var bowTwistFormula = mapper.Map<BowTwistFormula>(autoMoqData);
            BowTwistFormulaMoq bowTwistFormulaMoq = new BowTwistFormulaMoq(fixture);
            bowTwistFormulaMoq.MoqData(bowTwistFormula);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = bowTwistFormula.LastUpdated;

            BowTwistFormulaModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateBowTwistFormulaCommandHandler handler = new UpdateBowTwistFormulaCommandHandler(qssContext, new BowTwistFormulaRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<BowTwistFormulaModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullBowTwistFormulaObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());
          
            UpdateBowTwistFormulaCommandHandler handler = new UpdateBowTwistFormulaCommandHandler(fixture.qssContext, new BowTwistFormulaRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithBowTwistFormulaIdNotExistTest(UpdateBowTwistFormulaModel autoMoqData)
        {
            //Arrange
            int UpdatedId = 10;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());

            var bowTwistFormula = mapper.Map<BowTwistFormula>(autoMoqData);
            BowTwistFormulaMoq bowTwistFormulaMoq = new BowTwistFormulaMoq(fixture);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.Id = UpdatedId;

            UpdateBowTwistFormulaCommandHandler handler = new UpdateBowTwistFormulaCommandHandler(fixture.qssContext, new BowTwistFormulaRepository(fixture.qssContext), mapper);
            //Act
            Task act() => handler.Handle(autoMoqData, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        }
    }
}
