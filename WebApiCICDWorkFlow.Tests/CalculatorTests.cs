
namespace WebApiCICDWorkFlow.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var a = 5;
            var b = 10;
            var expected = 15;

            // Act
            var result = Calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result, "The sum of the two numbers is not correct.");
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            var a = 10;
            var b = 5;
            var expected = 5;

            // Act
            var result = Calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(expected, result, "The difference of the two numbers is not correct.");
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            var a = 5;
            var b = 10;
            var expected = 50;

            // Act
            var result = Calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expected, result, "The product of the two numbers is not correct.");
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            // Arrange
            var a = 10;
            var b = 5;
            var expected = 2;

            // Act
            var result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, "The quotient of the two numbers is not correct.");
        }
    }
}