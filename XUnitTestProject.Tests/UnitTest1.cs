using FizzBuzzCmdLine;
using System;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace XUnitTestProject.Tests
{
    public class UnitTest1
    {
        static readonly IDictionary<string, int> counter = new Dictionary<string, int>();

        [Fact]
        public void TestInputAndReturnValues()
        {
            //Arrange
            IDictionary<string, int> counter = new Dictionary<string, int>();

            counter.Add(new KeyValuePair<string, int>("fizz", 0));
            counter.Add(new KeyValuePair<string, int>("buzz", 0));
            counter.Add(new KeyValuePair<string, int>("fizzbuzz", 0));
            counter.Add(new KeyValuePair<string, int>("lucky", 0));
            counter.Add(new KeyValuePair<string, int>("integer", 0));

            //Act
            //counter.Add("integer", 1);

            //Assert
            Assert.Equal("1", FizzBuzz.Evaluate(1));
            Assert.Equal("fizz", FizzBuzz.Evaluate(6));
            Assert.Equal("buzz", FizzBuzz.Evaluate(5));
            Assert.Equal("fizz buzz", FizzBuzz.Evaluate(15));
            Assert.Equal("lucky", FizzBuzz.Evaluate(3));
        }
    }
}
