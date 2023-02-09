using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.RegionCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.Region
{
    public class RegionODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "Region";

        private ODataQueryBuilder<ODataInfoContainer<RegionModel>> _builder;

        public RegionODataControllerTests()
        {
           _builder = new ODataBuilder<RegionModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetRegion_ReturnsTop5Regions()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetRegion_ReturnsSpecifiedIdRegion()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync($"{oDataUrl}/10");

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
            
        }

        [Fact]
        public async Task GetRegion_ReturnsFiltered_NameRegion()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().Filter(s => s.Name == "Region 4").ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
            Assert.Single(result);
            Assert.Equal(RegionMoq.Regions[3].Name, result[0].Name);
        }

        [Fact]
        public async Task GetRegion_ReturnsCountRegion()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
            //Assert.Equal(10,result.Count());
            Assert.True(result.Count > 7);
        }

        [Fact]
        public async Task GetRegion_ReturnsCominationFiltered_Region()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Europe") || f.Contains(s.Name, "Asia")).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetRegion_ReturnsFiltered_Combination_NameAndIdRegion()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Asia") && s.Id > 7)
                .OrderByDescending(s=> s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(9, result[0].Id);
        }

        [Fact]
        public async Task GetRegion_ReturnsSelected_Field_For_Region()
        {
            //Arrange
            Uri uri = _builder.For<RegionModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var regionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            regionresponse.EnsureSuccessStatusCode();
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            List<RegionModel> result = regionOdataresponse.Value;

            Assert.NotNull(regionOdataresponse.Value);
            Assert.IsAssignableFrom<List<RegionModel>>(result);
        }

    }
}
