using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBICons.Models
{
    public class Company
    {  
        [Index(0)]
        public DateTime Date { get; set; }
        [Index(1)]
        public float Open { get; set; }
        [Index(2)]
        public float High { get; set; }
        [Index(3)]
        public float Low { get; set; }
        [Index(4)]
        public float Close { get; set; }               
    }
}
