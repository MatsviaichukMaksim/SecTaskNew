using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Linq;

namespace SecondTask
{
    class NewJson
    {
        JArray jArr = new JArray();
        private static JArray GetArrayJson()
        {
            WebClient wc = new WebClient();
            string answer = wc.DownloadString("https://restcountries.eu/rest/v2/all");
            if (answer == null)
            {
                Console.WriteLine("Was entered wrong reference of website");
            }
            return JArray.Parse(answer);
        }
        public JArray ShowJsonByParametersAndFilters(List <string> parameters,string filter)
        {
            JArray jSortedArr = new JArray();
            JArray jArr = GetArrayJson();
            if (jArr==null)
            {
                Console.WriteLine("The data wasn't loaded");
            }
            foreach (JObject jObj in jArr)
            {
                if (jObj.Property("name").Value.ToString().ToLower().Contains(filter.ToLower()))
                {
                    jSortedArr.Add(jObj);
                }
            }

            foreach (JObject jObj in jSortedArr)
            {
                ShowJsonByParameters(parameters, jObj);
            }
            return jSortedArr;
        }

        private static void ShowJsonByParameters(List<string> parameters, JObject jObj)
        {
            foreach (JProperty property in jObj.Properties().ToList())
            {

                if (!parameters.Contains(property.Name.ToString()))
                {
                    jObj.Remove(property.Name);
                }
            }
        }
    }
}
