using Xunit;

namespace OOShapes
{
    public class SquareTest
    {
        [Fact]
        public void Can_Calculate_Area()
        {
            // Arrange
            var square = new Square();
            // Act
            square.Side = 2;
            // Assert
        }

        [Fact]
        public void Can_Calculate_Perimeter()
        {
            // Arrange
            var rectangle = new Square(side: 2);
            // Act
            // Assert
            Assert.Equal(8, rectangle.CalculatePerimeter());
        }
    }
}