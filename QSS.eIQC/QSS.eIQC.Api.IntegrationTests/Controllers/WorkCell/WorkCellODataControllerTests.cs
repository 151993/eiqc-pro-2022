using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.WorkCell
{
    public class WorkCellODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "WorkCell";

        private ODataQueryBuilder<ODataInfoContainer<WorkCellModel>> _builder;

        public WorkCellODataControllerTests()
        {
           _builder = new ODataBuilder<WorkCellModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetWorkCell_ReturnsTop5WorkCells()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync(oDataUrl);

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetWorkCell_ReturnsSpecifiedIdWorkCell()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync($"{oDataUrl}/10");

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
            
        }

        [Fact]
        public async Task GetWorkCell_ReturnsFiltered_NameWorkCell()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().Filter(s => s.Name == "WorkCell 4").ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync(oDataUrl);

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
            Assert.Single(result);
            Assert.Equal(WorkCellMoq.WorkCells[3].Name, result[0].Name);
        }

        [Fact]
        public async Task GetWorkCell_ReturnsCountWorkCell()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync(oDataUrl);

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
            Assert.Equal(10,result.Count());
        }

        [Fact]
        public async Task GetWorkCell_ReturnsCominationFiltered_WorkCell()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Europe") || f.Contains(s.Name, "Asia")).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync(oDataUrl);

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetWorkCell_ReturnsFiltered_Combination_NameAndIdWorkCell()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Asia") && s.Id > 7)
                .OrderByDescending(s=> s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync(oDataUrl);

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(9, result[0].Id);
        }

        [Fact]
        public async Task GetWorkCell_ReturnsSelected_Field_For_WorkCell()
        {
            //Arrange
            Uri uri = _builder.For<WorkCellModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var workcellresponse = await _client.GetAsync(oDataUrl);

            // Assert
            workcellresponse.EnsureSuccessStatusCode();
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            List<WorkCellModel> result = workCellOdataresponse.Value;

            Assert.NotNull(workCellOdataresponse.Value);
            Assert.IsAssignableFrom<List<WorkCellModel>>(result);
        }

    }
}
