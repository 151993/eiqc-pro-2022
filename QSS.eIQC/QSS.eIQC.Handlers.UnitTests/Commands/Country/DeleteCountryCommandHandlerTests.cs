using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CountryCommand.Add;
using QSS.eIQC.Handlers.Commands.CountryCommand.Delete;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class DeleteCountryCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";
        QSSDataFixture fixture;

        public DeleteCountryCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory,AutoMoqData]
        public async Task HandleTest(AddCountryModel autoMoqData, string changeReason)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());

            var workCell = mapper.Map<Country>(autoMoqData);
            CountryMoq workCellMoq = new CountryMoq(fixture);
            workCellMoq.MoqData(workCell);

            DeleteCountryModel deleterequest = new DeleteCountryModel()
            {
                ChangeReason = changeReason,
                Id = workCell.Id
            };
            DeleteCountryResponse result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                DeleteCountryCommandHandler handler = new DeleteCountryCommandHandler(qssContext, new CountryRepository(qssContext));
                //Act
                result = await handler.Handle(deleterequest, CancellationToken.None);
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DeleteCountryResponse>(result);
            Assert.True(result.Result);
        }

        [Fact]
        public async Task HandleWithNullCountryObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());

            DeleteCountryCommandHandler handler = new DeleteCountryCommandHandler(fixture.qssContext, new CountryRepository(fixture.qssContext));

            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithCountryIdNotExistTest(DeleteCountryModel deleteCountryModel)
        {
            //Arrange
            int DeletedId = -1;
            deleteCountryModel.Id = DeletedId;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());

            DeleteCountryCommandHandler handler = new DeleteCountryCommandHandler(fixture.qssContext, new CountryRepository(fixture.qssContext));
            //Act
            Task act() => handler.Handle(deleteCountryModel, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", DeletedId.ToString()), exception.Result.Message);

        }
    }
}
