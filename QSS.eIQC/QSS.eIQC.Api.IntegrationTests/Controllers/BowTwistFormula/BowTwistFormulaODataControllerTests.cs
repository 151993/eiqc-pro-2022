/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.BowTwistFormula
{
    public class BowTwistFormulaODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "BowTwistFormula";

        private ODataQueryBuilder<ODataInfoContainer<BowTwistFormulaModel>> _builder;

        public BowTwistFormulaODataControllerTests()
        {
           _builder = new ODataBuilder<BowTwistFormulaModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetBowTwistFormula_ReturnsTop5BowTwistFormulas()
        {
            //Arrange
            Uri uri = _builder.For<BowTwistFormulaModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var bowTwistFormularesponse = await _client.GetAsync(oDataUrl);

            // Assert
            bowTwistFormularesponse.EnsureSuccessStatusCode();
            var bowTwistFormulaString = await bowTwistFormularesponse.Content.ReadAsStringAsync();
            var bowTwistFormulaOdataresponse = JsonConvert.DeserializeObject<ODataResponse<BowTwistFormulaModel>>(bowTwistFormulaString);
            List<BowTwistFormulaModel> result = bowTwistFormulaOdataresponse.Value;

            Assert.NotNull(bowTwistFormulaOdataresponse.Value);
            Assert.IsAssignableFrom<List<BowTwistFormulaModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetBowTwistFormula_ReturnsSpecifiedIdBowTwistFormula()
        {
            //Arrange
            Uri uri = _builder.For<BowTwistFormulaModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var bowTwistFormularesponse = await _client.GetAsync($"{oDataUrl}/1");

            // Assert
            bowTwistFormularesponse.EnsureSuccessStatusCode();
            var bowTwistFormulaString = await bowTwistFormularesponse.Content.ReadAsStringAsync();
            var bowTwistFormulaOdataresponse = JsonConvert.DeserializeObject<ODataResponse<BowTwistFormulaModel>>(bowTwistFormulaString);
            List<BowTwistFormulaModel> result = bowTwistFormulaOdataresponse.Value;

            Assert.NotNull(bowTwistFormulaOdataresponse.Value);
            Assert.IsAssignableFrom<List<BowTwistFormulaModel>>(result);
            
        }

        [Fact]
        public async Task GetBowTwistFormula_ReturnsCountBowTwistFormula()
        {
            //Arrange
            Uri uri = _builder.For<BowTwistFormulaModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var bowTwistFormularesponse = await _client.GetAsync(oDataUrl);

            // Assert
            bowTwistFormularesponse.EnsureSuccessStatusCode();
            var bowTwistFormulaString = await bowTwistFormularesponse.Content.ReadAsStringAsync();
            var bowTwistFormulaOdataresponse = JsonConvert.DeserializeObject<ODataResponse<BowTwistFormulaModel>>(bowTwistFormulaString);
            List<BowTwistFormulaModel> result = bowTwistFormulaOdataresponse.Value;

            Assert.NotNull(bowTwistFormulaOdataresponse.Value);
            Assert.IsAssignableFrom<List<BowTwistFormulaModel>>(result);
            Assert.True(result.Count > 7);
        }

        [Fact]
        public async Task GetBowTwistFormula_ReturnsSelected_Field_For_BowTwistFormula()
        {
            //Arrange
            Uri uri = _builder.For<BowTwistFormulaModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var bowTwistFormularesponse = await _client.GetAsync(oDataUrl);

            // Assert
            bowTwistFormularesponse.EnsureSuccessStatusCode();
            var bowTwistFormulaString = await bowTwistFormularesponse.Content.ReadAsStringAsync();
            var bowTwistFormulaOdataresponse = JsonConvert.DeserializeObject<ODataResponse<BowTwistFormulaModel>>(bowTwistFormulaString);
            List<BowTwistFormulaModel> result = bowTwistFormulaOdataresponse.Value;

            Assert.NotNull(bowTwistFormulaOdataresponse.Value);
            Assert.IsAssignableFrom<List<BowTwistFormulaModel>>(result);
        }

    }
}
