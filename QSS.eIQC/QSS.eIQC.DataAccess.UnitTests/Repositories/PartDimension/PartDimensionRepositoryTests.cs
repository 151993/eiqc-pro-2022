/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class PartDimensionRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update PartDimension";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public PartDimensionRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.PartDimensionCommand.MappingProfile());
        }

        [Theory, AutoMoqData]
        public async Task AddAsyncTest(PartDimension partDimension, string changeReason)
        {
            //Arrange
            IPartDimensionRepository repository = new PartDimensionRepository(fixture.qssContext);

            //Act
            var result = await repository.AddAsync(partDimension, changeReason);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartDimension>(result);
            Assert.Equal(partDimension.Name, result.Name);
            Assert.Equal(partDimension.Id, result.Id);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullPartDimensionObjectTest(string changeReason)
        {
            //Arrange
            IPartDimensionRepository repository = new PartDimensionRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddPartDimensionModel addPartDimensionModel, string changeReason)
        {
            //Arrange
            var partDimension = mapper.Map<PartDimension>(addPartDimensionModel);
            PartDimensionMoq partDimensionMoq= new PartDimensionMoq(fixture);
            partDimensionMoq.MoqData(partDimension);
            partDimension.Name = UpdatedValue;
          
            //Act
            PartDimension result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartDimensionRepository repository = new PartDimensionRepository(qssContext);
                result = await repository.UpdateAsync(partDimension, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartDimension>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullPartDimensionObjectTest(string changeReason)
        {
            //Arrange
            IPartDimensionRepository repository = new PartDimensionRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithPartDimensionIdNotExistTest(AddPartDimensionModel addPartDimensionModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var partDimension = mapper.Map<PartDimension>(addPartDimensionModel);
            partDimension.Name = UpdatedValue;
            partDimension.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartDimensionRepository repository = new PartDimensionRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(partDimension, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddPartDimensionModel addPartDimensionModel, string changeReason)
        {
            //Arrange
            var partDimension = mapper.Map<PartDimension>(addPartDimensionModel);
            PartDimensionMoq partDimensionMoq = new PartDimensionMoq(fixture);
            partDimensionMoq.MoqData(partDimension);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartDimensionRepository repository = new PartDimensionRepository(qssContext);
                result = await repository.RemoveByIdAsync(partDimension.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithPartDimensionIdNotExist(string changeReason)
        {
            //Arrange
            IPartDimensionRepository repository = new PartDimensionRepository(fixture.qssContext);
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
