/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.DCCConfiguration
{
    public class DCCConfigurationODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "DCCConfiguration";

        private ODataQueryBuilder<ODataInfoContainer<DCCConfigurationModel>> _builder;

        public DCCConfigurationODataControllerTests()
        {
           _builder = new ODataBuilder<DCCConfigurationModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetDCCConfiguration_ReturnsTop5DCCConfigurations()
        {
            //Arrange
            Uri uri = _builder.For<DCCConfigurationModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var dCCConfigurationresponse = await _client.GetAsync(oDataUrl);

            // Assert
            dCCConfigurationresponse.EnsureSuccessStatusCode();
            var dCCConfigurationString = await dCCConfigurationresponse.Content.ReadAsStringAsync();
            var dCCConfigurationOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DCCConfigurationModel>>(dCCConfigurationString);
            List<DCCConfigurationModel> result = dCCConfigurationOdataresponse.Value;

            Assert.NotNull(dCCConfigurationOdataresponse.Value);
            Assert.IsAssignableFrom<List<DCCConfigurationModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetDCCConfiguration_ReturnsSpecifiedIdDCCConfiguration()
        {
            //Arrange
            Uri uri = _builder.For<DCCConfigurationModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var dCCConfigurationresponse = await _client.GetAsync($"{oDataUrl}/1");

            // Assert
            dCCConfigurationresponse.EnsureSuccessStatusCode();
            var dCCConfigurationString = await dCCConfigurationresponse.Content.ReadAsStringAsync();
            var dCCConfigurationOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DCCConfigurationModel>>(dCCConfigurationString);
            List<DCCConfigurationModel> result = dCCConfigurationOdataresponse.Value;

            Assert.NotNull(dCCConfigurationOdataresponse.Value);
            Assert.IsAssignableFrom<List<DCCConfigurationModel>>(result);
            
        }

        [Fact]
        public async Task GetDCCConfiguration_ReturnsCountDCCConfiguration()
        {
            //Arrange
            Uri uri = _builder.For<DCCConfigurationModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var dCCConfigurationresponse = await _client.GetAsync(oDataUrl);

            // Assert
            dCCConfigurationresponse.EnsureSuccessStatusCode();
            var dCCConfigurationString = await dCCConfigurationresponse.Content.ReadAsStringAsync();
            var dCCConfigurationOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DCCConfigurationModel>>(dCCConfigurationString);
            List<DCCConfigurationModel> result = dCCConfigurationOdataresponse.Value;

            Assert.NotNull(dCCConfigurationOdataresponse.Value);
            Assert.IsAssignableFrom<List<DCCConfigurationModel>>(result);
            Assert.True(result.Count > 5);
        }

        [Fact]
        public async Task GetDCCConfiguration_ReturnsSelected_Field_For_DCCConfiguration()
        {
            //Arrange
            Uri uri = _builder.For<DCCConfigurationModel>(s => s.Entity).ByList().Select(s=> s.SiteNo).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var dCCConfigurationresponse = await _client.GetAsync(oDataUrl);

            // Assert
            dCCConfigurationresponse.EnsureSuccessStatusCode();
            var dCCConfigurationString = await dCCConfigurationresponse.Content.ReadAsStringAsync();
            var dCCConfigurationOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DCCConfigurationModel>>(dCCConfigurationString);
            List<DCCConfigurationModel> result = dCCConfigurationOdataresponse.Value;

            Assert.NotNull(dCCConfigurationOdataresponse.Value);
            Assert.IsAssignableFrom<List<DCCConfigurationModel>>(result);
        }

    }
}
