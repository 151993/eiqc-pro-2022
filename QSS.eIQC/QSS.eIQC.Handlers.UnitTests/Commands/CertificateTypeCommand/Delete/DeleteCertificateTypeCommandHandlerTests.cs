/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteCertificateTypeCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteCertificateTypeCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddCertificateTypeModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CertificateTypeCommand.MappingProfile());

            var certificateType = mapper.Map<CertificateType>(autoMoqData);
            CertificateTypeMoq certificateTypeMoq = new CertificateTypeMoq(fixture);
            certificateTypeMoq.MoqData(certificateType);

            DeleteCertificateTypeModel deleterequest = new DeleteCertificateTypeModel()
            {
                ChangeReason = changeReason,
                Id = certificateType.Id
            };
            DeleteCertificateTypeResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteCertificateTypeCommandHandler handler = new DeleteCertificateTypeCommandHandler(qssContext, new CertificateTypeRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteCertificateTypeResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullCertificateTypeObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CertificateTypeCommand.MappingProfile());

            DeleteCertificateTypeCommandHandler handler = new DeleteCertificateTypeCommandHandler(fixture.qssContext, new CertificateTypeRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithCertificateTypeIdNotExistTest(DeleteCertificateTypeModel deleteCertificateTypeModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteCertificateTypeModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CertificateTypeCommand.MappingProfile());

            DeleteCertificateTypeCommandHandler handler = new DeleteCertificateTypeCommandHandler(fixture.qssContext, new CertificateTypeRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteCertificateTypeModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
