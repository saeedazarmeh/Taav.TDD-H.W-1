using FluentAssertions;
using ShapeProject.Exceptions;
using ShapeProject.Models;

namespace TestProjects.ShapeTests
{
    public class SquarTest
    {
        [Theory]
        [InlineData(10, 100)]
        [InlineData(11, 121)]
        [InlineData(3.5, 12.25)]
        public void Area_Should_be_Actual_Same_To_Expected(decimal length, decimal expected)
        {
            var rectAngle = new Squar(length);

            var actual = rectAngle.Area();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-10)]
        public void Area_Should_Throw_Invalid_Data_Exception(decimal length)
        {
            var rectAngle = () => new Squar(length);

            rectAngle.Should().Throw<InvalidShapeDataException>();
        }
    }
}