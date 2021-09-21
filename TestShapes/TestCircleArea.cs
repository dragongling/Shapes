using System;
using Xunit;
using Shapes;

namespace TestShapes
{
    public class TestCircleArea
    {
        [Fact]
        public void IsCircleAreaCorrect()
        {
            Assert.Equal(Math.PI, ShapesUtils.GetCircleArea(1));
            Assert.Equal(Math.PI * 4, ShapesUtils.GetCircleArea(2));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetCircleArea(0));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetCircleArea(-1));
        }
    }
}
