using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Update;
using QSS.eIQC.Handlers.Commands.DivisionCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class DivisionControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/Division";
        private const string oDataUrl = "odata/Division";
        private const string UpdateValue = "Update Division";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddDivision_ReturnsAddedDivision(AddDivisionModel addDivisionModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddDivisionModel>().GetHttpContent(addDivisionModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addDivisionModel.Name, responseString);
        }

        [Fact]
        public async Task AddDivision_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddDivisionModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateDivision_ReturnsUpdatedDivision(UpdateDivisionModel updateDivisionModel)
        {
            //Arrange
            updateDivisionModel = await GetUpdateDivisionModel(updateDivisionModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDivisionModel.Id}", new HttpContentBuilder<UpdateDivisionModel>().GetHttpContent(updateDivisionModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateDivision_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateDivisionModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateDivision_ChangedLastUpdatedReturnsInternalServerError(UpdateDivisionModel updateDivisionModel)
        {
            //Arrange
            updateDivisionModel = await GetUpdateDivisionModel(updateDivisionModel);
            updateDivisionModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDivisionModel.Id}", new HttpContentBuilder<UpdateDivisionModel>().GetHttpContent(updateDivisionModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateDivision_NotExistIdReturnsInternalServerError(UpdateDivisionModel updateDivisionModel)
        {
            //Arrange
            updateDivisionModel = await GetUpdateDivisionModel(updateDivisionModel);
            updateDivisionModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDivisionModel.Id}", new HttpContentBuilder<UpdateDivisionModel>().GetHttpContent(updateDivisionModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteDivision_ReturnsTrue(DeleteDivisionModel deleteDivisionModel)
        {
            //Arrange
            deleteDivisionModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteDivisionModel.Id}");
            request.Content = new HttpContentBuilder<DeleteDivisionModel>().GetHttpContent(deleteDivisionModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteDivision_NotExistIdReturnsInternalServerError(DeleteDivisionModel deleteDivisionModel)
        {
            //Arrange
            deleteDivisionModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteDivisionModel.Id}");
            request.Content = new HttpContentBuilder<DeleteDivisionModel>().GetHttpContent(deleteDivisionModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateDivisionModel> GetUpdateDivisionModel(UpdateDivisionModel updateDivisionModel)
        {
            var divisionresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var divisionString = await divisionresponse.Content.ReadAsStringAsync();
            var divisionOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DivisionModel>>(divisionString);
            var division = divisionOdataresponse.Value;

            updateDivisionModel.Name = UpdateValue;
            updateDivisionModel.Id = division[0].Id;
            updateDivisionModel.LastUpdated = division[0].LastUpdated;

            return updateDivisionModel;
        }
    }


}
