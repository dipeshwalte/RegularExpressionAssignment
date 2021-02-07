using System;
using System.Text.RegularExpressions;

namespace RegularExpressionAssignment
{
    class Program
    {
        static void ValidatePatterns(string pattern, string[] inputs)
        {
            Console.WriteLine("------------------------------------------");
            Regex re = new Regex(pattern);
            foreach (string input in inputs)
            {
                if (re.IsMatch(input))
                    Console.WriteLine($"{input} is Valid");
                else
                    Console.WriteLine($"{input} is inValid");
            }
            Console.WriteLine("-----------------------------------------");
        }
        static void Main(string[] args)
        {
            string firstNamePattern = "[A-Z][a-z]{2,}";
            string[] firstNameInputs = { "dipesh","Dipesh","Di","Dinesh","Dha" };
            ValidatePatterns(firstNamePattern, firstNameInputs);

            string lastNamePattern = "[A-Z][a-z]{2,}";
            string[] lastNameInputs = { "walte", "Walte", "Wa", "Zokhowizh", "Wha" };
            ValidatePatterns(lastNamePattern, lastNameInputs);

            string emailPattern = @"^[0-9a-zA-Z]+[\-\.+]?[A-Za-z0-9]*@[0-9A-Za-z]+\.[a-zA-Z]{2,4}\.?([a-zA-Z]{2,4})?$";
            string[] emailInputs = { "abc.xyz@bl.co.in", "abc@bl.co", "abc@bl", "abc@bc.com"};
            ValidatePatterns(emailPattern, emailInputs);

        }
    }
}
