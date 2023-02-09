/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.CertificateType
{
    public class CertificateTypeODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "CertificateType";

        private ODataQueryBuilder<ODataInfoContainer<CertificateTypeModel>> _builder;

        public CertificateTypeODataControllerTests()
        {
           _builder = new ODataBuilder<CertificateTypeModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetCertificateType_ReturnsTop5CertificateTypes()
        {
            //Arrange
            Uri uri = _builder.For<CertificateTypeModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var certificateTyperesponse = await _client.GetAsync(oDataUrl);

            // Assert
            certificateTyperesponse.EnsureSuccessStatusCode();
            var certificateTypeString = await certificateTyperesponse.Content.ReadAsStringAsync();
            var certificateTypeOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CertificateTypeModel>>(certificateTypeString);
            List<CertificateTypeModel> result = certificateTypeOdataresponse.Value;

            Assert.NotNull(certificateTypeOdataresponse.Value);
            Assert.IsAssignableFrom<List<CertificateTypeModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetCertificateType_ReturnsSpecifiedIdCertificateType()
        {
            //Arrange
            Uri uri = _builder.For<CertificateTypeModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var certificateTyperesponse = await _client.GetAsync($"{oDataUrl}/1");

            // Assert
            certificateTyperesponse.EnsureSuccessStatusCode();
            var certificateTypeString = await certificateTyperesponse.Content.ReadAsStringAsync();
            var certificateTypeOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CertificateTypeModel>>(certificateTypeString);
            List<CertificateTypeModel> result = certificateTypeOdataresponse.Value;

            Assert.NotNull(certificateTypeOdataresponse.Value);
            Assert.IsAssignableFrom<List<CertificateTypeModel>>(result);
            
        }

        [Fact]
        public async Task GetCertificateType_ReturnsCountCertificateType()
        {
            //Arrange
            Uri uri = _builder.For<CertificateTypeModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var certificateTyperesponse = await _client.GetAsync(oDataUrl);

            // Assert
            certificateTyperesponse.EnsureSuccessStatusCode();
            var certificateTypeString = await certificateTyperesponse.Content.ReadAsStringAsync();
            var certificateTypeOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CertificateTypeModel>>(certificateTypeString);
            List<CertificateTypeModel> result = certificateTypeOdataresponse.Value;

            Assert.NotNull(certificateTypeOdataresponse.Value);
            Assert.IsAssignableFrom<List<CertificateTypeModel>>(result);
            Assert.Equal(10,result.Count());
        }

        [Fact]
        public async Task GetCertificateType_ReturnsSelected_Field_For_CertificateType()
        {
            //Arrange
            Uri uri = _builder.For<CertificateTypeModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var certificateTyperesponse = await _client.GetAsync(oDataUrl);

            // Assert
            certificateTyperesponse.EnsureSuccessStatusCode();
            var certificateTypeString = await certificateTyperesponse.Content.ReadAsStringAsync();
            var certificateTypeOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CertificateTypeModel>>(certificateTypeString);
            List<CertificateTypeModel> result = certificateTypeOdataresponse.Value;

            Assert.NotNull(certificateTypeOdataresponse.Value);
            Assert.IsAssignableFrom<List<CertificateTypeModel>>(result);
        }

    }
}
