using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSwitch(10, 20, '+');
            TestSwitchFallTrough(DateTime.Today);
        }

        public static void TestSwitch(int op1, int op2, char opr)
        {
            switch (opr)
            {
                case '+':
                    Console.WriteLine(op1 + op2);
                    break;
                case '-':
                    Console.WriteLine(op1 - op2);
                    break;
                case '*':
                    Console.WriteLine(op1 * op2);
                    break;
                case '/':
                    Console.WriteLine(op1 / op2);
                    break;
                default:
                    Console.WriteLine("Unknown operator");
                    break;
            }
        }

        public static void TestSwitchFallTrough(DateTime dt)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is a week day");
                    break;
                default:
                    Console.WriteLine("Today is a weekend day");
                    break;
            }
        }
    }
}
