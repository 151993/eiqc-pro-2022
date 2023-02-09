using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.CountryCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.Country
{
    public class CountryODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "Country";

        private ODataQueryBuilder<ODataInfoContainer<CountryModel>> _builder;

        public CountryODataControllerTests()
        {
           _builder = new ODataBuilder<CountryModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetCountry_ReturnsTop5Countrys()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync(oDataUrl);

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetCountry_ReturnsSpecifiedIdCountry()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync($"{oDataUrl}/10");

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
            
        }

        [Fact]
        public async Task GetCountry_ReturnsFiltered_NameCountry()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().Filter(s => s.Name == "Country 4").ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync(oDataUrl);

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
            Assert.Single(result);
            Assert.Equal(CountryMoq.Countrys[3].Name, result[0].Name);
        }

        [Fact]
        public async Task GetCountry_ReturnsCountCountry()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync(oDataUrl);

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
            //Assert.(10,result.Count());
            Assert.True(result.Count > 7);
        }

        [Fact]
        public async Task GetCountry_ReturnsCominationFiltered_Country()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Europe") || f.Contains(s.Name, "Asia")).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync(oDataUrl);

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetCountry_ReturnsFiltered_Combination_NameAndIdCountry()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Asia") && s.Id > 7)
                .OrderByDescending(s=> s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync(oDataUrl);

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(9, result[0].Id);
        }

        [Fact]
        public async Task GetCountry_ReturnsSelected_Field_For_Country()
        {
            //Arrange
            Uri uri = _builder.For<CountryModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var countryresponse = await _client.GetAsync(oDataUrl);

            // Assert
            countryresponse.EnsureSuccessStatusCode();
            var countryString = await countryresponse.Content.ReadAsStringAsync();
            var countryOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(countryString);
            List<CountryModel> result = countryOdataresponse.Value;

            Assert.NotNull(countryOdataresponse.Value);
            Assert.IsAssignableFrom<List<CountryModel>>(result);
        }

    }
}
