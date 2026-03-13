namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// This program demonstarates checked code to handle overflows
    /// </summary>
    public class CheckCode
    {
        static void Main(string[] args)
        {
            int maxValue = int.MaxValue;

            // Checked code block
            try
            {
                checked
                {
                    int result = maxValue + 1;
                    Console.WriteLine($"$Results of adding 1 to {maxValue} is {result}");
                }
            }catch(OverflowException ofe)
            {
                Console.WriteLine($"Overflow exception: \n{ofe.Message}");
                throw;
            }
        }
    }
}
