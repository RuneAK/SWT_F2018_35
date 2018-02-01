using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            var result = a + b;
            Accumulator = result;
            return result;

        }

        public double Subtract(double a, double b)
        {
            var result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double a, double b)
        {
            var result = Math.Pow(a, b);
            Accumulator = result;
            return result;
        }

        public double Divide(double divided, double divisor)
        {
            if (divisor == 0)
            {
                // Ville være bedre med en exception her
                var result = 0;
                Accumulator = result;
                return result;
            }
            
            else
            {
                var result = divided / divisor;
                Accumulator = result;
                return result;
            } 
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
