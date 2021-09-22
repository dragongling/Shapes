using System;
using System.Linq;

namespace Shapes
{
    public class Triangle: IEnclosedShape
    {
        double[] SideLengths;

        public bool IsRight { get {
                Array.Sort(SideLengths);
                /// You can see the formula <see href="https://www.mathopenref.com/pythagorastheorem.html">here</see>.
                return Math.Pow(SideLengths[0], 2) + Math.Pow(SideLengths[1], 2) == Math.Pow(SideLengths[2], 2);
            } }

       
        /// <param name="a">A side length of a triangle</param>
        /// <param name="b">B side length of a triangle</param>
        /// <param name="c">C side length of a triangle</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Provided side length is not a positive double");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Provided sides do not form a triangle");
            }
            SideLengths = new double[3] { a, b, c };
        }

        public double GetArea()
        {
            /// You can see the formula <see href="https://www.mathopenref.com/heronsformula.html">here</see>.
            double p = SideLengths.Sum() / 2; // half perimeter
            return Math.Sqrt(p * (p - SideLengths[0]) * (p - SideLengths[1]) * (p - SideLengths[2]));
        }
    }
}
