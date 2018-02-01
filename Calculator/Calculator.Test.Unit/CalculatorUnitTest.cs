using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
	[TestFixture()]
	[Author("Gruppe 35")]
	public class CalculatorUnitTests
	{
		private Calculator _uut;

		[SetUp]
		public void Setup()
		{
			_uut = new Calculator();
		}

		[TestCase(2, 4, 6)]
		[TestCase(-4, 8, 4)]
		[TestCase(3, -7, -4)]
		public void Add_AddNumber1AndNumber2_ReturnsCorrectResult(double a, double b, double c)
		{

			Assert.That(_uut.Add(a, b), Is.EqualTo(c));
		}

		[TestCase(2, 4, -2)]
		[TestCase(0, 4, -4)]
		[TestCase(4, 2, 2)]
		[TestCase(-3, -3, 0)]
		public void Subtract_SubtractNumber1AndNumber2_ReturnCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(3, 4, 12)]
        [TestCase(0, 5, 0)]
        [TestCase(2, -5, -10)]
        [TestCase(1, 1, 1)]
        public void Multiply_MultiplyNumber1AndNumber2_ReturnCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(3, 3, 27)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 2, 0)]
        [TestCase(-2, 3, -8)]
        [TestCase(5, -1, 0.2)]
        public void Power_Number1TakenToThePowerOfNumber2_ReturnCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(c));
        }
    }
}
