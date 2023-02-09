using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.RoleCommand.Update;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.RoleCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class RoleControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/Role";
        private const string oDataUrl = "odata/Role";
        private const string UpdateValue = "Update Role";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddRole_ReturnsAddedRole(AddRoleModel addRoleModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddRoleModel>().GetHttpContent(addRoleModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addRoleModel.Name, responseString);
        }

        [Fact]
        public async Task AddRole_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddRoleModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateRole_ReturnsUpdatedRole(UpdateRoleModel updateRoleModel)
        {
            //Arrange
            updateRoleModel = await GetUpdateRoleModel(updateRoleModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateRoleModel.Id}", new HttpContentBuilder<UpdateRoleModel>().GetHttpContent(updateRoleModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateRole_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateRoleModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateRole_ChangedLastUpdatedReturnsInternalServerError(UpdateRoleModel updateRoleModel)
        {
            //Arrange
            updateRoleModel = await GetUpdateRoleModel(updateRoleModel);
            updateRoleModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateRoleModel.Id}", new HttpContentBuilder<UpdateRoleModel>().GetHttpContent(updateRoleModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateRole_NotExistIdReturnsInternalServerError(UpdateRoleModel updateRoleModel)
        {
            //Arrange
            updateRoleModel = await GetUpdateRoleModel(updateRoleModel);
            updateRoleModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateRoleModel.Id}", new HttpContentBuilder<UpdateRoleModel>().GetHttpContent(updateRoleModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteRole_ReturnsTrue(DeleteRoleModel deleteRoleModel)
        {
            //Arrange
            deleteRoleModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteRoleModel.Id}");
            request.Content = new HttpContentBuilder<DeleteRoleModel>().GetHttpContent(deleteRoleModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteRole_NotExistIdReturnsInternalServerError(DeleteRoleModel deleteRoleModel)
        {
            //Arrange
            deleteRoleModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteRoleModel.Id}");
            request.Content = new HttpContentBuilder<DeleteRoleModel>().GetHttpContent(deleteRoleModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateRoleModel> GetUpdateRoleModel(UpdateRoleModel updateRoleModel)
        {
            var roleresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            var role = roleOdataresponse.Value;

            updateRoleModel.Name = UpdateValue;
            updateRoleModel.Id = role[0].Id;
            updateRoleModel.LastUpdated = role[0].LastUpdated;

            return updateRoleModel;
        }
    }


}
