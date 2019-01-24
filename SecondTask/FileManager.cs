using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SecondTask
{
    class FileManager
    {
        JArray readJson = new JArray();
        int filter;
        List<string> parameters;
        public void AddOrGetSortedJsonIntoFile(JArray sortedJson,string path, Parameters parameter)
        {
            parameters = parameter.Numbers;
            if (parameter.ParameterForFile == ("save"))
            {
                File.WriteAllText(path, sortedJson.ToString());
            }
            else if (parameter.ParameterForFile == "read")
            {
                if (File.Exists(path))
                {
                    
                    readJson = JArray.Parse(File.ReadAllText(path));
                    if (int.TryParse(parameter.Filter, out int filter))
                    {
                        this.filter = filter;
                        ReadSortedJson();
                    }
                    else
                    {
                    Console.WriteLine("Was entered the wrong parameter");
                    }
                }
                else
                {
                    Console.WriteLine("The file haven't found");
                }
            }
            else
            {
                Console.WriteLine("Was entered the wrong parameter");
            }
        }
        public void ReadSortedJson()
        {
            foreach (JObject jObj in readJson)
            {
                string valueJson = null;
                foreach (string parameter in parameters)
                {
                    valueJson += parameter;
                    valueJson += " = ";
                    if (jObj[parameter] != null)
                    {
                        valueJson += jObj[parameter];
                        valueJson += " ";
                    }
                }
                Thread.Sleep(1000*filter);
                Console.WriteLine(valueJson);
            }
        }
    }
}
