using Xunit;

namespace Calculator.Tests
{

    public class CalculatorTests
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int expected = 3;
        }
    }
}
