using AutoMapper;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Add;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.UnitTests.Core;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System;

namespace QSS.eIQC.Handlers.UnitTests.Tests
{
    public class AddDepartmentCommandHandlerTests : IClassFixture<QSSDataFixture>
    {
        QSSDataFixture fixture;

        public AddDepartmentCommandHandlerTests(QSSDataFixture fixture)
        {
            this.fixture = fixture;
        }


        [Theory, AutoMoqData]
        public async Task HandleTest(AddDepartmentModel autoMoqData, CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper= autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());
          
            AddDepartmentCommandHandler handler = new AddDepartmentCommandHandler(fixture.qssContext, new DepartmentRepository(fixture.qssContext), mapper);
            
            //Act
            var result = await handler.Handle(autoMoqData, cancellationToken);

            //Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<DepartmentModel>(result);
            Assert.Equal(autoMoqData.Name, result.Name);

        }

        [Theory, AutoMoqData]
        public async Task HandleWithNullDepartmentObjectTest(CancellationToken cancellationToken)
        {
            //Arrange
            //auto mapper configuration
            AutoMapping autoMapping = new AutoMapping();
            var mapper = autoMapping.GetMapper(new Commands.DepartmentCommand.MappingProfile());

            AddDepartmentCommandHandler handler = new AddDepartmentCommandHandler(fixture.qssContext, new DepartmentRepository(fixture.qssContext), mapper);

            //Act
            Task act() => handler.Handle(null, cancellationToken);

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }
    }
}
