using NUnit.Framework;

namespace UnitTestsTask.Tests
{   
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectSum()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(10, 20) == 30);
        }
        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(10, 5) == 5);
        }
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Multiplication(10, 5) == 50);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(10, 5) == 2);
        }
    }
}