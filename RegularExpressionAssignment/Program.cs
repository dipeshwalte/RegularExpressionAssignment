using System;
using System.Text.RegularExpressions;

namespace RegularExpressionAssignment
{
    class Program
    {
        static void ValidatePatterns(string pattern, string[] inputs)
        {
            Regex re = new Regex(pattern);
            foreach (string input in inputs)
            {
                if (re.IsMatch(input))
                    Console.WriteLine($"{input} is Valid");
                else
                    Console.WriteLine($"{input} is inValid");
            }
        }
        static void Main(string[] args)
        {
            string firstNamePattern = "[A-Z][a-z]{2,}";
            string[] firstNameInputs = { "dipesh","Dipesh","Di","Dinesh","Dha" };
            ValidatePatterns(firstNamePattern, firstNameInputs);


        }
    }
}
