namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// This program demonstrates unchecked code wrap overflows
    /// </summary>
    public class UnCheckedCode
    {
        static void Main(string[] args)
        {
            int maxValue = int.MaxValue;

            unchecked // Unchecked block: overflow will wrap around instead of throwing an exception
            {
                int result = maxValue + 1;
                Console.WriteLine($"Unchecked result: {result}"); // Wraps around to "int.MinValue"
            }
        }
    }
}
