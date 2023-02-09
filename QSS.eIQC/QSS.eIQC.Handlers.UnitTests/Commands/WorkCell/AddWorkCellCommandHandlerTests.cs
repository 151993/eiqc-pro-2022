using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddWorkCellCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddWorkCellCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(AddWorkCellModel autoMoqData, CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper= autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());
          
            AddWorkCellCommandHandler handler = new AddWorkCellCommandHandler(fixture.qssContext, new WorkCellRepository(fixture.qssContext), mapper, null);
            
            //Act
            var result = await handler.Handle(autoMoqData, cancellationToken);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<WorkCellModel>(result);
            Assert.Equal(autoMoqData.Name, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task HandleWithNullWorkCellObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.WorkCellCommand.MappingProfile());

            AddWorkCellCommandHandler handler = new AddWorkCellCommandHandler(fixture.qssContext, new WorkCellRepository(fixture.qssContext), mapper, null);

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
