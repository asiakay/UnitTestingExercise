using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTestingExercise.tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(2, 1, 1, 4)]
        [InlineData(3, 1, 1, 5)]
        [InlineData(4, 1, 1, 6)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();

            //Act
            var actual = sut.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }
            [Theory]
            [InlineData(10, 0, 10)]
            [InlineData(5, 1, 4)]

        public void Subtract(int minuend, int subtrahend, int expected)

        {
            //Arrange
            var sut = new UnitTestMethods();

            //Act
            var actual = sut.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 30)]
        [InlineData(5, 5, 25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            int actual = sut.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(20, 5, 4)]
        [InlineData(100, 4, 25)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();


            //Act
            int actual = sut.Divide(num1, num2, expected);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = true;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var expected = true;
            //Act
            var actual = true;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

