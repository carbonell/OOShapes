using System;
using System.Collections.Generic;
using Xunit;

namespace OOShapes
{
    public class ShapesTests
    {
        [Fact]
        public void Can_Play_With_Shapes()
        {
            var square = new Square(side: 5);
            var rectangle = new Rectangle(height: 3, _base: 4);
            var trapezoid = new Trapezoid(greaterBase: 2, lesserBase: 5, height: 3);
            List<Cuadrilateral> shapeLists = new List<Cuadrilateral>();
            shapeLists.Add(square);
            shapeLists.Add(rectangle);
            shapeLists.Add(trapezoid);
            foreach (var shape in shapeLists)
            {
                Console.WriteLine("Shape: " + shape.Name);
                Console.WriteLine("Perimeter: " + shape.CalculatePerimeter());
            }

        }
    }
}