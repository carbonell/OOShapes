using Xunit;

namespace OOShapes
{
    public class TrapezoidTests
    {
        [Fact]
        public void Can_Get_Area()
        {
            // Arrange, Act
            var trapezoid = new Trapezoid(greaterBase: 10, lesserBase: 5, height: 4);
            // Area = (GreaterBase + LesserBase)* Height/ 2
            // Assert
            Assert.Equal(30, trapezoid.Area);
        }

        [Fact]
        public void Can_Calculate_Perimeter()
        {
            // Arrange
            var trapezoid = new Trapezoid(greaterBase: 1, lesserBase: 2, height: 3);
            // Act
            // Assert
            Assert.Equal(9, trapezoid.CalculatePerimeter());
        }
    }
}