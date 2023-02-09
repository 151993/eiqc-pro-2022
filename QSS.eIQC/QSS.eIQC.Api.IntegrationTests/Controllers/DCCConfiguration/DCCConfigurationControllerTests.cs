/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Update;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.DCCConfigurationCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class DCCConfigurationControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/DCCConfiguration";
        private const string oDataUrl = "odata/DCCConfiguration";
        private const string UpdateValue = "Update DCCConfiguration";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddDCCConfiguration_ReturnsAddedDCCConfiguration(AddDCCConfigurationModel addDCCConfigurationModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddDCCConfigurationModel>().GetHttpContent(addDCCConfigurationModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addDCCConfigurationModel.SiteNo, responseString);
        }

        [Fact]
        public async Task AddDCCConfiguration_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddDCCConfigurationModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateDCCConfiguration_ReturnsUpdatedDCCConfiguration(UpdateDCCConfigurationModel updateDCCConfigurationModel)
        {
            //Arrange
            updateDCCConfigurationModel = await GetUpdateDCCConfigurationModel(updateDCCConfigurationModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDCCConfigurationModel.Id}", new HttpContentBuilder<UpdateDCCConfigurationModel>().GetHttpContent(updateDCCConfigurationModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateDCCConfiguration_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateDCCConfigurationModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateDCCConfiguration_ChangedLastUpdatedReturnsInternalServerError(UpdateDCCConfigurationModel updateDCCConfigurationModel)
        {
            //Arrange
            updateDCCConfigurationModel = await GetUpdateDCCConfigurationModel(updateDCCConfigurationModel);
            updateDCCConfigurationModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDCCConfigurationModel.Id}", new HttpContentBuilder<UpdateDCCConfigurationModel>().GetHttpContent(updateDCCConfigurationModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateDCCConfiguration_NotExistIdReturnsInternalServerError(UpdateDCCConfigurationModel updateDCCConfigurationModel)
        {
            //Arrange
            updateDCCConfigurationModel = await GetUpdateDCCConfigurationModel(updateDCCConfigurationModel);
            updateDCCConfigurationModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDCCConfigurationModel.Id}", new HttpContentBuilder<UpdateDCCConfigurationModel>().GetHttpContent(updateDCCConfigurationModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteDCCConfiguration_ReturnsTrue(DeleteDCCConfigurationModel deleteDCCConfigurationModel)
        {
            //Arrange
            deleteDCCConfigurationModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteDCCConfigurationModel.Id}");
            request.Content = new HttpContentBuilder<DeleteDCCConfigurationModel>().GetHttpContent(deleteDCCConfigurationModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteDCCConfiguration_NotExistIdReturnsInternalServerError(DeleteDCCConfigurationModel deleteDCCConfigurationModel)
        {
            //Arrange
            deleteDCCConfigurationModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteDCCConfigurationModel.Id}");
            request.Content = new HttpContentBuilder<DeleteDCCConfigurationModel>().GetHttpContent(deleteDCCConfigurationModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateDCCConfigurationModel> GetUpdateDCCConfigurationModel(UpdateDCCConfigurationModel updateDCCConfigurationModel)
        {
            var dCCConfigurationresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var dCCConfigurationString = await dCCConfigurationresponse.Content.ReadAsStringAsync();
            var dCCConfigurationOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DCCConfigurationModel>>(dCCConfigurationString);
            var dCCConfiguration = dCCConfigurationOdataresponse.Value;

            updateDCCConfigurationModel.SiteNo = UpdateValue;
            updateDCCConfigurationModel.Id = dCCConfiguration[0].Id;
            updateDCCConfigurationModel.LastUpdated = dCCConfiguration[0].LastUpdated;

            return updateDCCConfigurationModel;
        }
    }


}
