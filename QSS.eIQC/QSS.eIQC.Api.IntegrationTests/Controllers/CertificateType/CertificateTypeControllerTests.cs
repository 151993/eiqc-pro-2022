/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Update;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.CertificateTypeCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class CertificateTypeControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/CertificateType";
        private const string oDataUrl = "odata/CertificateType";
        private const string UpdateValue = "Update CertificateType";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddCertificateType_ReturnsAddedCertificateType(AddCertificateTypeModel addCertificateTypeModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddCertificateTypeModel>().GetHttpContent(addCertificateTypeModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addCertificateTypeModel.Name, responseString);
        }

        [Fact]
        public async Task AddCertificateType_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddCertificateTypeModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateCertificateType_ReturnsUpdatedCertificateType(UpdateCertificateTypeModel updateCertificateTypeModel)
        {
            //Arrange
            updateCertificateTypeModel = await GetUpdateCertificateTypeModel(updateCertificateTypeModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateCertificateTypeModel.Id}", new HttpContentBuilder<UpdateCertificateTypeModel>().GetHttpContent(updateCertificateTypeModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateCertificateType_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateCertificateTypeModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateCertificateType_ChangedLastUpdatedReturnsInternalServerError(UpdateCertificateTypeModel updateCertificateTypeModel)
        {
            //Arrange
            updateCertificateTypeModel = await GetUpdateCertificateTypeModel(updateCertificateTypeModel);
            updateCertificateTypeModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateCertificateTypeModel.Id}", new HttpContentBuilder<UpdateCertificateTypeModel>().GetHttpContent(updateCertificateTypeModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateCertificateType_NotExistIdReturnsInternalServerError(UpdateCertificateTypeModel updateCertificateTypeModel)
        {
            //Arrange
            updateCertificateTypeModel = await GetUpdateCertificateTypeModel(updateCertificateTypeModel);
            updateCertificateTypeModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateCertificateTypeModel.Id}", new HttpContentBuilder<UpdateCertificateTypeModel>().GetHttpContent(updateCertificateTypeModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteCertificateType_ReturnsTrue(DeleteCertificateTypeModel deleteCertificateTypeModel)
        {
            //Arrange
            deleteCertificateTypeModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteCertificateTypeModel.Id}");
            request.Content = new HttpContentBuilder<DeleteCertificateTypeModel>().GetHttpContent(deleteCertificateTypeModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteCertificateType_NotExistIdReturnsInternalServerError(DeleteCertificateTypeModel deleteCertificateTypeModel)
        {
            //Arrange
            deleteCertificateTypeModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteCertificateTypeModel.Id}");
            request.Content = new HttpContentBuilder<DeleteCertificateTypeModel>().GetHttpContent(deleteCertificateTypeModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateCertificateTypeModel> GetUpdateCertificateTypeModel(UpdateCertificateTypeModel updateCertificateTypeModel)
        {
            var certificateTyperesponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var certificateTypeString = await certificateTyperesponse.Content.ReadAsStringAsync();
            var certificateTypeOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CertificateTypeModel>>(certificateTypeString);
            var certificateType = certificateTypeOdataresponse.Value;

            updateCertificateTypeModel.Name = UpdateValue;
            updateCertificateTypeModel.Id = certificateType[0].Id;
            updateCertificateTypeModel.LastUpdated = certificateType[0].LastUpdated;

            return updateCertificateTypeModel;
        }
    }


}
