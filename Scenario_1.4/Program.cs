using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountDigits(10111));
        }

        public static int CountDigits(int n)
        {
            var digits = n.ToString().Length;
            if (digits == 1)
            {
                return 1;
            }
            else
            {
                CountDigits(digits - 1);
                return Convert.ToInt32(digits);
            }
        }
    }
}
