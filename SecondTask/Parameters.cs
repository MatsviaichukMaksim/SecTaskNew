using System;
using System.Collections.Generic;
using System.Text;

namespace SecondTask
{
    class Parameters
    {
        public List<string> Numbers { get; set; }
        public string Filter { get; set; }
        public string ParameterForFile { get; set; }

        public void GetAllParameters(string []args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("All Parameters weren't entered");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("All Parameters weren't entered");
            }
            else if (args.Length == 2)
            {
                Console.WriteLine("All Parameters weren't entered");
            }
            else if (args.Length == 3)
            {
                ParameterForFile = args[0];
                Numbers = GetParameters(args[1]);
                Filter = args[2];
            }
            else
            {
                Console.WriteLine("Was entered more parameters than need");
            }
        }
        public List<string> GetParameters(string describes)
        {
            List<string> firstparameters = new List<string>();
            string[] desscribesofcountries = describes.Split(',');
            for (int i = 0; i < desscribesofcountries.Length; i++)
            {
                firstparameters.Add(desscribesofcountries[i]);
            }
            return firstparameters;
        }
    }
}