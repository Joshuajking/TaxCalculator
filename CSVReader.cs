using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    static class CSVReader
    {
        // Ctor that loads taxtable.csv automatically
        private static void CSVReader()
        {
            var taxtable = File.ReadAllLines(@"C:\Users\joshu\source\repos\FinalProject\Resources\taxtable.csv");
            foreach (var line in taxtable)
            {
                var values = line.Split(',');

            }

        }
    }
}
