namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// The Bat class derives from the Mammal class and will be used to create  Bat objects/instance 
    /// </summary>
    public class Bat : Mammal
    {
        // Instance constant field
        protected const byte Wings = 2;
        protected const byte Legs = 2;
        protected const byte Ears = 2;

    
        public override void Eat(string diet)
        {
            Console.WriteLine($"{this.GetType().Name} eats {diet}");
            Console.WriteLine($"The bat eats: {diet}");
        }

        public void DisplayBehavour()
        {
            Console.WriteLine($"\nThe bat flies");
        }
    }
}
