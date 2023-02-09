/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanAdminCertificationCommand;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class SAPPartInspectionPlanAdminCertificationRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update SAPPartInspectionPlanAdminCertification";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public SAPPartInspectionPlanAdminCertificationRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
        }

       /* [Theory, AutoMoqData]
        public async Task AddAsyncTest(SAPPartInspectionPlan sAPPartInspectionPlan, string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanAdminCertificationRepository repository = new SAPPartInspectionPlanAdminCertificationRepository(fixture.qssContext);
            List<int> SAPPartInspectionPlanIds = new List<int> { 1, 2, 3 };
            //Act
            var result = repository.AddSAPPartInspectionPlanAdminCertifications(sAPPartInspectionPlan, SAPPartInspectionPlanIds);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<SAPPartInspectionPlanAdminCertification>(result);
        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullSAPPartInspectionPlanAdminCertificationObjectTest(string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanAdminCertificationRepository repository = new SAPPartInspectionPlanAdminCertificationRepository(fixture.qssContext);
            List<int> SAPPartInspectionPlanIds = new List<int>() { 1, 2, 3 };
            //Act
            Task act() => repository.AddSAPPartInspectionPlanAdminCertifications(null, SAPPartInspectionPlanIds);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithSAPPartInspectionPlanAdminCertificationIdNotExist(string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanAdminCertificationRepository repository = new SAPPartInspectionPlanAdminCertificationRepository(fixture.qssContext);
            int DeleteId = -1;
            List<int> SAPPartInspectionPlanIds = new List<int>() { 1, 2, 3 };
            //Act
            Task act() => repository.RemoveSAPPartInspectionPlanAdminCertifications(DeleteId, SAPPartInspectionPlanIds);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeleteId.ToString()), exception.Result.Message);

        } */

    }
}
