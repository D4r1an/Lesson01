using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
        }

        public static void ForTest()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }
        }
    }
}
