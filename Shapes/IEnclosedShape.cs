namespace Shapes
{
    /// <summary>
    /// Interface for enclosed Euclidean shapes
    /// </summary>
    public interface IEnclosedShape {

        /// <summary>
        /// Returns an area of enclosed shape.
        /// </summary>
        /// <returns> Area in square units </returns>
        public double GetArea();
    };
}
