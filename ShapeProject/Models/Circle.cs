using ShapeProject.Exceptions;

namespace ShapeProject.Models
{
    public class Circle : Shape
    {
        public Circle(decimal diameter)
        {
            Guard(diameter);
            Diameter = diameter;
        }

        public decimal Diameter { get; set; }
        public override decimal Area()
        {
            return Diameter* Diameter*decimal.Parse("3.14")/4;
        }

        public void Guard(decimal diameter)
        {
            if (diameter <= 0)
            {
                throw new InvalidShapeDataException();
            }
        }
    }
}
