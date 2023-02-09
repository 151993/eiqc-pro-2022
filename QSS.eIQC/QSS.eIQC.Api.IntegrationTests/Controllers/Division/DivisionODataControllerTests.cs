using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.DivisionCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.Division
{
    public class DivisionODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "Division";

        private ODataQueryBuilder<ODataInfoContainer<DivisionModel>> _builder;

        public DivisionODataControllerTests()
        {
           _builder = new ODataBuilder<DivisionModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetDivision_ReturnsTop5Divisions()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetDivision_ReturnsSpecifiedIdDivision()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync($"{oDataUrl}/10");

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
            
        }

        [Fact]
        public async Task GetDivision_ReturnsFiltered_NameDivision()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().Filter(s => s.Name == "Division 4").ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
            Assert.Single(result);
            Assert.Equal(DivisionMoq.Divisions[3].Name, result[0].Name);
        }

        [Fact]
        public async Task GetDivision_ReturnsCountDivision()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
            //Assert.Equal(10,result.Count());
            Assert.True(result.Count > 7);
        }

        [Fact]
        public async Task GetDivision_ReturnsCominationFiltered_Division()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Europe") || f.Contains(s.Name, "Asia")).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetDivision_ReturnsFiltered_Combination_NameAndIdDivision()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Asia") && s.Id > 7)
                .OrderByDescending(s=> s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(9, result[0].Id);
        }

        [Fact]
        public async Task GetDivision_ReturnsSelected_Field_For_Division()
        {
            //Arrange
            Uri uri = _builder.For<DivisionModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var divisionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            divisionresponse.EnsureSuccessStatusCode();
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            List<DivisionModel> result = divisionOdataresponse.Value;

            Assert.NotNull(divisionOdataresponse.Value);
            Assert.IsAssignableFrom<List<DivisionModel>>(result);
        }

    }
}
