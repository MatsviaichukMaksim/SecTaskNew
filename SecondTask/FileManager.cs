using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SecondTask
{
    class FileManager
    {
        public static void AddSortedJsonIntoFile(JArray sortedJson,string path)
        {
            File.WriteAllText(path, sortedJson.ToString());
        }
    }
}
