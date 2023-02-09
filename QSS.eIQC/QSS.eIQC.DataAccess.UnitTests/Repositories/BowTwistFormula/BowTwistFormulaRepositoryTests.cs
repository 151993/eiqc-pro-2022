/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class BowTwistFormulaRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update BowTwistFormula";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public BowTwistFormulaRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.BowTwistFormulaCommand.MappingProfile());
        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullBowTwistFormulaObjectTest(string changeReason)
        {
            //Arrange
            IBowTwistFormulaRepository repository = new BowTwistFormulaRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddBowTwistFormulaModel addBowTwistFormulaModel, string changeReason)
        {
            //Arrange
            var bowTwistFormula = mapper.Map<BowTwistFormula>(addBowTwistFormulaModel);
            BowTwistFormulaMoq bowTwistFormulaMoq= new BowTwistFormulaMoq(fixture);
            bowTwistFormulaMoq.MoqData(bowTwistFormula);
            bowTwistFormula.Name = UpdatedValue;
          
            //Act
            BowTwistFormula result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IBowTwistFormulaRepository repository = new BowTwistFormulaRepository(qssContext);
                result = await repository.UpdateAsync(bowTwistFormula, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<BowTwistFormula>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullBowTwistFormulaObjectTest(string changeReason)
        {
            //Arrange
            IBowTwistFormulaRepository repository = new BowTwistFormulaRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithBowTwistFormulaIdNotExistTest(AddBowTwistFormulaModel addBowTwistFormulaModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var bowTwistFormula = mapper.Map<BowTwistFormula>(addBowTwistFormulaModel);
            bowTwistFormula.Name = UpdatedValue;
            bowTwistFormula.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IBowTwistFormulaRepository repository = new BowTwistFormulaRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(bowTwistFormula, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddBowTwistFormulaModel addBowTwistFormulaModel, string changeReason)
        {
            //Arrange
            var bowTwistFormula = mapper.Map<BowTwistFormula>(addBowTwistFormulaModel);
            BowTwistFormulaMoq bowTwistFormulaMoq = new BowTwistFormulaMoq(fixture);
            bowTwistFormulaMoq.MoqData(bowTwistFormula);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IBowTwistFormulaRepository repository = new BowTwistFormulaRepository(qssContext);
                result = await repository.RemoveByIdAsync(bowTwistFormula.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithBowTwistFormulaIdNotExist(string changeReason)
        {
            //Arrange
            IBowTwistFormulaRepository repository = new BowTwistFormulaRepository(fixture.qssContext);
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
