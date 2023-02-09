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
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using System.Collections.Generic;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class SAPPartInspectionPlanSupplierRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update SAPPartInspectionPlanSupplier";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public SAPPartInspectionPlanSupplierRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
        }

        /*[Theory, AutoMoqData]
        public async Task AddAsyncTest(SAPPartInspectionPlan sAPPartInspectionPlanSupplier, string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanSupplierRepository repository = new SAPPartInspectionPlanSupplierRepository(fixture.qssContext);
            List<int> SAPPartInspectionPlanIds = new List<int>() { 1, 2, 3 };
            //Act
            var result = await repository.AddSAPPartInspectionPlanSuppliers(sAPPartInspectionPlanSupplier, SAPPartInspectionPlanIds);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<SAPPartInspectionPlanSupplier>(result);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullSAPPartInspectionPlanSupplierObjectTest(string changeReason)
        {
            //Arrange
            ISAPPartInspectionPlanSupplierRepository repository = new SAPPartInspectionPlanSupplierRepository(fixture.qssContext);

            List<int> SAPPartInspectionPlanIds = new List<int>() { 1, 2, 3 };
            //Act
            Task act() => repository.AddSAPPartInspectionPlanSuppliers(null, SAPPartInspectionPlanIds);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        } */


    }
}
