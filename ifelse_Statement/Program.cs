using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            IfElseMethod(10);
        }

        public static void IfElseMethod(int n)
        {
            if (n < 10 && n >= 1)
            {
                Console.WriteLine("n is less than 10");
            }
            else if(n < 20 && n >= 10)
            {
                Console.WriteLine("n is less than 20");
            }
            else if (n < 30 && n >= 20)
            {
                Console.WriteLine("n is less than 30");
            }
            else
            {
                Console.WriteLine("n is equal or greater than 30");
            }
        }
    }
}
