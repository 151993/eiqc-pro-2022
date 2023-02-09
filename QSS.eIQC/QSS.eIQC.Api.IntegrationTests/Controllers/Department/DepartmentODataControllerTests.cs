using Newtonsoft.Json;
using OData.QueryBuilder.Builders;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using QSS.eIQC.IntegrationTests.Core;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using QSS.eIQC.IntegrationTests.Core.OdataHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace QSS.eIQC.Api.IntegrationTests.Controllers.Department
{
    public class DepartmentODataControllerTests : IntegrationTestFixture
    {
        private const string oDataEntity = "Department";

        private ODataQueryBuilder<ODataInfoContainer<DepartmentModel>> _builder;

        public DepartmentODataControllerTests()
        {
           _builder = new ODataBuilder<DepartmentModel>().GetODataQueryBuilder();
        }

        [Fact]
        public async Task GetDepartment_ReturnsTop5Departments()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().Top(5).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync(oDataUrl);

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetDepartment_ReturnsSpecifiedIdDepartment()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync($"{oDataUrl}/10");

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
            
        }

        [Fact]
        public async Task GetDepartment_ReturnsFiltered_NameDepartment()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().Filter(s => s.Name == "Department 4").ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync(oDataUrl);

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
            Assert.Single(result);
            Assert.Equal(DepartmentMoq.Departments[3].Name, result[0].Name);
        }

        [Fact]
        public async Task GetDepartment_ReturnsCountDepartment()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().Count().ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync(oDataUrl);

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
            //Assert.Equal(10,result.Count());
            Assert.True(result.Count > 7);
        }

        [Fact]
        public async Task GetDepartment_ReturnsCominationFiltered_Department()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Europe") || f.Contains(s.Name, "Asia")).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync(oDataUrl);

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public async Task GetDepartment_ReturnsFiltered_Combination_NameAndIdDepartment()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().Filter((s, f) => f.Contains(s.Name, "Asia") && s.Id > 7)
                .OrderByDescending(s=> s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync(oDataUrl);

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(9, result[0].Id);
        }

        [Fact]
        public async Task GetDepartment_ReturnsSelected_Field_For_Department()
        {
            //Arrange
            Uri uri = _builder.For<DepartmentModel>(s => s.Entity).ByList().Select(s=> s.Name).OrderByDescending(s => s.Id).ToUri();
            string oDataUrl = OdataUrlFormatter.GetOdataUrl(uri, oDataEntity);

            // Act
            var departmentresponse = await _client.GetAsync(oDataUrl);

            // Assert
            departmentresponse.EnsureSuccessStatusCode();
            var departmentString = await departmentresponse.Content.ReadAsStringAsync();
            var departmentOdataresponse = JsonConvert.DeserializeObject<ODataResponse<DepartmentModel>>(departmentString);
            List<DepartmentModel> result = departmentOdataresponse.Value;

            Assert.NotNull(departmentOdataresponse.Value);
            Assert.IsAssignableFrom<List<DepartmentModel>>(result);
        }

    }
}
