using ShapeProject.Exceptions;

namespace ShapeProject.Models
{
    public class TriAngle : Shape
    {
        public TriAngle(decimal height, decimal width)
        {
            Guard(height, width);
            Height = height;
            Width = width;
        }

        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public override decimal Area()
        {
            return Height * Width/2;
        }

        public void Guard(decimal height, decimal width)
        {
            if (height <= 0 || width <= 0)
            {
                throw new InvalidShapeDataException();
            }
        }
    }
}
