using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                s += i;
            }
            sw1.Stop();


            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            //Console.WriteLine($"Time in milliseconds needed for string :{sw1.ElapsedMilliseconds}");
            Console.WriteLine($"Time in milliseconds needed for stringBuilder :{sw2.ElapsedMilliseconds}");

            Console.WriteLine(sb.ToString());
        }
    }
}
