using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioBICons.DataFactory;


namespace PortfolioBICons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scvFileGLW = Path.Combine(Environment.CurrentDirectory, @"Data\GLW.csv");
            string scvFileNVD = Path.Combine(Environment.CurrentDirectory, @"Data\HistoricalPrices.csv");
            var GLW = ReadMethods.ReadCompany(scvFileGLW);
            var NVD = ReadMethods.ReadCompany(scvFileNVD);

            Console.WriteLine("CALCULATIONS");
            Console.WriteLine("---------------");
            Console.WriteLine();

            Console.WriteLine("Max closing price for Corning:");
            Console.WriteLine(Calculations.MaxClose(GLW) + "$");
            Console.WriteLine();

            Console.WriteLine("Max closing price for Nvidia:");
            Console.WriteLine(Calculations.MaxClose(NVD) + "$");
            Console.WriteLine();

            Console.WriteLine("Min closing price for Corning:");
            Console.WriteLine(Calculations.MinClose(GLW) + "$");
            Console.WriteLine();

            Console.WriteLine("Min closing price for Nvidia:");
            Console.WriteLine(Calculations.MinClose(NVD) + "$");
            Console.WriteLine();

            Console.WriteLine("Avarage closing price for Corning:");
            Console.WriteLine(Calculations.AvgClose(GLW) + "$");
            Console.WriteLine();

            Console.WriteLine("Avarage closing price for Nvidia:");
            Console.WriteLine(Calculations.AvgClose(NVD) + "$");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("POSITIVE SPIKE");
            Console.WriteLine("------------------");
            Console.WriteLine();

            var positiveGLW = Calculations.PositiveSpike(GLW);
            Console.WriteLine("Max positive spike for Corning was on " + positiveGLW.Date + " with price " + positiveGLW.High + "$");
            Console.WriteLine();

            var positiveNVD = Calculations.PositiveSpike(NVD);
            Console.WriteLine("Max positive spike for Corning was on " + positiveNVD.Date + " with price " + positiveNVD.High + "$");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ROI");
            Console.WriteLine("--------------");
            Console.WriteLine();

            Console.WriteLine("ROI on 1000 shares for Corning on " + positiveGLW.Date + " was " + Calculations.Profit(GLW, positiveGLW, 1000) + "%");
            Console.WriteLine();

            Console.WriteLine("ROI on 1000 shares for Nvidia on " + positiveNVD.Date + " was " + Calculations.Profit(NVD, positiveNVD, 1000) + "%");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
