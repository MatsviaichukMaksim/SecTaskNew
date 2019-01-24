using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parameters parameters = new Parameters();
                parameters.GetAllParameters(args);
                NewJson newJsonObj = new NewJson();
                JArray jArray = new JArray();
                jArray = newJsonObj.ShowJsonByParametersAndFilters(parameters.Numbers, parameters.Filter);
                FileManager.AddSortedJsonIntoFile(jArray, @"JsonResult.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
