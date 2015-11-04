using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace check_characters_is_numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckValueIsNumber("12f3"));
        }

        // This function returns true if the all the characters in a string are numeric.
        static bool CheckValueIsNumber(string inputString)
        {
            // .NET : Check if String Contains Only Numbers
            return Regex.IsMatch(inputString, @"^\d+$");
        }
    }
}
