using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void AdditionalMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(5, calculator.Additional(2, 3));
        }

        [Test]
        public void SubtractionMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(3, calculator.Subtraction(4, 1));
        }
        
        [Test]
        public void MiltiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(5, calculator.Miltiplication(1, 5));
        }

        [Test]
        public void DivisionMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(6, calculator.Division(6,1));
        }
    }
}
