using FluentAssertions;
using ShapeProject.Exceptions;
using ShapeProject.Models;

namespace TestProjects.ShapeTests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(10, 78.5)]
        [InlineData(11, 94.985)]
        public void Area_Should_be_Actual_Same_To_Expected(decimal diameter, decimal expected)
        {
            var rectAngle = new Circle(diameter);

            var actual = rectAngle.Area();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-10)]
        public void Area_Should_Throw_Invalid_Data_Exception(decimal diameter)
        {
            var rectAngle = () => new Circle(diameter);

            rectAngle.Should().Throw<InvalidShapeDataException>();
        }
    }
}