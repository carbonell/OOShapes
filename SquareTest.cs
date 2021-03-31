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
    }
}