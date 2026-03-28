//Create a C# class with a main method called DemoDolphiin to demonstrate creating Dolphin objects
//and display its fields and behaviours from its various classes
namespace sess05_inheritance_and_polymorphism
{
    public class DemoDolphin : Dolphin
    {
        static void Main(string[] args)
        {
            DemoDolphin aquaman = new DemoDolphin();

            // Set the properties for theDophin from various classes
            aquaman.food = "Small ocean fish and squid";
            aquaman.activity = "Escorting Aquaman, fast swimming, and underwater acrobatics";
            aquaman.habitat = "The Atlantean oceans and surrounding seas";

            // Display the Dolphins behaviour
            aquaman.DisplayDolphinBehaviour();
        }

        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}");
            Console.WriteLine($"Dolphin eats: {diet}");
        }

        public void DisplayDolphinBehaviour()
        {
            Console.WriteLine($"Dolphin Details: " +
                $"\n" + new string('-',50));
            this.Eat(food);
            this.DisplayHabitat(habitat);
            Console.WriteLine(
                $"\nNumber of flippers: {Flippers}" +
                $"\nNumber of snout: {Snout}" +
                $"\nNumber of blowhole: {Blowhole}" +
                $"\nNumber of fins: {Fins}");
            Console.WriteLine("Reproduction: ");
            MultiplyMammal("\nDolphin");
            Console.WriteLine($"Behaviour: ");
            DisplayBehavour();
            Console.WriteLine($"\n" + new string('-',50));
        }
    }
}
