using AutoMapper;
using System;


namespace QSS.eIQC.Api.Helpers
{
    /// <summary>
    /// StringToDateTimeConverter
    /// </summary>
    public class StringToDateTimeConverter : ITypeConverter<string, DateTime>
    {
        /// <summary>
        /// convert string to date in automapper
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            if (DateTime.TryParse(source, out destination))
            {
                return destination;
            }

            return new DateTime();
        }
    }
}
