namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        // Create instance of the Calculator Object
        Calculator.Calculator calc = new();

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(3, calc.Subtract(5, 2));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(10, calc.Divide(100, 10));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(10, calc.Multiply(5, 2));
        }
    }
}