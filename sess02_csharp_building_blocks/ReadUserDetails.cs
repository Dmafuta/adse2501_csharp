using System.Runtime.Intrinsics.Arm;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate how to read in values from the user and convert them to their
    /// respective value types
    /// </summary>
    public class ReadUserDetails
    {
        static void Main(string[]args)
        {
            // Variable to be used in the program
            string? username;
            int age;
            double salary;

            // Prompt the user for their name
            Console.WriteLine("Please enter your name -> ");
            username = Console.ReadLine();

            // Prompt the user for their age
            Console.WriteLine("Please enter your age -> ");
            age = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for their salary
            Console.WriteLine("Please enter your salary -> ");
            salary = Convert.ToDouble(Console.ReadLine());

            // Display the users details
            Console.WriteLine("\nUser details");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Name: {username}\nAge: {age}\nSalary: {salary:n}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
