namespace Shapes
{
    /// <summary>
    /// Wrapper for various shapes methods
    /// </summary>
    public static class ShapesUtils
    {
        public static double GetTriangleAreaBySides(double a, double b, double c)
        {
            return new Triangle(a, b, c).GetArea();
        }

        public static double GetCircleArea(double radius)
        {
            return new Circle(radius).GetArea();
        }
    }
}
