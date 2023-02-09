using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CountryCommand;
using QSS.eIQC.Handlers.Commands.CountryCommand.Update;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.DataAccess.UnitTests.MoqData;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class UpdateCountryCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;
        private const string UpdatedValue = "Update Country";
        private const string RecordIdDoesNotExistsException = "Record with id {Id} does not exists.";

        public UpdateCountryCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(UpdateCountryModel autoMoqData)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());

            var workCell = mapper.Map<Country>(autoMoqData);
            CountryMoq workCellMoq = new CountryMoq(fixture);
            workCellMoq.MoqData(workCell);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.LastUpdated = workCell.LastUpdated;

            CountryModel result;
            using (var qssContext = new QSSContext(fixture.qssContextOptions, MoqUserIdentity.GetUserIdentity().Object))
            {
                UpdateCountryCommandHandler handler = new UpdateCountryCommandHandler(qssContext, new CountryRepository(qssContext), mapper);
                //Act
                result = await handler.Handle(autoMoqData, CancellationToken.None);
                
            }

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<CountryModel>(result);
            Assert.Equal(UpdatedValue, result.Name);
        }

        [Fact]
        public async Task HandleWithNullCountryObjectTest()
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());
          
            UpdateCountryCommandHandler handler = new UpdateCountryCommandHandler(fixture.qssContext, new CountryRepository(fixture.qssContext), mapper);
            
            //Act
            Task act() => handler.Handle(null, CancellationToken.None);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);
        }

        [Theory, AutoMoqData]
        public async Task HandleWithCountryIdNotExistTest(UpdateCountryModel autoMoqData)
        {
            //Arrange
            int UpdatedId = 10;
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());

            var workCell = mapper.Map<Country>(autoMoqData);
            CountryMoq workCellMoq = new CountryMoq(fixture);
            autoMoqData.Name = UpdatedValue;
            autoMoqData.Id = UpdatedId;

            UpdateCountryCommandHandler handler = new UpdateCountryCommandHandler(fixture.qssContext, new CountryRepository(fixture.qssContext), mapper);
            //Act
            Task act() => handler.Handle(autoMoqData, CancellationToken.None);

            ////Assert
            await Assert.ThrowsAsync<Exception>(act);
            var exception = Assert.ThrowsAsync<Exception>(() => act());
            Assert.Equal(RecordIdDoesNotExistsException.Replace("{Id}", UpdatedId.ToString()), exception.Result.Message);
            
        }
    }
}
