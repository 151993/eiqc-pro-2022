using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.UnitTests.Core.TestModels
{
    public class TestJsonModel
    {
        public string Name { get; set; }
        public int Mobile { get; set; }
        public bool Boolean { get; set; }
        public string[] Pets { get; set; }
        public Address Address { get; set; }

    }
    public class Address
    {
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
    }
}
