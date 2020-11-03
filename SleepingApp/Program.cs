using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SleepingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Demo sleep in our app";
            int length = s.Length / 2;

            for (int i = 0; i < s.Length; i++)
            {
                if (length<i)
                {

                    Speed(50);
                    Console.Write(s[i]);
                    
                }
                else
                {
                    Speed(200);
                    Console.Write(s[i]);
                    //length--;
                }


            }
            Console.WriteLine();

        }
        static void Speed(int s)
        {
            Thread.Sleep(s);
        }

    }
}
