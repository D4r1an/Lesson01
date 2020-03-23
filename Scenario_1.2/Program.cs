using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ScenarioFactorial(Convert.ToInt32(Console.ReadLine()));
        }

        public static void ScenarioFactorial(int n)
        {
            int fact = 1;
            while (n > 1)
            {
                fact = fact * n;
                n = n - 1;
            }
            Console.WriteLine(fact);
        }
    }
}
