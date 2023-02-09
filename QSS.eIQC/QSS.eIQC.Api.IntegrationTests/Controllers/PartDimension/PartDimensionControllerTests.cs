/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Update;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class PartDimensionControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/PartDimension";
        private const string oDataUrl = "odata/PartDimension";
        private const string UpdateValue = "Update PartDimension";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddPartDimension_ReturnsAddedPartDimension(AddPartDimensionModel addPartDimensionModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddPartDimensionModel>().GetHttpContent(addPartDimensionModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addPartDimensionModel.Name, responseString);
        }

        [Fact]
        public async Task AddPartDimension_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddPartDimensionModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdatePartDimension_ReturnsUpdatedPartDimension(UpdatePartDimensionModel updatePartDimensionModel)
        {
            //Arrange
            updatePartDimensionModel = await GetUpdatePartDimensionModel(updatePartDimensionModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updatePartDimensionModel.Id}", new HttpContentBuilder<UpdatePartDimensionModel>().GetHttpContent(updatePartDimensionModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdatePartDimension_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdatePartDimensionModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdatePartDimension_ChangedLastUpdatedReturnsInternalServerError(UpdatePartDimensionModel updatePartDimensionModel)
        {
            //Arrange
            updatePartDimensionModel = await GetUpdatePartDimensionModel(updatePartDimensionModel);
            updatePartDimensionModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updatePartDimensionModel.Id}", new HttpContentBuilder<UpdatePartDimensionModel>().GetHttpContent(updatePartDimensionModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdatePartDimension_NotExistIdReturnsInternalServerError(UpdatePartDimensionModel updatePartDimensionModel)
        {
            //Arrange
            updatePartDimensionModel = await GetUpdatePartDimensionModel(updatePartDimensionModel);
            updatePartDimensionModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updatePartDimensionModel.Id}", new HttpContentBuilder<UpdatePartDimensionModel>().GetHttpContent(updatePartDimensionModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeletePartDimension_ReturnsTrue(DeletePartDimensionModel deletePartDimensionModel)
        {
            //Arrange
            deletePartDimensionModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deletePartDimensionModel.Id}");
            request.Content = new HttpContentBuilder<DeletePartDimensionModel>().GetHttpContent(deletePartDimensionModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeletePartDimension_NotExistIdReturnsInternalServerError(DeletePartDimensionModel deletePartDimensionModel)
        {
            //Arrange
            deletePartDimensionModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deletePartDimensionModel.Id}");
            request.Content = new HttpContentBuilder<DeletePartDimensionModel>().GetHttpContent(deletePartDimensionModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdatePartDimensionModel> GetUpdatePartDimensionModel(UpdatePartDimensionModel updatePartDimensionModel)
        {
            var partDimensionresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var partDimensionString = await partDimensionresponse.Content.ReadAsStringAsync();
            var partDimensionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<PartDimensionModel>>(partDimensionString);
            var partDimension = partDimensionOdataresponse.Value;

            updatePartDimensionModel.Name = UpdateValue;
            updatePartDimensionModel.Id = partDimension[0].Id;
            updatePartDimensionModel.LastUpdated = partDimension[0].LastUpdated;

            return updatePartDimensionModel;
        }
    }


}
