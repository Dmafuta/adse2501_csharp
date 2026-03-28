namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// The Bat class derives from the Mammal class and will be used to create  Bat objects/instance 
    /// </summary>
    public class Dolphin : Mammal
    {
        // Instance constant field
        protected const byte Flippers = 2;
        protected const byte Snout = 1;
        protected const byte Blowhole = 1;
        protected const byte Fins = 5;


        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}");
            Console.WriteLine($"The dolphin eats: {diet}");
        }

        public void DisplayHabitat(string habitat)
        {
            Console.WriteLine($"Dolphins stays in: {habitat}");
        }

        public void DisplayBehavour()
        {
            Console.WriteLine($"\nThe dolphin swims");
        }
    }
}
