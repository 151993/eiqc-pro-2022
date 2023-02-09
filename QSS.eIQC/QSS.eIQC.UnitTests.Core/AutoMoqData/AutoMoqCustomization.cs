using AutoFixture;
using AutoFixture.Kernel;

namespace QSS.eIQC.UnitTests.Core.AutoMoqData
{
    public class AutoMoqCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(
                new Omitter(
                    new EqualRequestSpecification(
                        typeof(DummyObject).GetProperty(nameof(DummyObject.CircularRef)))));

        }
    }
}
