using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Utilities.Helper
{
    public static class DeepCopyExtension
    {
        public static T DeepCopy<T>(this T self)
        {
            var serialized = JsonConvert.SerializeObject(self);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
