using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRevisited
{
    class Program
    {

        static Random random = new Random();
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(random.Next(2,));
                RandomInvalidMethod();

            }
            Console.ReadLine();
        }
        static void RandomMethod(Random random)
        {
       
            int r = random.Next();
            Console.WriteLine(r);
        }
        static void RandomInvalidMethod()
        {

            int r = random.Next();
            Console.WriteLine(r);
        }
    }
}
