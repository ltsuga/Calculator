using System;
using Shouldly;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnTheSumOfTheProvidedNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(1, 2);

            // Assert
            result.ShouldBe(3);
        }

        [Theory]
        [InlineData(0, 1, -1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        public void Subtract_ShouldReturnTheSubtractionOftheProvidedNumbers(int num1, int num2, int expectedAnswer)
        {
            var calculator = new Calculator();

            var result = calculator.Subtract(num1,num2);

            result.ShouldBe(expectedAnswer);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, 0, 0)]
        [InlineData(-1, 2, -2)]
        public void Multiple_ShouldReturnTheMultiplicationOfTheProvidedNumbers(int num1, int num2, int expectedAnswer)
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(num1, num2);
            result.ShouldBe(expectedAnswer);
        }

        [Fact]
        public void Divide_ShouldThrowExceptionWhenDividingByZero()
        {
            var calculator = new Calculator();

            var exception = Should.Throw<Exception>(() => calculator.Divide(2, 0));
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(2, -1, -2)]
        [InlineData(-2, 1, -2)]
        public void Divide_ShouldReturnTheDivisionOfTheProvidedNumbers(int num1, int num2, int expectedAnswer)
        {
            var calculator = new Calculator();
            var result = calculator.Divide(num1, num2);
            result.ShouldBe(expectedAnswer);
        }
    }
}
