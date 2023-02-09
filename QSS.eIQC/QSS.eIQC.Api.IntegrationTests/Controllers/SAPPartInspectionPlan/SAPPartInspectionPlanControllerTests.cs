/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Newtonsoft.Json;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add;
using QSS.eIQC.IntegrationTests.Core;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using QSS.eIQC.UnitTests.Core.AutoMoqData;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.IntegrationTests.Core.Common;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Delete;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;

namespace QSS.eIQC.Api.IntegrationTests.Controllers
{
    public class SAPPartInspectionPlanControllerTests :IntegrationTestFixture
    {
        private const string ApiUrl = "api/SAPPartInspectionPlan";
        private const string oDataUrl = "odata/SAPPartInspectionPlan";
        private const string UpdateValue = "Update SAPPartInspectionPlan";
        private const string ApproveRejectUrl = "api/SAPPartInspectionPlan/ApproveReject";
        private const int UpdateId = 1;
        private const int DeleteId = 2;
        private const int NotExistId = -1;

       /* [Theory, AutoMoqData]
        public async Task AddSAPPartInspectionPlan_ReturnsAddedSAPPartInspectionPlan(AddSAPPartInspectionPlanModel addSAPPartInspectionPlanModel)
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddSAPPartInspectionPlanModel>().GetHttpContent(addSAPPartInspectionPlanModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addSAPPartInspectionPlanModel.PartNo, responseString);
        }

        [Fact]
        public async Task AddSAPPartInspectionPlan_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApproveRejectUrl, new HttpContentBuilder<AddSAPPartInspectionPlanModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task AddSAPPartInspectionPlan_ReturnsApproveRejectSAPPartInspectionPlan(AddSAPPartInspectionPlanModel addSAPPartInspectionPlanModel)
        {
            // Act
            var response = await _client.PostAsync(ApproveRejectUrl, new HttpContentBuilder<AddSAPPartInspectionPlanModel>().GetHttpContent(addSAPPartInspectionPlanModel));

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(addSAPPartInspectionPlanModel.PartNo, responseString);
        }

        [Fact]
        public async Task AddSAPPartInspectionPlan_ApproveRejectWithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PostAsync(ApiUrl, new HttpContentBuilder<AddSAPPartInspectionPlanModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateSAPPartInspectionPlan_ReturnsUpdatedSAPPartInspectionPlan(UpdateSAPPartInspectionPlanModel updateSAPPartInspectionPlanModel)
        {
            //Arrange
            updateSAPPartInspectionPlanModel = await GetUpdateSAPPartInspectionPlanModel(updateSAPPartInspectionPlanModel);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateSAPPartInspectionPlanModel.Id}", new HttpContentBuilder<UpdateSAPPartInspectionPlanModel>().GetHttpContent(updateSAPPartInspectionPlanModel));
            
            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains(UpdateValue, responseString);
        }

        [Fact]
        public async Task UpdateSAPPartInspectionPlan_WithNullObjectReturnsBadRequest()
        {
            // Act
            var response = await _client.PutAsync($"{ApiUrl}/-1", new HttpContentBuilder<UpdateSAPPartInspectionPlanModel>().GetHttpContent(null));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory,AutoMoqData]
        public async Task UpdateSAPPartInspectionPlan_ChangedLastUpdatedReturnsInternalServerError(UpdateSAPPartInspectionPlanModel updateSAPPartInspectionPlanModel)
        {
            //Arrange
            updateSAPPartInspectionPlanModel = await GetUpdateSAPPartInspectionPlanModel(updateSAPPartInspectionPlanModel);
            updateSAPPartInspectionPlanModel.LastUpdated = System.DateTimeOffset.Now.AddDays(-1);

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateSAPPartInspectionPlanModel.Id}", new HttpContentBuilder<UpdateSAPPartInspectionPlanModel>().GetHttpContent(updateSAPPartInspectionPlanModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task UpdateSAPPartInspectionPlan_NotExistIdReturnsInternalServerError(UpdateSAPPartInspectionPlanModel updateSAPPartInspectionPlanModel)
        {
            //Arrange
            updateSAPPartInspectionPlanModel = await GetUpdateSAPPartInspectionPlanModel(updateSAPPartInspectionPlanModel);
            updateSAPPartInspectionPlanModel.Id = NotExistId;

            // Act
            var response = await _client.PutAsync($"{ApiUrl}/{updateSAPPartInspectionPlanModel.Id}", new HttpContentBuilder<UpdateSAPPartInspectionPlanModel>().GetHttpContent(updateSAPPartInspectionPlanModel));

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        [Theory, AutoMoqData]
        public async Task DeleteSAPPartInspectionPlan_ReturnsTrue(DeleteSAPPartInspectionPlanModel deleteSAPPartInspectionPlanModel)
        {
            //Arrange
            deleteSAPPartInspectionPlanModel.Id = DeleteId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteSAPPartInspectionPlanModel.Id}");
            request.Content = new HttpContentBuilder<DeleteSAPPartInspectionPlanModel>().GetHttpContent(deleteSAPPartInspectionPlanModel);
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("true", responseString);
        }

        [Theory, AutoMoqData]
        public async Task DeleteSAPPartInspectionPlan_NotExistIdReturnsInternalServerError(DeleteSAPPartInspectionPlanModel deleteSAPPartInspectionPlanModel)
        {
            //Arrange
            deleteSAPPartInspectionPlanModel.Id = NotExistId;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{ApiUrl}/{deleteSAPPartInspectionPlanModel.Id}");
            request.Content = new HttpContentBuilder<DeleteSAPPartInspectionPlanModel>().GetHttpContent(deleteSAPPartInspectionPlanModel);
            var response = await _client.SendAsync(request);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        private async Task<UpdateSAPPartInspectionPlanModel> GetUpdateSAPPartInspectionPlanModel(UpdateSAPPartInspectionPlanModel updateSAPPartInspectionPlanModel)
        {
            var sAPPartInspectionPlanresponse = await _client.GetAsync($"{oDataUrl}/{UpdateId}");
            var sAPPartInspectionPlanString = await sAPPartInspectionPlanresponse.Content.ReadAsStringAsync();
            var sAPPartInspectionPlanOdataresponse = JsonConvert.DeserializeObject<ODataResponse<SAPPartInspectionPlanModel>>(sAPPartInspectionPlanString);
            var sAPPartInspectionPlan = sAPPartInspectionPlanOdataresponse.Value;

            updateSAPPartInspectionPlanModel.PartNo = UpdateValue;
            updateSAPPartInspectionPlanModel.Id = sAPPartInspectionPlan!=null?  sAPPartInspectionPlan[0].Id : 0 ;
            updateSAPPartInspectionPlanModel.LastUpdated = sAPPartInspectionPlan != null ? sAPPartInspectionPlan[0].LastUpdated: DateTime.Now;

            return updateSAPPartInspectionPlanModel;
        }
       */
    }


}
