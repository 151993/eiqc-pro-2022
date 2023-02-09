/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteSAPPartInspectionPlanCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteSAPPartInspectionPlanCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Fact]
        public async Task HandleWithNullSAPPartInspectionPlanObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.SAPPartInspectionPlanCommand.MappingProfile());

            DeleteSAPPartInspectionPlanCommandHandler handler = new DeleteSAPPartInspectionPlanCommandHandler(fixture.qssContext, new SAPPartInspectionPlanRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithSAPPartInspectionPlanIdNotExistTest(DeleteSAPPartInspectionPlanModel deleteSAPPartInspectionPlanModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteSAPPartInspectionPlanModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.SAPPartInspectionPlanCommand.MappingProfile());

            DeleteSAPPartInspectionPlanCommandHandler handler = new DeleteSAPPartInspectionPlanCommandHandler(fixture.qssContext, new SAPPartInspectionPlanRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteSAPPartInspectionPlanModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
