using System.Text.RegularExpressions;
using Calculator.Exceptions;

namespace Calculator.Utils
{
    public static class StringUtils
    {
        public static string ReadConsoleInputNumber()
        {
            string? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                throw new UnrecognizedInputedValue();
            }
            else if (Double.TryParse(Convert.ToString(input), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out _))
            {
                return input;
            }
            else
            {
                throw new UnrecognizedInputedValue();
            }
        }

        public static void Print(string message, string? title = null)
        {
            Console.WriteLine($"|--===== {message} =====--|");
        }
    }

}