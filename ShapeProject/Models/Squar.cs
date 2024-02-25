using ShapeProject.Exceptions;

namespace ShapeProject.Models
{
    public class Squar : Shape
    {
        public Squar(decimal length)
        {
            Guard(length);
            Length = length;
        }

        public decimal Length { get; set; }
        public override decimal Area()
        {
            return Length * Length;
        }

        public void Guard(decimal length)
        {
            if (length <= 0 )
            {
                throw new InvalidShapeDataException();
            }
        }
    }
}
