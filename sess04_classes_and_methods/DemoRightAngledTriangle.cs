namespace sess04_classes_and_methods
{
    /// <summary>
    /// Program to demonstrate instantiating an object and calling/invoking it's methods
    /// </summary>
    public class DemoRightAngledTriangle
    {
        static void Main(string[] args)
        {
            // Prompt the user for the dimensions of the right angled triangle
            Console.WriteLine("Please enter the base of the right-angled triangle:");
            byte @base = byte.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the right-angled triangle:");
            byte height = byte.Parse(Console.ReadLine());

            // Declare and instantiate a RightAngledTriangle object using the above dimensions
            RightAngledTriangle tri1 = new RightAngledTriangle(height, @base);

            // Invoke the Triangle's 'ToString' method to display its dimensions
            string ones = tri1.ToString();
            Console.WriteLine(ones);
        }
    }
}
