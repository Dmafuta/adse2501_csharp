namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// Program to demonstrate inheritance and object instantiation
    /// </summary>
    public class DemoBat : Bat
    {
        static void Main(string[] args)
        {
            DemoBat batman = new DemoBat();

            // Set the properties for the Bat from various base classes
            batman.food = "insects or fruits"; // From the Animal base class
            batman.activity = "Bats are nocturnal"; // From the Animal base class

            //batman._activity = "batman rounds up criminals like joker & Harley Quinn in Gotham city";
            batman.habitat = "Batcave in Gotham city"; // From mammal class

            // Display the details of the DemoBat instance
            batman.DisplayBatDetails();
        }

        private void DisplayBatDetails()
        {
            Console.WriteLine($"Details of the bat" +
                $"\n" + new string('-', 50));
            this.Eat(food);
            Console.WriteLine(
                $"\nNumber of wings: {Wings}" +
                $"\nNumber of legs: {Legs}" +
                $"\nNumber of ears: {Ears}");
            Console.WriteLine("Reproduction: ");
            MultiplyMammal("\nBat");
            Console.WriteLine("Behaviour: ");
            DisplayBehavour();
            Console.WriteLine($"\n" + new string('-', 50));
        }
    }
}