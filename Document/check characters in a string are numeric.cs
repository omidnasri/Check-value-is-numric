// Using
using System.Text.RegularExpressions; 
 
// This function returns true if the all the characters in a string are numeric.
static bool CheckValueIsNumber(string inputString)
{
   // .NET : Check if String Contains Only Numbers
   return Regex.IsMatch(inputString, @"^\d+$");
}