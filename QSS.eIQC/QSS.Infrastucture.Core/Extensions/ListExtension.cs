using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace QSS.eIQC.Infrastucture.Core.Extensions
{
    public static class ListExtension
    {
        public static bool IsAny<T>(this List<T> list)
        {
            return list.Count > 0;
        }
    }
}
