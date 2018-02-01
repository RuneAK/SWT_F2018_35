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
		public void Subtract_SubtractNumber1AndNumber2_ReturnsCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(c));
        }

        [Test]
        public void Multiply_Multiply3And4_Returns12()
        {
            Assert.That(_uut.Multiply(3, 4), Is.EqualTo(12));
        }

        [Test]
        public void Power_Power3And3_Returns27()
        {
            Assert.That(_uut.Power(3, 3), Is.EqualTo(27));
        }

        [TestCase(3, 3, 27)]
        [TestCase(5, 0, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(5, -1, 0.2)]
        [TestCase(-2, 3, -8)]
        public void Power_Test(double a, double b, double c)
        {
            Assert.That(_uut.Power(a,b), Is.EqualTo(c));
        }
    }
}
