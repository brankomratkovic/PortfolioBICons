using CsvHelper.Configuration;
using PortfolioBICons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBICons.DataFactory
{
    public class CompanyMap: ClassMap<Company>
    {
        public CompanyMap()
        {
            Map(p => p.Date).Index(0);
            Map(p => p.Open).Index(1);
            Map(p => p.High).Index(2);
            Map(p => p.Low).Index(3);
            Map(p => p.Close).Index(4);            
        }
    }
}
