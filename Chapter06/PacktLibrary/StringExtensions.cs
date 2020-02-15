using System.Text.RegularExpressions;

namespace Packt.Shared
{
    public static class StringExtensions //static
    {
        /*
        extension methods cannot replace or override
        */
        public static bool IsValidEmail(this string input) // this 
        {
            // use simple regular expression to check
            // that the input string is a valid email
            return Regex.IsMatch(input,
            @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}