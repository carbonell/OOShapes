
namespace OOShapes
{
    public class Rectangle
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

        public Rectangle(decimal height, decimal _base)
        {
            Height = height;
            Base = _base;
        }



    }
}