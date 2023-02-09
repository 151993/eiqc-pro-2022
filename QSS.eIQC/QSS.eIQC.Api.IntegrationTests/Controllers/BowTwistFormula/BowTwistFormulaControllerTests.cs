/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Update;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class BowTwistFormulaControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/BowTwistFormula";
        private const string oDataUrl = "odata/BowTwistFormula";
        private const string UpdateValue = "Update BowTwistFormula";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

        [Theory, AutoMoqData]
        public async Task AddBowTwistFormula_ReturnsAddedBowTwistFormula(AddBowTwistFormulaModel addBowTwistFormulaModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddBowTwistFormulaModel>().GetHttpContent(addBowTwistFormulaModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addBowTwistFormulaModel.Name, responseString);
        }

        [Fact]
        public async Task AddBowTwistFormula_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddBowTwistFormulaModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateBowTwistFormula_ReturnsUpdatedBowTwistFormula(UpdateBowTwistFormulaModel updateBowTwistFormulaModel)
        {
            //Arrange
            updateBowTwistFormulaModel = await GetUpdateBowTwistFormulaModel(updateBowTwistFormulaModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateBowTwistFormulaModel.Id}", new HttpContentBuilder<UpdateBowTwistFormulaModel>().GetHttpContent(updateBowTwistFormulaModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateBowTwistFormula_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateBowTwistFormulaModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateBowTwistFormula_ChangedLastUpdatedReturnsInternalServerError(UpdateBowTwistFormulaModel updateBowTwistFormulaModel)
        {
            //Arrange
            updateBowTwistFormulaModel = await GetUpdateBowTwistFormulaModel(updateBowTwistFormulaModel);
            updateBowTwistFormulaModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateBowTwistFormulaModel.Id}", new HttpContentBuilder<UpdateBowTwistFormulaModel>().GetHttpContent(updateBowTwistFormulaModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateBowTwistFormula_NotExistIdReturnsInternalServerError(UpdateBowTwistFormulaModel updateBowTwistFormulaModel)
        {
            //Arrange
            updateBowTwistFormulaModel = await GetUpdateBowTwistFormulaModel(updateBowTwistFormulaModel);
            updateBowTwistFormulaModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateBowTwistFormulaModel.Id}", new HttpContentBuilder<UpdateBowTwistFormulaModel>().GetHttpContent(updateBowTwistFormulaModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteBowTwistFormula_ReturnsTrue(DeleteBowTwistFormulaModel deleteBowTwistFormulaModel)
        {
            //Arrange
            deleteBowTwistFormulaModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteBowTwistFormulaModel.Id}");
            request.Content = new HttpContentBuilder<DeleteBowTwistFormulaModel>().GetHttpContent(deleteBowTwistFormulaModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteBowTwistFormula_NotExistIdReturnsInternalServerError(DeleteBowTwistFormulaModel deleteBowTwistFormulaModel)
        {
            //Arrange
            deleteBowTwistFormulaModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteBowTwistFormulaModel.Id}");
            request.Content = new HttpContentBuilder<DeleteBowTwistFormulaModel>().GetHttpContent(deleteBowTwistFormulaModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateBowTwistFormulaModel> GetUpdateBowTwistFormulaModel(UpdateBowTwistFormulaModel updateBowTwistFormulaModel)
        {
            var bowTwistFormularesponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var bowTwistFormulaString = await bowTwistFormularesponse.Content.ReadAsStringAsync();
            var bowTwistFormulaOdataresponse = JsonConvert.DeserializeObject<ODataResponse<BowTwistFormulaModel>>(bowTwistFormulaString);
            var bowTwistFormula = bowTwistFormulaOdataresponse.Value;

            updateBowTwistFormulaModel.Name = UpdateValue;
            updateBowTwistFormulaModel.Id = bowTwistFormula[0].Id;
            updateBowTwistFormulaModel.LastUpdated = bowTwistFormula[0].LastUpdated;

            return updateBowTwistFormulaModel;
        }
    }


}
