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

            string phonePattern = @"^[0-9]{2}\s[0-9]{10}$";
            string[] phoneInputs = { "91 9422421317", "54 942242131", "9422421315", "9 9422421317" };
            ValidatePatterns(phonePattern, phoneInputs);

            string passwordPattern = @"(?=.*[A-Z])(?=.*[0-9])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$)[0-9A-Za-z!@#\$%\^&\*\(\)\-\+]{8,}";
            string[] passwordInputs = { "1A!2345678", "1!!Asrwerds", "fdsaf", "fetsetv!" , "12345678A" };
            ValidatePatterns(passwordPattern, passwordInputs);


        }
    }
}
