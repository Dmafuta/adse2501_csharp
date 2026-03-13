namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C#'s various date and time format specifiers
    /// </summary>
    public class DateTimeSpecifiers
    {
        static void Main(string[] args)
        {
            // Variable to hold the current date and time
            DateTime currentDate = DateTime.Now;

            // Standard date and time format specifiers
            Console.WriteLine("C# Standard Date and Time format specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Short date (d): {currentDate:d}");
            Console.WriteLine($"Long date (D): {currentDate:D}");
            Console.WriteLine($"Full date: (F): {currentDate:F}");
            Console.WriteLine($"General date (G): {currentDate:G}");
            Console.WriteLine($"Short time (t): {currentDate:t}");
            Console.WriteLine($"Long time (T): {currentDate:T}");
            Console.WriteLine($"RFC1123 (r): {currentDate:r}");
            Console.WriteLine($"Sortable (s): {currentDate:s}");
            Console.WriteLine($"Universal sortable (u): {currentDate:u}");
            Console.WriteLine($"Day of the month (M): {currentDate:M}");
            Console.WriteLine($"Month of the year (Y): {currentDate:Y}");
            Console.WriteLine(new string('-', 70));

            // Custom date and time format specifiers
            Console.WriteLine("C# Custom Date and Time format specifiers");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"Custom date (yyyy/MM/dd): {currentDate:yyyy/MM/dd}");
            Console.WriteLine("Custom date (yyyy/MM/dd):" + currentDate.ToString("yyyy/MM/dd"));
            Console.WriteLine($"Custom time with am/pm (hh:ss:tt): {currentDate:hh:ss:tt}" );
            Console.WriteLine($"Custom date with day of the week (ddd, MMM, dd, yyyy): {currentDate:ddd, MMM, dd, yyyy}");
            Console.WriteLine($"Custom time in 24HR format (HH:mm:ss): {currentDate:HH:mm:ss}");
            Console.WriteLine($"Custom time in 24-hour format with milliseconds (HH:mm:ss:fff): {currentDate:HH:mm:ss.fff}");
            Console.WriteLine($"Custom date (day of the week and year) (ddd,yyyy): {currentDate:ddd,yyyy}");
            Console.WriteLine($"Custom date and time : \nDATE (yyyy-MM-dd) {currentDate:yyyy-MM-dd}\nTIME: (HH:mm:ss.fff) {currentDate:HH:mm:ss.fff}");  
            Console.WriteLine($"Custom date and time in 24-hours format with time Zone (HH:mm:ss zzz): {currentDate:HH:mm:ss zzz}");
            Console.WriteLine(new string('-', 70));
        }
    }
}
