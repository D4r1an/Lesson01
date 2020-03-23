using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachTest();
            ForeachTestFunctional();
        }

        public static void ForeachTest()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in numbers)
            {
                Console.WriteLine("The value of i is {0}", item);
            }
        }

        public static void ForeachTestFunctional()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            numbers.ForEach(item => Console.WriteLine(item));
        }
    }
}
