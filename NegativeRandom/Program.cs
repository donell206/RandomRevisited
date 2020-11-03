using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new double[10];
            double minValue = -12.05;
            double maxValue = -3.25;

            for (int i = 0; i < numbers.length; i++)
            {
                numbers[i] = random.NextDouble() * (maxValue - minValue) + minValue;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
