using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drinks = { "Thea", "Coffee","Water", "Coca-Cola", "Fanta", "Whisky" };
            Console.WriteLine(string.Join("  ", drinks));
        }
    }
}
