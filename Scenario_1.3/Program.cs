using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(18, 0.2));
        }

        public static double Divide(double x, double y)
        {
            var result = 0.0;

            try
            {
                result = x / y;
            }
            catch (DivideByZeroException dze)
            {
                Console.WriteLine(dze.Message);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
