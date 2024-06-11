using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;
using CarSpecBattle.Data.Models;

namespace CarSpecBattle.Data.Repositories
{
    class CSVReader
    {
        static void Main()
        {
            var filePath = @"C:\Users\DKVERZIM\Downloads\CarSpecBattle.csv"; // Replace with your CSV file path
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CarCard>().ToList();
            }
        }
    }
}
