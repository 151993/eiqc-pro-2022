/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand.Add;
using AutoMapper;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.DataAccess.UnitTests
{
    public class PartInspectionDrawingAttachmentRepositoryTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        IMapper mapper;
        private const string UpdatedValue = "Update PartInspectionDrawingAttachment";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        
        public PartInspectionDrawingAttachmentRepositoryTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            mapper = autoMapping.GetMapper(new Handlers.Commands.PartInspectionDrawingAttachmentCommand.MappingProfile());
        }

        /*[Theory, AutoMoqData]
        public async Task AddAsyncTest(PartInspectionDrawingAttachment partInspectionDrawingAttachment, string changeReason)
        {
            //Arrange
            IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(fixture.qssContext);

            //Act
            var result = await repository.AddAsync(partInspectionDrawingAttachment, string.Empty, changeReason);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartInspectionDrawingAttachment>(result);
            Assert.Equal(partInspectionDrawingAttachment.Id, result.Id);

        }

        [Theory, AutoMoqData]
        public async Task AddAsyncWithNullPartInspectionDrawingAttachmentObjectTest(string changeReason)
        {
            //Arrange
            IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(fixture.qssContext);

            //Act
            Task act() => repository.AddAsync(null,string.Empty, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        } */

        /*[Theory,AutoMoqData]
        public async Task UpdateAsyncTest(AddPartInspectionDrawingAttachmentModel addPartInspectionDrawingAttachmentModel, string changeReason)
        {
            //Arrange
            var partInspectionDrawingAttachment = mapper.Map<PartInspectionDrawingAttachment>(addPartInspectionDrawingAttachmentModel);
            PartInspectionDrawingAttachmentMoq partInspectionDrawingAttachmentMoq= new PartInspectionDrawingAttachmentMoq(fixture);
            partInspectionDrawingAttachmentMoq.MoqData(partInspectionDrawingAttachment);
          
            //Act
            PartInspectionDrawingAttachment result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(qssContext);
                result = await repository.UpdateAsync(partInspectionDrawingAttachment, String.Empty, changeReason);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<PartInspectionDrawingAttachment>(result);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithNullPartInspectionDrawingAttachmentObjectTest(string changeReason)
        {
            //Arrange
            IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(fixture.qssContext);

            //Act
            Task act() => repository.UpdateAsync(null, String.Empty, changeReason);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        [Theory, AutoMoqData]
        public async Task UpdateAsyncWithPartInspectionDrawingAttachmentIdNotExistTest(AddPartInspectionDrawingAttachmentModel addPartInspectionDrawingAttachmentModel, string changeReason)
        {
            //Arrange
            int UpdatedId = 10;
            var partInspectionDrawingAttachment = mapper.Map<PartInspectionDrawingAttachment>(addPartInspectionDrawingAttachmentModel);
            partInspectionDrawingAttachment.Id = UpdatedId;


            //Act
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(qssContext);
                //Act
                Task act() => repository.UpdateAsync(partInspectionDrawingAttachment, String.Empty, changeReason);

                ////Assert
                await Assert.ThrowsAsync<Exception>(act);
                var exception = Assert.ThrowsAsync<Exception>(() => act());
                Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            }

        } */

       /* [Theory,AutoMoqData]
        public async Task RemoveByIdAsyncTest(AddPartInspectionDrawingAttachmentModel addPartInspectionDrawingAttachmentModel, string changeReason)
        {
            //Arrange
            var partInspectionDrawingAttachment = mapper.Map<PartInspectionDrawingAttachment>(addPartInspectionDrawingAttachmentModel);
            PartInspectionDrawingAttachmentMoq partInspectionDrawingAttachmentMoq = new PartInspectionDrawingAttachmentMoq(fixture);
            partInspectionDrawingAttachmentMoq.MoqData(partInspectionDrawingAttachment);

            //Act
            bool result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(qssContext);
                result = await repository.RemoveByIdAsync(partInspectionDrawingAttachment.AttachmentId, String.Empty, changeReason);
            }
            //Assert
            Assert.True(result);

        } */

        [Theory, AutoMoqData]
        public async Task RemoveByIdAsyncWithPartInspectionDrawingAttachmentIdNotExist(string changeReason)
        {
            //Arrange
            IPartInspectionDrawingAttachmentRepository repository = new PartInspectionDrawingAttachmentRepository(fixture.qssContext);
            int DeleteId = -1;
            //Act
            Task act() => repository.RemoveByIdAsync(DeleteId, String.Empty,changeReason);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeleteId.ToString()), exception.Result.Message);

        } 
       
    }
}
