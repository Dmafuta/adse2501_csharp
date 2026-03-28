using System.Diagnostics.CodeAnalysis;

namespace sess04_classes_and_methods
{
    /// <summary>
    /// Class to demonstrate the use of methods and overloading 
    /// </summary>
    public class SimpleMath
    {
        /// <summary>
        /// Adds two integers and return their sum as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the Addition</param>
        /// <param name="num2">Second number to be used in the Addition</param>
        /// <returns>The sum of the two numbers passed in as parameters</returns>
        public static long AddNums(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// Adds three integers and return their sum as a long value
        /// </summary>
        /// <param name="num1">First number to be used in the Addition</param>
        /// <param name="num2">Second number to be used in the Addition</param>
        /// <param name="num3">Third number to be used in the Addition</param>
        /// <returns>Sum of the three numbers passed in as parameters</returns>
        public static long AddNums(int num1, int num2, int num3)
        {
            return num1 + num2 +num3; 
        }

        /// <summary>
        /// Add the values in an array of integers and return their sum
        /// </summary>
        /// <param name="nums">An array of integers</param>
        /// <returns>The sum of the integer value in the Array</returns>
        public static long AddNums(params int[] nums) //=> nums?.Sum() ?? 0;
        {
            //long sum = 0;
            //foreach (int num in nums)
            //    sum += num;                        
            //return sum;
            
            return nums.Sum();

            // => nums?.Sum() ?? 0; // This is another alternative using LINQ 

        }
}
}
