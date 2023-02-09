/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class CertificateTypeRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update CertificateType";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public CertificateTypeRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.CertificateTypeCommand.MappingProfile());
        }

        [Theory, AutoMoqData]
        public async Task AddAsyncTest(CertificateType certificateType, string changeReason)
        {
            //Arrange
            ICertificateTypeRepository repository = new CertificateTypeRepository(fixture.qssContext);

            //Act
            var result = await repository.AddAsync(certificateType, changeReason);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<CertificateType>(result);
            Assert.Equal(certificateType.Name, result.Name);
            Assert.Equal(certificateType.Id, result.Id);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullCertificateTypeObjectTest(string changeReason)
        {
            //Arrange
            ICertificateTypeRepository repository = new CertificateTypeRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddCertificateTypeModel addCertificateTypeModel, string changeReason)
        {
            //Arrange
            var certificateType = mapper.Map<CertificateType>(addCertificateTypeModel);
            CertificateTypeMoq certificateTypeMoq= new CertificateTypeMoq(fixture);
            certificateTypeMoq.MoqData(certificateType);
            certificateType.Name = UpdatedValue;
          
            //Act
            CertificateType result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ICertificateTypeRepository repository = new CertificateTypeRepository(qssContext);
                result = await repository.UpdateAsync(certificateType, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<CertificateType>(result);
            Assert.Equal(UpdatedValue, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullCertificateTypeObjectTest(string changeReason)
        {
            //Arrange
            ICertificateTypeRepository repository = new CertificateTypeRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithCertificateTypeIdNotExistTest(AddCertificateTypeModel addCertificateTypeModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var certificateType = mapper.Map<CertificateType>(addCertificateTypeModel);
            certificateType.Name = UpdatedValue;
            certificateType.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ICertificateTypeRepository repository = new CertificateTypeRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(certificateType, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddCertificateTypeModel addCertificateTypeModel, string changeReason)
        {
            //Arrange
            var certificateType = mapper.Map<CertificateType>(addCertificateTypeModel);
            CertificateTypeMoq certificateTypeMoq = new CertificateTypeMoq(fixture);
            certificateTypeMoq.MoqData(certificateType);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                ICertificateTypeRepository repository = new CertificateTypeRepository(qssContext);
                result = await repository.RemoveByIdAsync(certificateType.Id, changeReason);
            }
            //Assert
            Assert.True(result);

        }

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithCertificateTypeIdNotExist(string changeReason)
        {
            //Arrange
            ICertificateTypeRepository repository = new CertificateTypeRepository(fixture.qssContext);
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
