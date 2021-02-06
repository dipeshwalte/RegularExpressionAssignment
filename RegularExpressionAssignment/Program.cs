using System;
using System.Text.RegularExpressions;

namespace RegularExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNamePattern = "[A-Z][a-z]{3,}";
            string[] firstNameInputs = { "dipesh","Dipesh","Di","Dinesh" };
            Regex re = new Regex(firstNamePattern);
            foreach (string input in firstNameInputs)
            {
                if (re.IsMatch(input))
                    Console.WriteLine($"{input} is Valid");
                else
                    Console.WriteLine($"{input} is inValid");
            }
        }
    }
}
