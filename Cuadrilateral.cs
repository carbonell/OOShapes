using System.Linq;

namespace OOShapes
{
    public abstract class Cuadrilateral : IShape
    {
        public abstract string Name { get; protected set; }
        public Cuadrilateral()
        {
        }

        public decimal[] Sides { get; protected set; }

        public decimal CalculatePerimeter()
        {
            SetSides();
            return Sides.Sum();
        }

        public abstract void SetSides();
        public abstract decimal CalculateArea();
    }
}