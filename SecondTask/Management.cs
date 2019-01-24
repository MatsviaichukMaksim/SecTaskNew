using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SecondTask
{
    class Management
    {
        public void ClosedProgrammByEnter()
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
        }
    }
}
