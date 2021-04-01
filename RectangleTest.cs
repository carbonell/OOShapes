using Xunit;

namespace OOShapes
{
    public class RectangleTest
    {
        [Fact]
        public void Can_Calculate_Area()
        {
            // Arrange
            // Act
            var rectangle = new Rectangle(_base: 4, height: 2);

            // Assert
            Assert.Equal(8, rectangle.Area);
        }

        [Fact]
        public void Can_Calculate_Perimeter()
        {
            // Arrange
            var rectangle = new Rectangle(_base: 4, height: 2);
            // Act
            // Assert
            Assert.Equal(12, rectangle.CalculatePerimeter());
        }
    }
}