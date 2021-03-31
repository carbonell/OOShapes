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
    }
}