
namespace OOShapes
{
    public class Rectangle : Cuadrilateral
    {
        protected decimal Height { get; set; }
        protected decimal Base { get; set; }
        public decimal Area
        {
            get
            {
                return Height * Base;
            }
        }

        public override string Name { get; protected set; } = "Rectangle";

        public Rectangle(decimal height, decimal _base)
        {
            Height = height;
            Base = _base;
        }

        public override void SetSides()
        {
            Sides = new decimal[] { Base, Base, Height, Height };
        }
    }
}