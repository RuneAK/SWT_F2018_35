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

        public double Add(double addend)
        {
            var result = addend + Accumulator;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            var result = a - b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double subtractor)
        {
            var result = Accumulator - subtractor;
            Accumulator = result;
            return result;
        }
        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double multiplier)
        {
            var result = Accumulator * multiplier;
            Accumulator = result;
            return result;
        }

        public double Power(double a, double b)
        {
            var result = Math.Pow(a, b);
            Accumulator = result;
            return result;
        }

        public double Power(double exponent)
        {
            var result = Math.Pow(Accumulator, exponent);
            Accumulator = result;
            return result;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Clear();
                throw new System.DivideByZeroException();
            }

            var result = dividend / divisor;
            Accumulator = result;
            return result;            
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                Clear();
                throw new System.DivideByZeroException();
            }

            var result = Accumulator / divisor;
            Accumulator = result;
            return result;            
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
