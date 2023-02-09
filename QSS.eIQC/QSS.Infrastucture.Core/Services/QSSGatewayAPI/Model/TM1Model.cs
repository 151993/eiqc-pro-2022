using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.Infrastructure.Core.QSSGatewayAPI.Model
{
    public class TM1Model
    {
        public string Name { get; set; }

        public bool Deleted { get; set; }

        public int Id { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
