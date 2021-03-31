
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
    }
}