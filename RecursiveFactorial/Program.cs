using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1; //Base case
            }
            else
            {
                return n * Factorial(n - 1); //Factorial case
            }
        }
    }
}
