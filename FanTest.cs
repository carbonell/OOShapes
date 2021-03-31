using Xunit;

namespace OOShapes
{
    public class FanTest
    {
        [Fact]
        public void Can_SetFan_JavaStyle()
        {
            // Arrange
            var fan = new Fan(FanType.None);
            // Act
            var type = fan.GetFanType();
            var ceilingType = FanType.Ceiling;
            fan.SetFanType(ceilingType);

            // Assert
            Assert.Equal(FanType.Ceiling, fan.GetFanType());
        }

        [Fact]
        public void Can_SetFan_CSharpStyle()
        {
            // Arrange
            var fan = new Fan(FanType.None);
            // Act
            fan.FanType = FanType.Ceiling;
            // Assert
            Assert.Equal(FanType.Ceiling, fan.FanType);
        }

        [Fact]
        public void Can_Turn_On()
        {
            // Arrange
            var fan = new Fan(FanType.Ceiling);
            // Act
            fan.TurnOn();
            // Assert
            Assert.True(fan.IsOn);
        }

        [Fact]
        public void Can_Initialize_WithFanType()
        {
            // Arrange
            var fanType = FanType.Ceiling;
            // Act
            var fan = new Fan(fanType);

            // Assert
            Assert.Equal(FanType.Ceiling, fan.FanType);
        }
    }
}