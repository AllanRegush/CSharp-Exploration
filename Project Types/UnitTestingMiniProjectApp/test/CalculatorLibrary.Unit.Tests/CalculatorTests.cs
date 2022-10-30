using FluentAssertions;

namespace CalculatorLibrary.Unit.Tests
{
    public sealed class CalculatorTests
    {
        private readonly Calculator _sut = new();

        [Theory]
        [InlineData(5, 6, 11)]
        [InlineData(-5, 6, 1)]
        [InlineData(-15, -6, -21)]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(
            int a, int b, int expected)
        {
            // Act
            var result = _sut.Add(a, b);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(5, 6, -1)]
        [InlineData(15, 6, 9)]
        [InlineData(-5, -5, 0)]
        [InlineData(-15, -6, -9)]
        [InlineData(5, 15, -10)]
        public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(
    int a, int b, int expected)
        {
            // Act
            var result = _sut.Subtract(a, b);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(10, -5, -50)]
        [InlineData(9, 9, 81)]
        [InlineData(5, 5, 25)]
        public void Multiply_ShouldMultiplyTwoNumbers_WhenTwoNumbersAreIntegers(
            int a, int b, int expected)
        {
            // Act
            var result = _sut.Multiply(a, b);

            // Assert
            result.Should().Be(expected);
        }
    }
}
