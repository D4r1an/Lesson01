using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
            DoWhileLoop();
        }

        public static void WhileTest()
        {
            int num = 0;

            while (num <= 5)
            {
                Console.WriteLine("The value of num is {0}", num);
                num++;
            }
        }

        public static void DoWhileLoop()
        {
            int i = 5;
            do
            {
                Console.WriteLine($"The value of i is {i}");
                i++;
            } while (i <= 5 );
        }
    }
}
