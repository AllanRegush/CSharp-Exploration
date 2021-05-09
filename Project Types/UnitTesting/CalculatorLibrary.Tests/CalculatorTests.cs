using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int expected = 3;
            // Act
            int actual = calculator.Add(1, 2);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
