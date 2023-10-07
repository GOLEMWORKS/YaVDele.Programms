using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YaVDele.CalculatorGrant.Data
{
    public class JSONReader
    {
        public static string[] ReadJsonFile(string jsonFilePath)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(jsonFilePath));
            return jsonFile;
        }
    }
}
