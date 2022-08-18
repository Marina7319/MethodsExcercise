using System;

namespace _4.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = ValidPasswordLength(password);
            bool isPasswordContainsValidSymobols = ValidPasswordText(password);
            bool isPAsswordLengthAtLeastTwo = ValidPasswordDigit(password);
            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsValidSymobols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPAsswordLengthAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPAsswordLengthAtLeastTwo && isPasswordContainsValidSymobols && isPasswordLengthValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        private static bool ValidPasswordDigit(string password)
        {
            int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }
        private static bool ValidPasswordText(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool ValidPasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
