using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 20, 67, 90)]
        [InlineData(-10, 5, -17, -22)]
        [InlineData(0, 0, 0, 0)]
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
        [InlineData(10, 7, 3)]
        [InlineData(-30, 2, -32)]
        [InlineData(0, 8, -8)]
        [InlineData(200, 167, 33)]
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
        [InlineData(4, 4, 16)]
        [InlineData(130, 1, 130)]
        [InlineData(0, 0, 0)]
        [InlineData(46, 30, 1380)]
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
        [InlineData(6, 6, 1)]
        [InlineData(20, 5, 4)]
        [InlineData(-16, 4, -4)]
        [InlineData(500, 10, 50)]
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
