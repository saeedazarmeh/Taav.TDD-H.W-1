using ShapeProject.Exceptions;

namespace ShapeProject.Models
{
    public class RectAngle:Shape
    {
        public RectAngle(decimal length, decimal width)
        {
            Guard(length,width);
            Length = length;
            Width = width;
        }

        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public override decimal Area()
        {
            return Length*Width;
        }

        public void Guard(decimal length, decimal width)
        {
            if(length <= 0 || width <= 0) {
                throw new InvalidShapeDataException();
            }   
        }
    }
}
