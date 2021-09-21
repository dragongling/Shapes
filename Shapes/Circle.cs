using System;

namespace Shapes
{
    public class Circle: IEnclosedShape
    {
        double Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Provided radius is not a positive double");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
