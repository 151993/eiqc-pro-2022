using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.CountryCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.CountryCommand.Update;
using QSS.eIQC.Handlers.Commands.CountryCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.CountryCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class CountryControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/Country";
        private const string oDataUrl = "odata/Country";
        private const string UpdateValue = "Update Country";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddCountry_ReturnsAddedCountry(AddCountryModel addCountryModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddCountryModel>().GetHttpContent(addCountryModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addCountryModel.Name, responseString);
        }

        [Fact]
        public async Task AddCountry_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddCountryModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        //[Theory, AutoMoqData]
        //public async Task UpdateCountry_ReturnsUpdatedCountry(UpdateCountryModel updateCountryModel)
        //{
        //    //Arrange
        //    updateCountryModel = await GetUpdateCountryModel(updateCountryModel);

        //    // Act
        //    var response = await _client.PutAsync($"{ApiUrl}/{updateCountryModel.Id}", new HttpContentBuilder<UpdateCountryModel>().GetHttpContent(updateCountryModel));
            
        //    // Assert
        //    response.EnsureSuccessStatusCode();
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    Assert.Contains(UpdateValue, responseString);
        //}

        [Fact]
        public async Task UpdateCountry_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateCountryModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateCountry_ChangedLastUpdatedReturnsInternalServerError(UpdateCountryModel updateCountryModel)
        {
            //Arrange
            updateCountryModel = await GetUpdateCountryModel(updateCountryModel);
            updateCountryModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateCountryModel.Id}", new HttpContentBuilder<UpdateCountryModel>().GetHttpContent(updateCountryModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateCountry_NotExistIdReturnsInternalServerError(UpdateCountryModel updateCountryModel)
        {
            //Arrange
            updateCountryModel = await GetUpdateCountryModel(updateCountryModel);
            updateCountryModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateCountryModel.Id}", new HttpContentBuilder<UpdateCountryModel>().GetHttpContent(updateCountryModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteCountry_ReturnsTrue(DeleteCountryModel deleteCountryModel)
        {
            //Arrange
            deleteCountryModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteCountryModel.Id}");
            request.Content = new HttpContentBuilder<DeleteCountryModel>().GetHttpContent(deleteCountryModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteCountry_NotExistIdReturnsInternalServerError(DeleteCountryModel deleteCountryModel)
        {
            //Arrange
            deleteCountryModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteCountryModel.Id}");
            request.Content = new HttpContentBuilder<DeleteCountryModel>().GetHttpContent(deleteCountryModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateCountryModel> GetUpdateCountryModel(UpdateCountryModel updateCountryModel)
        {
            var workcellresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var workcellString = await workcellresponse.Content.ReadAsStringAsync();
            var workCellOdataresponse = JsonConvert.DeserializeObject<ODataResponse<CountryModel>>(workcellString);
            var workCell = workCellOdataresponse.Value;

            updateCountryModel.Name = UpdateValue;
            updateCountryModel.Id = workCell[0].Id;
            updateCountryModel.LastUpdated = workCell[0].LastUpdated;

            return updateCountryModel;
        }
    }


}
