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
                Management management = new Management();
                Task task = new Task(management.ClosedProgrammByEnter);
                task.Start();
                Parameters parameters = new Parameters();
                parameters.GetAllParameters(args);
                NewJson newJsonObj = new NewJson();
                JArray jArray = new JArray();
                jArray = newJsonObj.ShowJsonByParametersAndFilters(parameters.Numbers, parameters.Filter);
                FileManager fileManager = new FileManager();
                fileManager.AddOrGetSortedJsonIntoFile(jArray, @"JsonResult.json", parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
