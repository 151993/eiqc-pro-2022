using System;

namespace QSS.eIQC.UnitTests.Core.AutoMoqData
{
    public class DummyObject
    {
        public Guid Id { get; set; }
        public DummyObject CircularRef { get; set; }
    }
}
