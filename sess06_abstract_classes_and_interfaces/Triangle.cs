using sess05_inheritance_and_polymorphism;

namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// This class derives from the abstract Shape in sess05 and will be the base class for
    /// all triangles.
    /// </summary>
    public abstract class Triangle : Shape
    {
        /// <summary>
        /// Calculate the area of the triangle
        /// </summary>
        /// <returns>The area of the triangle as a float</returns>
        public abstract override float CalculateArea();         
    }
}
