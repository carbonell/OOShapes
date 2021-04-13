using Xunit;

namespace OOShapes
{
    public class CircleTests
    {
        [Fact]
        public void Can_CalculateArea()
        {
            // Arrange
            var circle = new Circle(radius: 2);
            var area = circle.CalculateArea();
            // Act
            // pi * radius * radius
            // Assert
            Assert.Equal(12.56M, area);
        }

        [Fact]
        public void Can_CalculatePerimeter()
        {
            // Arrange
            var circle = new Circle(radius: 2);
            // Act
            var perimeter = circle.CalculatePerimeter();
            // Assert
            Assert.Equal(12.56M, perimeter);
        }
    }
}