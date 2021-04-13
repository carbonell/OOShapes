

namespace OOShapes
{
    public class Trapezoid : Cuadrilateral
    {

        public decimal GreaterBase { get; private set; }
        public decimal LesserBase { get; private set; }
        public decimal Height { get; private set; }
        public decimal Area
        {
            get => (GreaterBase + LesserBase) * Height / 2M;
        }
        public override string Name { get; protected set; }

        public Trapezoid(decimal greaterBase, decimal lesserBase, decimal height)
        {
            GreaterBase = greaterBase;
            LesserBase = lesserBase;
            Height = height;
            Name = "Trapezoid";
        }

        public override void SetSides()
        {
            Sides = new decimal[] { GreaterBase, LesserBase, Height, Height };
        }

        public override decimal CalculateArea()
        {
            return Area;
        }
    }
}