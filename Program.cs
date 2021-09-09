using System.Text.RegularExpressions;
using System;

namespace A3_String_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            string emptyString = "";
            var pi = Math.PI;

            Console.WriteLine($"From Today's Date {localDate} We Will Output in Multiple Formats.");
            Console.WriteLine($"1. {localDate:MMMM dd, yyyy}");
            Console.WriteLine($"2. {localDate:yyyy.MM.dd}");
            Console.WriteLine($"3. Day {localDate:dd} of {localDate:MMMM, yyyy}");
            Console.WriteLine($"4. {localDate:Year: yyyy, Month: MM, Day: dd}");
            // The following two formats were done because the assignment indicated number of spaces, not alignment..
            Console.WriteLine($"5. {emptyString,10}{localDate:dddd}");
            Console.WriteLine($"6. {emptyString,3}{localDate:HH:mm tt}{emptyString,10}{localDate:dddd}");
            Console.WriteLine($"7. h:{localDate:hh},m:{localDate:mm},s:{localDate:ss}");
            Console.WriteLine($"8. {localDate:yyyy.MM.dd.hh.mm.ss}");
            
            Console.WriteLine($"\nVarious Formats of PI {pi}.");
            Console.WriteLine($"1. {pi:C}");
            Console.WriteLine($"2. {pi,-10:F3}");
        }
    }
}
