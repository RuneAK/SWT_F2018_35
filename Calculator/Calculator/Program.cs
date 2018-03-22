using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();
            double number1 = 15;
            double number2 = 3;
            double result;

            try
            {
                result = myCalc.Divide(number1, number2);
                Console.WriteLine($"{number1} divided by {number2} equals {result}.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted division by zero");
            }
			
            Console.ReadLine();
        }
    }
}
