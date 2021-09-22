using System;
using Xunit;
using Shapes;

namespace TestShapes
{
    public class TestTriangleArea
    {
        [Fact]
        public void IsTriangleAreaCorrect()
        {
            Assert.Equal(6.0, ShapesUtils.GetTriangleAreaBySides(3, 4, 5));
            Assert.Equal(3.897114317029974, ShapesUtils.GetTriangleAreaBySides(3, 3, 3));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(0, 1, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 0, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 1, 0));

            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(-1, 1, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, -1, 1));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 1, -1));

            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(1, 2, 4));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(4, 1, 2));
            Assert.Throws<ArgumentException>(() => ShapesUtils.GetTriangleAreaBySides(2, 4, 1));
        }

        [Fact]
        public void IsRight_Correct()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight);
            Assert.False(new Triangle(3, 3, 3).IsRight);
        }
    }
}
