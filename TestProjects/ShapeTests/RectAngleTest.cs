using FluentAssertions;
using ShapeProject.Exceptions;
using ShapeProject.Models;
using System.Drawing;

namespace TestProjects.ShapeTests
{
    public class RectAngleTest
    {
        [Theory]
        [InlineData(10,5,50)]
        [InlineData(11,2,22)]
        [InlineData(3.5,7,24.5)]
        public void Area_Should_be_Actual_Same_To_Expected(decimal length,decimal width,decimal expected)
        {
            var rectAngle = new RectAngle(length, width);

            var actual= rectAngle.Area();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, -5)]
        [InlineData(-10, 5)]
        public void Area_Should_Throw_Invalid_Data_Exception(decimal length, decimal width)
        {
            var rectAngle = () => new RectAngle(length, width);

            rectAngle.Should().Throw<InvalidShapeDataException>();
        }
    }
}