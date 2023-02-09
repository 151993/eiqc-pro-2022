using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.Role
{
    public class RoleODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "Role";

        private ODataQueryBuilder<ODataInfoContainer<RoleModel>> _builder;

        public RoleODataControllerTests()
        {
           _builder = new ODataBuilder<RoleModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetRole_ReturnsTop5Roles()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync(oDataUrl);

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetRole_ReturnsSpecifiedIdRole()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync($"{oDataUrl}/10");

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
            
        }

        [Fact]
        public async Task GetRole_ReturnsFiltered_NameRole()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().Filter(s => s.Name == "Role 4").ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync(oDataUrl);

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
            Assert.Single(result);
            Assert.Equal(RoleMoq.Roles[3].Name, result[0].Name);
        }

        [Fact]
        public async Task GetRole_ReturnsCountRole()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync(oDataUrl);

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
            Assert.Equal(10,result.Count());
        }

        [Fact]
        public async Task GetRole_ReturnsCominationFiltered_Role()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Europe") || f.Contains(s.Name, "Asia")).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync(oDataUrl);

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetRole_ReturnsFiltered_Combination_NameAndIdRole()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Asia") && s.Id > 7)
                .OrderByDescending(s=> s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync(oDataUrl);

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(9, result[0].Id);
        }

        [Fact]
        public async Task GetRole_ReturnsSelected_Field_For_Role()
        {
            //Arrange
            Uri uri = _builder.For<RoleModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var roleresponse = await _client.GetAsync(oDataUrl);

            // Assert
            roleresponse.EnsureSuccessStatusCode();
            var roleString = await roleresponse.Content.ReadAsStringAsync();
            var roleOdataresponse = JsonConvert.DeserializeObject<ODataResponse<RoleModel>>(roleString);
            List<RoleModel> result = roleOdataresponse.Value;

            Assert.NotNull(roleOdataresponse.Value);
            Assert.IsAssignableFrom<List<RoleModel>>(result);
        }

    }
}
