using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace OOShapes
{
    public class ShapesTests
    {

        private readonly ITestOutputHelper _output;

        public ShapesTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Can_Play_With_Cuadrilaterals()
        {
            var square = new Square(side: 5);
            var rectangle = new Rectangle(height: 3, _base: 4);
            var trapezoid = new Trapezoid(greaterBase: 2, lesserBase: 5, height: 3);
            List<Cuadrilateral> shapeLists = new List<Cuadrilateral>();
            shapeLists.Add(square);
            shapeLists.Add(rectangle);
            shapeLists.Add(trapezoid);
            WriteLine("\n\n--Output: --\n\n");
            foreach (var shape in shapeLists)
            {
                WriteLine("Shape: " + shape.Name);
                WriteLine("Perimeter: " + shape.CalculatePerimeter());
                WriteLine("\n");
            }


            IShape sh1 = new Circle(radius: 2);
            WriteLine("Shape: " + sh1.Name);
            IName n1 = new Circle(radius: 2);
            WriteLine("Name: " + n1.Name);

        }

        [Fact]
        public void Can_Play_With_Shapes()
        {
            var square = new Square(side: 5);
            var rectangle = new Rectangle(height: 3, _base: 4);
            var trapezoid = new Trapezoid(greaterBase: 2, lesserBase: 5, height: 3);
            var circle = new Circle(radius: 3);

            List<IShape> shapes = new List<IShape>();
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(trapezoid);
            shapes.Add(circle);
            WriteLine("\n\n--Output: --\n\n");

            foreach (var shape in shapes)
            {
                WriteLine("Shape: " + shape.Name);
                WriteLine("Perimeter: " + shape.CalculatePerimeter());
                WriteLine("Area: " + shape.CalculateArea());
                // WriteLine("\n");
            }
        }

        private void WriteLine(string message)
        {
            Console.WriteLine(message);
            _output.WriteLine(message);
        }
    }
}