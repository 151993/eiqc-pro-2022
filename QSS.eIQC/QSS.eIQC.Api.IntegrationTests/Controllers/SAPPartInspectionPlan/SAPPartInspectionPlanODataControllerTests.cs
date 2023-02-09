/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.SAPPartInspectionPlan
{
    public class SAPPartInspectionPlanODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "SAPPartInspectionPlan";

        private ODataQueryBuilder<ODataInfoContainer<SAPPartInspectionPlanModel>> _builder;

        public SAPPartInspectionPlanODataControllerTests()
        {
           _builder = new ODataBuilder<SAPPartInspectionPlanModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetSAPPartInspectionPlan_ReturnsSpecifiedIdSAPPartInspectionPlan()
        {
            //Arrange
            Uri uri = _builder.For<SAPPartInspectionPlanModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var sAPPartInspectionPlanresponse = await _client.GetAsync($"{oDataUrl}/1");

            // Assert
            sAPPartInspectionPlanresponse.EnsureSuccessStatusCode();
            var sAPPartInspectionPlanString = await sAPPartInspectionPlanresponse.Content.ReadAsStringAsync();
            var sAPPartInspectionPlanOdataresponse = JsonConvert.DeserializeObject<ODataResponse<SAPPartInspectionPlanModel>>(sAPPartInspectionPlanString);
            List<SAPPartInspectionPlanModel> result = sAPPartInspectionPlanOdataresponse.Value;

            Assert.NotNull(sAPPartInspectionPlanOdataresponse.Value);
            Assert.IsAssignableFrom<List<SAPPartInspectionPlanModel>>(result);
            
        }

        [Fact]
        public async Task GetSAPPartInspectionPlan_ReturnsSelected_Field_For_SAPPartInspectionPlan()
        {
            //Arrange
            Uri uri = _builder.For<SAPPartInspectionPlanModel>(s => s.Entity).ByList().Select(s=> s.PartNo).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var sAPPartInspectionPlanresponse = await _client.GetAsync(oDataUrl);

            // Assert
            sAPPartInspectionPlanresponse.EnsureSuccessStatusCode();
            var sAPPartInspectionPlanString = await sAPPartInspectionPlanresponse.Content.ReadAsStringAsync();
            var sAPPartInspectionPlanOdataresponse = JsonConvert.DeserializeObject<ODataResponse<SAPPartInspectionPlanModel>>(sAPPartInspectionPlanString);
            List<SAPPartInspectionPlanModel> result = sAPPartInspectionPlanOdataresponse.Value;

            Assert.NotNull(sAPPartInspectionPlanOdataresponse.Value);
            Assert.IsAssignableFrom<List<SAPPartInspectionPlanModel>>(result);
        }

    }
}
