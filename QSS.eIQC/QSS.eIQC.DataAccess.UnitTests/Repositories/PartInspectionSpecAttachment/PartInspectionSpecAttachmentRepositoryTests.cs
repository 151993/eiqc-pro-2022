/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class PartInspectionSpecAttachmentRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update PartInspectionSpecAttachment";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public PartInspectionSpecAttachmentRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.PartInspectionSpecAttachmentCommand.MappingProfile());
        }

       /* [Theory, AutoMoqData]
        public async Task AddAsyncTest(PartInspectionSpecAttachment partInspectionSpecAttachment, string changeReason)
        {
            //Arrange
            IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(fixture.qssContext);

            //Act
            var result = await repository.AddAsync(partInspectionSpecAttachment,String.Empty, changeReason);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartInspectionSpecAttachment>(result);
            Assert.Equal(partInspectionSpecAttachment.Id, result.Id);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullPartInspectionSpecAttachmentObjectTest(string changeReason)
        {
            //Arrange
            IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddPartInspectionSpecAttachments(null, null, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddPartInspectionSpecAttachmentModel addPartInspectionSpecAttachmentModel, string changeReason)
        {
            //Arrange
            var partInspectionSpecAttachment = mapper.Map<PartInspectionSpecAttachment>(addPartInspectionSpecAttachmentModel);
            PartInspectionSpecAttachmentMoq partInspectionSpecAttachmentMoq= new PartInspectionSpecAttachmentMoq(fixture);
            partInspectionSpecAttachmentMoq.MoqData(partInspectionSpecAttachment);
          
            //Act
            PartInspectionSpecAttachment result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(qssContext);
                result = await repository.UpdateAsync(partInspectionSpecAttachment,String.Empty, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartInspectionSpecAttachment>(result);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullPartInspectionSpecAttachmentObjectTest(string changeReason)
        {
            //Arrange
            IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null,String.Empty, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithPartInspectionSpecAttachmentIdNotExistTest(AddPartInspectionSpecAttachmentModel addPartInspectionSpecAttachmentModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var partInspectionSpecAttachment = mapper.Map<PartInspectionSpecAttachment>(addPartInspectionSpecAttachmentModel);
            partInspectionSpecAttachment.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(partInspectionSpecAttachment,String.Empty, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        }

        [Theory,AutoMoqData]
        public async void RemoveByIdAsyncTest(AddPartInspectionSpecAttachmentModel addPartInspectionSpecAttachmentModel, string changeReason)
        {
            //Arrange
            var partInspectionSpecAttachment = mapper.Map<PartInspectionSpecAttachment>(addPartInspectionSpecAttachmentModel);
            PartInspectionSpecAttachmentMoq partInspectionSpecAttachmentMoq = new PartInspectionSpecAttachmentMoq(fixture);
            partInspectionSpecAttachmentMoq.MoqData(partInspectionSpecAttachment);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(qssContext);
                result = await repository.RemoveByIdAsync(partInspectionSpecAttachment.Id,String.Empty, changeReason);
            }
            //Assert
            Assert.True(result);

        } */

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithPartInspectionSpecAttachmentIdNotExist(string changeReason)
        {
            //Arrange
            IPartInspectionSpecAttachmentRepository repository = new PartInspectionSpecAttachmentRepository(fixture.qssContext);
            int DeleteId = -1;
            //Act
            Task act() => repository.RemoveByIdAsync(DeleteId,String.Empty, changeReason);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeleteId.ToString()), exception.Result.Message);

        }
       
    }
}
