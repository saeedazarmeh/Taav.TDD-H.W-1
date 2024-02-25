using BizzBuzzProject;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjects.BizzBuzzTests
{

    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(21, "Fizz")]
        [InlineData(-12, "Fizz")]
        public void Result_Actual_Shoul_Be_Fizz(int num,string expected)
        {
            var actual = num.Result();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(25, "Buzz")]
        [InlineData(-5, "Buzz")]
        public void Result_Actual_Shoul_Be_Buzz(int num, string expected)
        {
            var actual = num.Result();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(30, "FizzBuzz")]
        [InlineData(-15, "FizzBuzz")]
        public void Result_Actual_Shoul_Be_FizzBuzz(int num, string expected)
        {
            var actual = num.Result();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(22, "Not Fizz Or Buzz")]
        [InlineData(-11, "Not Fizz Or Buzz")]
        public void Result_Actual_Shoul_Be_Not_Fizz_Or_Buzz(int num, string expected)
        {
            var actual = num.Result();

            actual.Should().Be(expected);
        }
    }
}
