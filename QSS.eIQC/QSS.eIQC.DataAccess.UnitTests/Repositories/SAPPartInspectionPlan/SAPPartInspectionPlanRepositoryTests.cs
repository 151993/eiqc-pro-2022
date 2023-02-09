/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class SAPPartInspectionPlanRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update SAPPartInspectionPlan";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public SAPPartInspectionPlanRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.SAPPartInspectionPlanCommand.MappingProfile());
        }

       /* [Theory, AutoMoqData]
        public async Task AddAsyncTest(SAPPartInspectionPlan sAPPartInspectionPlan, string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(fixture.qssContext);

            //Act
            var result = await repository.AddAsync(sAPPartInspectionPlan, changeReason);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<SAPPartInspectionPlan>(result);
            Assert.Equal(sAPPartInspectionPlan.PartNo, result.PartNo);
            Assert.Equal(sAPPartInspectionPlan.Id, result.Id);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullSAPPartInspectionPlanObjectTest(string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddSAPPartInspectionPlanModel addSAPPartInspectionPlanModel, string changeReason)
        {
            //Arrange
            var sAPPartInspectionPlan = mapper.Map<SAPPartInspectionPlan>(addSAPPartInspectionPlanModel);
            SAPPartInspectionPlanMoq sAPPartInspectionPlanMoq= new SAPPartInspectionPlanMoq(fixture);
            sAPPartInspectionPlanMoq.MoqData(sAPPartInspectionPlan);
          
            //Act
            SAPPartInspectionPlan result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(qssContext);
                result = await repository.UpdateAsync(sAPPartInspectionPlan, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<SAPPartInspectionPlan>(result);
        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullSAPPartInspectionPlanObjectTest(string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithSAPPartInspectionPlanIdNotExistTest(AddSAPPartInspectionPlanModel addSAPPartInspectionPlanModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var sAPPartInspectionPlan = mapper.Map<SAPPartInspectionPlan>(addSAPPartInspectionPlanModel);
            sAPPartInspectionPlan.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(sAPPartInspectionPlan, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddSAPPartInspectionPlanModel addSAPPartInspectionPlanModel, string changeReason)
        {
            //Arrange
            var sAPPartInspectionPlan = mapper.Map<SAPPartInspectionPlan>(addSAPPartInspectionPlanModel);
            SAPPartInspectionPlanMoq sAPPartInspectionPlanMoq = new SAPPartInspectionPlanMoq(fixture);
            sAPPartInspectionPlanMoq.MoqData(sAPPartInspectionPlan);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(qssContext);
                result = await repository.RemoveByIdAsync(sAPPartInspectionPlan.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithSAPPartInspectionPlanIdNotExist(string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanRepository repository = new SAPPartInspectionPlanRepository(fixture.qssContext);
            int DeleteId = -1;
            //Act
            Task act() => repository.RemoveByIdAsync(DeleteId, changeReason);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeleteId.ToString()), exception.Result.Message);

        } */
       
    }
}
