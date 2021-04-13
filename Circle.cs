using System;

namespace OOShapes
{
    public class Circle : IShape, IName
    {
        public static decimal Pi = 3.14M;

        public Circle(decimal radius)
        {
            Radius = radius;
        }

        public decimal Radius { get; protected set; }

        public decimal CalculateArea()
        {
            return Pi * Radius * Radius;
        }

        public string Name { get; set; } = "Circle";
        public decimal CalculatePerimeter()
        {
            return 2 * Pi * Radius;
        }
    }
}