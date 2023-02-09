/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateCertificateTypeCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update CertificateType";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateCertificateTypeCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateCertificateTypeModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CertificateTypeCommand.MappingProfile());

            var certificateType = mapper.Map<CertificateType>(autoMoqData);
            CertificateTypeMoq certificateTypeMoq = new CertificateTypeMoq(fixture);
            certificateTypeMoq.MoqData(certificateType);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = certificateType.LastUpdated;

            CertificateTypeModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateCertificateTypeCommandHandler handler = new UpdateCertificateTypeCommandHandler(qssContext, new CertificateTypeRepository(qssContext), new CertificateTypeParameterRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<CertificateTypeModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullCertificateTypeObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CertificateTypeCommand.MappingProfile());
          
            UpdateCertificateTypeCommandHandler handler = new UpdateCertificateTypeCommandHandler(fixture.qssContext, new CertificateTypeRepository(fixture.qssContext), new CertificateTypeParameterRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithCertificateTypeIdNotExistTest(UpdateCertificateTypeModel autoMoqData)
        {
            //Arrange
            int UpdatedId = 10;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CertificateTypeCommand.MappingProfile());

            var certificateType = mapper.Map<CertificateType>(autoMoqData);
            CertificateTypeMoq certificateTypeMoq = new CertificateTypeMoq(fixture);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.Id = UpdatedId;

            UpdateCertificateTypeCommandHandler handler = new UpdateCertificateTypeCommandHandler(fixture.qssContext, new CertificateTypeRepository(fixture.qssContext), new CertificateTypeParameterRepository(fixture.qssContext), mapper);
            //Act
            Task act() => handler.Handle(autoMoqData, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        }
    }
}
