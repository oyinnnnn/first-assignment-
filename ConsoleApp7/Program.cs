using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
        class Program
        {
            static double standardDeviation(IEnumerable<double> sequence)
            {
                double result = 0;

                if (sequence.Any())
                {
                    double average = sequence.Average();
                    double sum = sequence.Sum(d => Math.Pow(d - average, 2));
                    result = Math.Sqrt((sum) / sequence.Count());
                }
                return result;
            }
            static void Main(string[] args)
            {
                List<double> intList = new List<double> { 23, 17, 21, 31, 27,18 };
                double standard_deviation = standardDeviation(intList);
                Console.WriteLine("Standard Deviation = {0}", standard_deviation);
            Console.ReadLine();
        }

       
        }
    
}

