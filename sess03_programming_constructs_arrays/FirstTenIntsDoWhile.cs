using System.Runtime.Intrinsics.Arm;

namespace sess03_programming_constructs_arrays
{
    /// <summary>
    /// Program to display the first 10 integers 
    /// </summary>
    public class FirstTenIntsDoWhile
    {
        static void Main(string[] args)
        {
            uint n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            }while (n <= 10) ;
        }
    }
}
