using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ApplyDiscount(250));
        }

        public static int ApplyDiscount(int n)
        {
            if (n < 10)
            {
                return 5 * n / 100;
            }
            else if (n < 50)
            {
                return 10 * n / 100;
            }
            else if (n < 100)
            {
                return 15 * n / 100;
            }
            else
            {
                return 20 * n / 100;
            }
        }
    }
}
