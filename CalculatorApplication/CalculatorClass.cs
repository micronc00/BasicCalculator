
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    class CalculatorClass
    {
        public Formula<string> formula;

        public double GetSum(double number1, double number2)
        {
            return number1 + number2;
        }

        public double GetDifference(double number1, double number2)
        {
            return number1 - number2;
        }

        public double GetProduct(double number1, double number2)
        {
            return number1 * number2;
        }

        public double GetQuotient(double number1, double number2)
        {
            return number1 / number2;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }

            remove
            {
                Console.WriteLine("Added the Delegate");
            }
        }
    }
}
