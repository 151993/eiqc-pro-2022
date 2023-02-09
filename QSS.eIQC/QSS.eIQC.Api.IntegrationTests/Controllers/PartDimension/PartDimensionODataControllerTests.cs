/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.PartDimension
{
    public class PartDimensionODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "PartDimension";

        private ODataQueryBuilder<ODataInfoContainer<PartDimensionModel>> _builder;

        public PartDimensionODataControllerTests()
        {
           _builder = new ODataBuilder<PartDimensionModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetPartDimension_ReturnsTop5PartDimensions()
        {
            //Arrange
            Uri uri = _builder.For<PartDimensionModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var partDimensionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            partDimensionresponse.EnsureSuccessStatusCode();
            var partDimensionString = await partDimensionresponse.Content.ReadAsStringAsync();
            var partDimensionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<PartDimensionModel>>(partDimensionString);
            List<PartDimensionModel> result = partDimensionOdataresponse.Value;

            Assert.NotNull(partDimensionOdataresponse.Value);
            Assert.IsAssignableFrom<List<PartDimensionModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetPartDimension_ReturnsSpecifiedIdPartDimension()
        {
            //Arrange
            Uri uri = _builder.For<PartDimensionModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var partDimensionresponse = await _client.GetAsync($"{oDataUrl}/1");

            // Assert
            partDimensionresponse.EnsureSuccessStatusCode();
            var partDimensionString = await partDimensionresponse.Content.ReadAsStringAsync();
            var partDimensionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<PartDimensionModel>>(partDimensionString);
            List<PartDimensionModel> result = partDimensionOdataresponse.Value;

            Assert.NotNull(partDimensionOdataresponse.Value);
            Assert.IsAssignableFrom<List<PartDimensionModel>>(result);
            
        }

        [Fact]
        public async Task GetPartDimension_ReturnsCountPartDimension()
        {
            //Arrange
            Uri uri = _builder.For<PartDimensionModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var partDimensionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            partDimensionresponse.EnsureSuccessStatusCode();
            var partDimensionString = await partDimensionresponse.Content.ReadAsStringAsync();
            var partDimensionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<PartDimensionModel>>(partDimensionString);
            List<PartDimensionModel> result = partDimensionOdataresponse.Value;

            Assert.NotNull(partDimensionOdataresponse.Value);
            Assert.IsAssignableFrom<List<PartDimensionModel>>(result);
            // Assert.Equal(10, result.Count());
            Assert.True(result.Count > 7);
        }

        [Fact]
        public async Task GetPartDimension_ReturnsSelected_Field_For_PartDimension()
        {
            //Arrange
            Uri uri = _builder.For<PartDimensionModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var partDimensionresponse = await _client.GetAsync(oDataUrl);

            // Assert
            partDimensionresponse.EnsureSuccessStatusCode();
            var partDimensionString = await partDimensionresponse.Content.ReadAsStringAsync();
            var partDimensionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<PartDimensionModel>>(partDimensionString);
            List<PartDimensionModel> result = partDimensionOdataresponse.Value;

            Assert.NotNull(partDimensionOdataresponse.Value);
            Assert.IsAssignableFrom<List<PartDimensionModel>>(result);
        }

    }
}
