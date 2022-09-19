using PortfolioBICons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioBICons.DataFactory
{
    public static class Calculations
    {
        public static float MaxClose(List<Company> companies)
        {
            return companies.Max(x => x.Close);
        }

        public static float MinClose(List<Company> companies)
        {
            return companies.Min(x => x.Close);
        }

        public static float AvgClose(List<Company> companies)
        {
            return companies.Average(x => x.Close);
        }

        public static Company PositiveSpike(List<Company> companies)
        {
            return companies.Where(x => x.High == companies.Max(y => y.High)).FirstOrDefault();
        }

        public static float Profit(List<Company> companies, Company spike, int shareCount)
        {
            var purchase = companies.FirstOrDefault();

            return (((spike.High - purchase.High) * shareCount) / (purchase.High * shareCount)) * 100;
        }
    }
}
