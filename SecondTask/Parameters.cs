using System;
using System.Collections.Generic;
using System.Text;

namespace SecondTask
{
    class Parameters
    {
        public List<string> Numbers { get; set; }
        public string Filter { get; set; }

        public void GetAllParameters(string []args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Parameters weren't entered");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("The filter wasn't entered");
            }
            else if (args.Length == 2)
            {
                Numbers = GetParameters(args[0]);
                Filter = args[1];
            }
            else
            {
                Console.WriteLine("Was entered more parameters");
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