using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Update;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class DepartmentControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/Department";
        private const string oDataUrl = "odata/Department";
        private const string UpdateValue = "Update Department";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddDepartment_ReturnsAddedDepartment(AddDepartmentModel addDepartmentModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddDepartmentModel>().GetHttpContent(addDepartmentModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addDepartmentModel.Name, responseString);
        }

        [Fact]
        public async Task AddDepartment_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddDepartmentModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateDepartment_ReturnsUpdatedDepartment(UpdateDepartmentModel updateDepartmentModel)
        {
            //Arrange
            updateDepartmentModel = await GetUpdateDepartmentModel(updateDepartmentModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDepartmentModel.Id}", new HttpContentBuilder<UpdateDepartmentModel>().GetHttpContent(updateDepartmentModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateDepartment_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateDepartmentModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateDepartment_ChangedLastUpdatedReturnsInternalServerError(UpdateDepartmentModel updateDepartmentModel)
        {
            //Arrange
            updateDepartmentModel = await GetUpdateDepartmentModel(updateDepartmentModel);
            updateDepartmentModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDepartmentModel.Id}", new HttpContentBuilder<UpdateDepartmentModel>().GetHttpContent(updateDepartmentModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateDepartment_NotExistIdReturnsInternalServerError(UpdateDepartmentModel updateDepartmentModel)
        {
            //Arrange
            updateDepartmentModel = await GetUpdateDepartmentModel(updateDepartmentModel);
            updateDepartmentModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateDepartmentModel.Id}", new HttpContentBuilder<UpdateDepartmentModel>().GetHttpContent(updateDepartmentModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteDepartment_ReturnsTrue(DeleteDepartmentModel deleteDepartmentModel)
        {
            //Arrange
            deleteDepartmentModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteDepartmentModel.Id}");
            request.Content = new HttpContentBuilder<DeleteDepartmentModel>().GetHttpContent(deleteDepartmentModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteDepartment_NotExistIdReturnsInternalServerError(DeleteDepartmentModel deleteDepartmentModel)
        {
            //Arrange
            deleteDepartmentModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteDepartmentModel.Id}");
            request.Content = new HttpContentBuilder<DeleteDepartmentModel>().GetHttpContent(deleteDepartmentModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateDepartmentModel> GetUpdateDepartmentModel(UpdateDepartmentModel updateDepartmentModel)
        {
            var departmentresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            var department = departmentOdataresponse.Value;

            updateDepartmentModel.Name = UpdateValue;
            updateDepartmentModel.Id = department[0].Id;
            updateDepartmentModel.LastUpdated = department[0].LastUpdated;

            return updateDepartmentModel;
        }
    }


}
