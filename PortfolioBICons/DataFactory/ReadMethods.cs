using CsvHelper;
using CsvHelper.Configuration;
using PortfolioBICons.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBICons.DataFactory
{
    public static class ReadMethods
    {
        public static List<Company> ReadCompany(string path)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                Comment = '#',
                HasHeaderRecord = false
            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<CompanyMap>();
                return csv.GetRecords<Company>().ToList();
            }
        }
    }
}
