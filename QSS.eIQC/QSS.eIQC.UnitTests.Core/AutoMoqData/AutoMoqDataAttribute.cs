using AutoFixture;
using AutoFixture.Xunit2;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.UnitTests.Core.AutoMoqData
{
    public sealed class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(() =>
        {
            var fixture = new Fixture().Customize(new CompositeCustomization(
                new AutoMoqCustomization(),
                new SupportMutableValueTypesCustomization()));

            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            
        
            return fixture;
        })
        { }
    }
}
