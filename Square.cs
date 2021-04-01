
namespace OOShapes
{
    public class Square : Rectangle
    {
        private decimal _side;
        public decimal Side
        {
            get
            {
                return _side;
            }
            set
            {
                Height = value;
                Base = value;
                _side = value;
            }
        }
        public override string Name { get; protected set; } = "Square";

        public Square()
        : this(side: 1)
        {

        }

        public Square(decimal side)
        : this(height: side, _base: side)
        {

        }

        public Square(decimal height, decimal _base)
        : base(height, _base)
        {
            Side = height;
        }

        public override void SetSides()
        {
            Sides = new decimal[] { _side, _side, _side, _side };
        }
    }
}