using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Update;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class WorkCellControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/WorkCell";
        private const string oDataUrl = "odata/WorkCell";
        private const string UpdateValue = "Update WorkCell";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddWorkCell_ReturnsAddedWorkCell(AddWorkCellModel addWorkCellModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddWorkCellModel>().GetHttpContent(addWorkCellModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addWorkCellModel.Name, responseString);
        }

        [Fact]
        public async Task AddWorkCell_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddWorkCellModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateWorkCell_ReturnsUpdatedWorkCell(UpdateWorkCellModel updateWorkCellModel)
        {
            //Arrange
            updateWorkCellModel = await GetUpdateWorkCellModel(updateWorkCellModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateWorkCellModel.Id}", new HttpContentBuilder<UpdateWorkCellModel>().GetHttpContent(updateWorkCellModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateWorkCell_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateWorkCellModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateWorkCell_ChangedLastUpdatedReturnsInternalServerError(UpdateWorkCellModel updateWorkCellModel)
        {
            //Arrange
            updateWorkCellModel = await GetUpdateWorkCellModel(updateWorkCellModel);
            updateWorkCellModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateWorkCellModel.Id}", new HttpContentBuilder<UpdateWorkCellModel>().GetHttpContent(updateWorkCellModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateWorkCell_NotExistIdReturnsInternalServerError(UpdateWorkCellModel updateWorkCellModel)
        {
            //Arrange
            updateWorkCellModel = await GetUpdateWorkCellModel(updateWorkCellModel);
            updateWorkCellModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateWorkCellModel.Id}", new HttpContentBuilder<UpdateWorkCellModel>().GetHttpContent(updateWorkCellModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteWorkCell_ReturnsTrue(DeleteWorkCellModel deleteWorkCellModel)
        {
            //Arrange
            deleteWorkCellModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteWorkCellModel.Id}");
            request.Content = new HttpContentBuilder<DeleteWorkCellModel>().GetHttpContent(deleteWorkCellModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteWorkCell_NotExistIdReturnsInternalServerError(DeleteWorkCellModel deleteWorkCellModel)
        {
            //Arrange
            deleteWorkCellModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteWorkCellModel.Id}");
            request.Content = new HttpContentBuilder<DeleteWorkCellModel>().GetHttpContent(deleteWorkCellModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateWorkCellModel> GetUpdateWorkCellModel(UpdateWorkCellModel updateWorkCellModel)
        {
            var workcellresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<WorkCellModel>>(workcellString);
            var workCell = workCellOdataresponse.Value;

            updateWorkCellModel.Name = UpdateValue;
            updateWorkCellModel.Id = workCell[0].Id;
            updateWorkCellModel.LastUpdated = workCell[0].LastUpdated;

            return updateWorkCellModel;
        }
    }


}
