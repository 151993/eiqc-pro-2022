using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.CountryCommand;
using QSS.eIQC.Handlers.Commands.CountryCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddCountryCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddCountryCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(AddCountryModel autoMoqData, CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper= autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());
          
            AddCountryCommandHandler handler = new AddCountryCommandHandler(fixture.qssContext, new CountryRepository(fixture.qssContext), mapper);
            
            //Act
            var result = await handler.Handle(autoMoqData, cancellationToken);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<CountryModel>(result);
            Assert.Equal(autoMoqData.Name, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task HandleWithNullCountryObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.CountryCommand.MappingProfile());

            AddCountryCommandHandler handler = new AddCountryCommandHandler(fixture.qssContext, new CountryRepository(fixture.qssContext), mapper);

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
