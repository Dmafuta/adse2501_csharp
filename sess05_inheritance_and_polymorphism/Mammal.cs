namespace sess05_inheritance_and_polymorphism
{
    /// <summary>
    /// The mammal class derives/inherits from the Animal class and adds a new behaviour to it. The
    /// Mammal class will be the base class for the derived mammals.
    /// </summary>
    public abstract class Mammal : Animal
    {
        // Instance fields
        protected string habitat;

        // Instance methods
        public abstract void Eat(string diet);

        public void MultiplyMammal(string name)
        {
            Console.WriteLine($"{name}, gives birth to young ones.");
        }
    }
}
