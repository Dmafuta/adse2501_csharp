namespace sess04_classes_and_methods
{
    /// <summary>
    /// This class is used to create Right-angled triangle object
    /// </summary>
    public class RightAngledTriangle
    {
        // Private instance variables 
        private byte height;
        private byte @base;
        private byte hypotenuse;

        /// <summary>
        /// Creates a Right -Angled triangle and initialises all its sides to 0
        /// </summary>
        private RightAngledTriangle()
        {
            this.height = 0;
            this.@base = 0; 
            this.hypotenuse = 0;
        }
        /// <summary>
        /// Creates/Instantiate a Right -Angled triangle with the height  and base passed in as parameters.
        /// The Hypotenuse is calculated using Pythogoras theorem.
        /// </summary>
        /// <param name="height">The triangle's height</param>
        /// <param name="base">The triangle's base</param>
        public RightAngledTriangle(byte height, byte @base)
        {
            this.height = height;
            this.@base = @base;
            //this.hypotenuse = (byte)(Math.Sqrt(height * height + @base * @base)); // Alternatively
            this.hypotenuse = (byte)(Math.Sqrt(Math.Pow(hypotenuse, 2) + Math.Pow(@base, 2)));
        }

        private int CalculateArea()
        {
            return (int)(0.5 * this.height * this.@base); // Not the same as 1/2 * this.base * this.@base
        }

        private int CalculatePerimeter()
        {
            return this.@base + this.height + this.hypotenuse;
        }

        public override string ToString()
        {
            return $"Right-Angled Triangle's Dimensions: " +
                $"\n{ new string('-',50)}" +
                $"\nBase: {this.@base}" +
                $"\nHeight: {this.height}" +
                $"\nHypotenuse: {this.hypotenuse}" +
                $"\nArea: {this.CalculateArea()}" +
                $"\nPerimeter: {this.CalculatePerimeter()}" +
                $"\n{new string('-',50)}";
        }
    }
}
