using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(6, 5, 4, 15)]
        [InlineData(8, 8, 8, 24)]
        [InlineData(4, 10, 20, 34)]
        [InlineData(30, 0, 2, 32)]
        [InlineData(-7, 6, 2, 1)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();


            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(4, -6, 10)]
        [InlineData(-6, 4, -10)]
        [InlineData(40, 4, 36)]
        [InlineData(4, -4, 8)]
        [InlineData(-4, -5, 1)]


        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 6, 30)]
        [InlineData(12, 12, 144)]
        [InlineData(4, -4, -16)]
        [InlineData(-3, -4, 12)]
        [InlineData(0, 4, 0)]
        [InlineData(0, -3, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 2)]
        [InlineData(8, 2, 4)]
        [InlineData(200, 4, 50)]
        [InlineData(75, 3, 25)]
        [InlineData(2, 1, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
