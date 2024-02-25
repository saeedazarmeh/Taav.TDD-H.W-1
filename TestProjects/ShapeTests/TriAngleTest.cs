using FluentAssertions;
using ShapeProject.Exceptions;
using ShapeProject.Models;

namespace TestProjects.ShapeTests
{
    public class TriAngleTest
    {
        [Theory]
        [InlineData(10, 5, 25)]
        [InlineData(11, 2, 11)]
        [InlineData(3.5, 7, 12.25)]
        public void Area_Should_be_Actual_Same_To_Expected(decimal height, decimal width, decimal expected)
        {
            var rectAngle = new TriAngle(height, width);

            var actual = rectAngle.Area();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, -5)]
        [InlineData(-10, 5)]
        public void Area_Should_Throw_Invalid_Data_Exception(decimal height, decimal width)
        {
            var rectAngle = () => new TriAngle(height, width);

            rectAngle.Should().Throw<InvalidShapeDataException>();
        }
    }
}