/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddBowTwistFormulaCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddBowTwistFormulaCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(AddBowTwistFormulaModel autoMoqData, CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper= autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());
          
            AddBowTwistFormulaCommandHandler handler = new AddBowTwistFormulaCommandHandler(fixture.qssContext, new BowTwistFormulaRepository(fixture.qssContext), mapper);
            
            //Act
            var result = await handler.Handle(autoMoqData, cancellationToken);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<BowTwistFormulaModel>(result);
            Assert.Equal(autoMoqData.Name, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task HandleWithNullBowTwistFormulaObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());

            AddBowTwistFormulaCommandHandler handler = new AddBowTwistFormulaCommandHandler(fixture.qssContext, new BowTwistFormulaRepository(fixture.qssContext), mapper);

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
