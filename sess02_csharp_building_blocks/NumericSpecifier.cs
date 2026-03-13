namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C#'s numeric format specifiers
    /// </summary>
    public class NumericSpecifier
    {
        static void Main(string[] args)
        {
            // Variables hold sample numbers to be used in the program
            int intValue = 123457;
            double doubleValue = 321457.789;
            decimal decValue = 123467.798m;

            // Currency format specifiers
            Console.WriteLine("\nCurrency format (C):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("C"));
            Console.WriteLine($"{intValue:c}");
            Console.WriteLine($"{doubleValue:c}");
            Console.WriteLine($"{decValue:c}");
            Console.WriteLine(new string('-', 70));

            // Decimal format specifiers
            Console.WriteLine("\nDecimal format (D):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("D"));
            Console.WriteLine($"{intValue:D}");
            Console.WriteLine($"{123:d7}"); // Padded with leading zeros
            Console.WriteLine(123.ToString("D7"));
            Console.WriteLine(new string('-', 70));

            // Exponential/Scientific format specifiers
            Console.WriteLine("\nExponential/Scientific format (E):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:E}");
            Console.WriteLine($"{intValue:e}");
            Console.WriteLine(new string('-',70));


            // Fixed-point format specifiers
            Console.WriteLine("\nFixed-point format (F):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:f}");
            Console.WriteLine($"{doubleValue:f2}"); // Correct to 2 d.p
            Console.WriteLine($"{doubleValue:f4}"); // Correct to 4 d.p
            Console.WriteLine(new string('-', 70));

            // General format specifiers
            Console.WriteLine("\nGeneral format (G):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:G}");
            Console.WriteLine($"{decValue:g}");
            Console.WriteLine(new string('-', 70));

            // Number format specifiers
            Console.WriteLine("\nNumber format (N):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(doubleValue.ToString("N"));
            Console.WriteLine($"{decValue:n}");
            Console.WriteLine(new string('-', 70));

            // Percentage format specifiers
            Console.WriteLine("\nPercentage format (P):");
            Console.WriteLine(new string('-', 70));
            double percentage = .85;
            Console.WriteLine(percentage.ToString("P"));
            Console.WriteLine($"{percentage:p}");
            Console.WriteLine(new string('-', 70));

            // Hexadecimal format specifiers
            Console.WriteLine("\nHexadecimal format (X):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("X"));
            // With Padding
            Console.WriteLine("Hexadecimal with padding (x7)");
            Console.WriteLine($"{intValue:X7}");
            Console.WriteLine(new string('-',70));
        }
    }
}
