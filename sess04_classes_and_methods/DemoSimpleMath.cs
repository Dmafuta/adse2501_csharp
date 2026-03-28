namespace sess04_classes_and_methods
{
    /// <summary>
    /// Program to demonstrate the static and overloaded methods in the SimpleMathclass
    /// </summary>
    public class DemoSimpleMath
    {
        static void Main(string[] args)
        {
            // Varianbles to be used in the program
            int firstNum, secondNum;
            long total;
            int[] scores = { 45, 35, 55, 65, 85, 75 };

            // Prompt the user for the numbers to be added
            Console.WriteLine("Please enter the first number to be added -> ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number to be added -> ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number to be added -> ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            // calculate and display the sum of the above variables
            total = SimpleMath.AddNums(firstNum, secondNum);
            Console.WriteLine($"The sum of {firstNum} + {secondNum} = {total}");
            Console.WriteLine($"The sum of {firstNum} + {secondNum} + {thirdNum} = {SimpleMath.AddNums(firstNum, secondNum, thirdNum)}");

            Console.WriteLine($"The sum of "); // Alternatively we can use string.Join() to list the numbers
            for (uint n = 0; n < scores.Length; n++)
            {
                if (n < (scores.Length - 1))
                    Console.WriteLine($"{scores[n]},");
                else
                    Console.WriteLine($"and {scores[n]}");
            }
            Console.WriteLine($"is {SimpleMath.AddNums(scores)}");
            Console.WriteLine($"The sum of {firstNum} + {secondNum} + {thirdNum} = {SimpleMath.AddNums(scores)}");

            // Demonstrate passing method arguments by named parameters
            Console.WriteLine("Passing value by parameter name");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"The sum of {firstNum} + {secondNum} + {thirdNum} = {SimpleMath.AddNums(thirdNum,firstNum,secondNum)}");
            Console.WriteLine(new string('-',50));
        }
    }
}
