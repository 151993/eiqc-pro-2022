
using QSS.eIQC.Domain.Common;
using QSS.eIQC.UnitTests.Core.TestModels;
using QSS.eIQC.Utilities.Helper;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace QSS.eIQC.UnitTests.Core.Tests
{
    public class JsonDeserializerTests
    {
        [Fact]
        public void GetDeserializeObject()
        {
            // Act
            List<TestJsonModel> result =  JsonDeserializer.DeserializerObject<TestJsonModel>("TestData","TestJson");

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<List<TestJsonModel>>(result);
            Assert.Equal("Test", result.ToList()[0].Name);
            Assert.Equal(12345678, result.ToList()[0].Mobile);
            Assert.True(result.ToList()[0].Boolean);
            Assert.Equal(2, result.ToList()[0].Pets.Count());
            Assert.Equal("USA", result.ToList()[0].Address.PermanentAddress);
            Assert.Equal("India", result.ToList()[0].Address.CurrentAddress);
        }
    }
}