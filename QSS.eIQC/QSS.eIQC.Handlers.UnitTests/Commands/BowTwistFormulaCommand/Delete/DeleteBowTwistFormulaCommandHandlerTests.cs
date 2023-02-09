/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteBowTwistFormulaCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteBowTwistFormulaCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddBowTwistFormulaModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());

            var bowTwistFormula = mapper.Map<BowTwistFormula>(autoMoqData);
            BowTwistFormulaMoq bowTwistFormulaMoq = new BowTwistFormulaMoq(fixture);
            bowTwistFormulaMoq.MoqData(bowTwistFormula);

            DeleteBowTwistFormulaModel deleterequest = new DeleteBowTwistFormulaModel()
            {
                ChangeReason = changeReason,
                Id = bowTwistFormula.Id
            };
            DeleteBowTwistFormulaResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteBowTwistFormulaCommandHandler handler = new DeleteBowTwistFormulaCommandHandler(qssContext, new BowTwistFormulaRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteBowTwistFormulaResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullBowTwistFormulaObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());

            DeleteBowTwistFormulaCommandHandler handler = new DeleteBowTwistFormulaCommandHandler(fixture.qssContext, new BowTwistFormulaRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithBowTwistFormulaIdNotExistTest(DeleteBowTwistFormulaModel deleteBowTwistFormulaModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteBowTwistFormulaModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.BowTwistFormulaCommand.MappingProfile());

            DeleteBowTwistFormulaCommandHandler handler = new DeleteBowTwistFormulaCommandHandler(fixture.qssContext, new BowTwistFormulaRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteBowTwistFormulaModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
