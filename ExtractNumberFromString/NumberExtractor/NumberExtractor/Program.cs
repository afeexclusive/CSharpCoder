using System;
using System.Linq;

namespace NumberExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringContainingNumber = Guid.NewGuid().ToString();
            string extractedNumber = ExtractNumberFromString(stringContainingNumber);

            Console.WriteLine($"Original String = {stringContainingNumber}");
            Console.WriteLine($"Extracted Number = {extractedNumber}");
        }

        private static string ExtractNumberFromString(string str)
        {
            return new string(str.Where(char.IsDigit).ToArray());
        }

    }
}
