
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace QSS.eIQC.Utilities.Helper
{
    public static class JsonDeserializer
    {
        private const string FileExtension = ".json";
        public static List<TEntity> DeserializerObject<TEntity>(string fileName, string folderName = "SeedData")
        {
            var result = new List<TEntity>();
            var assembly = Assembly.GetCallingAssembly();
            var files = assembly.GetManifestResourceNames();
            var filePrefix = $"{assembly.GetName().Name}.{folderName}.";
            var file = files.Where(f => f.Equals(filePrefix + fileName + FileExtension))
                                      .Select(f => new
                                      {
                                          PhysicalFile = f,
                                          LogicalFile = f.Replace(filePrefix, String.Empty)
                                      }).FirstOrDefault();

            if (file != null)
            {
                using (Stream stream = assembly.GetManifestResourceStream(file.PhysicalFile))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string seeddatajson = reader.ReadToEnd();
                        result = JsonConvert.DeserializeObject<List<TEntity>>(seeddatajson);
                    }
                }
            }
            return result;
        }
    }
}


