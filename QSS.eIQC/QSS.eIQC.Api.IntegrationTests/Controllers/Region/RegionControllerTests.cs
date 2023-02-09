using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.RegionCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.RegionCommand.Update;
using QSS.eIQC.Handlers.Commands.RegionCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.RegionCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class RegionControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/Region";
        private const string oDataUrl = "odata/Region";
        private const string UpdateValue = "Update Region";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddRegion_ReturnsAddedRegion(AddRegionModel addRegionModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddRegionModel>().GetHttpContent(addRegionModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addRegionModel.Name, responseString);
        }

        [Fact]
        public async Task AddRegion_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddRegionModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateRegion_ReturnsUpdatedRegion(UpdateRegionModel updateRegionModel)
        {
            //Arrange
            updateRegionModel = await GetUpdateRegionModel(updateRegionModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateRegionModel.Id}", new HttpContentBuilder<UpdateRegionModel>().GetHttpContent(updateRegionModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateRegion_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateRegionModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateRegion_ChangedLastUpdatedReturnsInternalServerError(UpdateRegionModel updateRegionModel)
        {
            //Arrange
            updateRegionModel = await GetUpdateRegionModel(updateRegionModel);
            updateRegionModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateRegionModel.Id}", new HttpContentBuilder<UpdateRegionModel>().GetHttpContent(updateRegionModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateRegion_NotExistIdReturnsInternalServerError(UpdateRegionModel updateRegionModel)
        {
            //Arrange
            updateRegionModel = await GetUpdateRegionModel(updateRegionModel);
            updateRegionModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateRegionModel.Id}", new HttpContentBuilder<UpdateRegionModel>().GetHttpContent(updateRegionModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteRegion_ReturnsTrue(DeleteRegionModel deleteRegionModel)
        {
            //Arrange
            deleteRegionModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteRegionModel.Id}");
            request.Content = new HttpContentBuilder<DeleteRegionModel>().GetHttpContent(deleteRegionModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteRegion_NotExistIdReturnsInternalServerError(DeleteRegionModel deleteRegionModel)
        {
            //Arrange
            deleteRegionModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteRegionModel.Id}");
            request.Content = new HttpContentBuilder<DeleteRegionModel>().GetHttpContent(deleteRegionModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateRegionModel> GetUpdateRegionModel(UpdateRegionModel updateRegionModel)
        {
            var regionresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var regionString = await regionresponse.Content.ReadAsStringAsync();
            var regionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RegionModel>>(regionString);
            var region = regionOdataresponse.Value;

            updateRegionModel.Name = UpdateValue;
            updateRegionModel.Id = region[0].Id;
            updateRegionModel.LastUpdated = region[0].LastUpdated;

            return updateRegionModel;
        }
    }


}
