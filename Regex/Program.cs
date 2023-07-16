using System;
using System.Text.RegularExpressions;

namespace RgexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Number check");
                Console.WriteLine("2. Email check");
                Console.WriteLine("3. Date check");
                Console.WriteLine("4. Exit");
                Console.WriteLine("-------------------------");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter a phone number:");
                        Console.WriteLine("-------------------------");
                        string phoneNumber = Console.ReadLine();
                        bool isValidPhoneNumber = ValidatePhoneNumber(phoneNumber);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(isValidPhoneNumber ? "true" : "The number should be +994 XX XXX XX XX");
                        break;

                    case "2":
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Enter an email address:");
                        string email = Console.ReadLine();
                        bool isValidEmail = ValidateEmail(email);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(isValidEmail ? "true" : "Email should end with @gmail.com");
                        break;

                    case "3":
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Enter a date:");
                        string date = Console.ReadLine();
                        bool isValidDate = ValidateDate(date);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(isValidDate ? "true" : "The date should be XX.XX.XXXX");
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Azerbaijan Phone number regular expression pattern
            string pattern = @"\+994\-\d{2}\-\d{3}\-\d{2}\-\d{2}";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }

        static bool ValidateEmail(string email)
        {
            // Gmail regex pattern
            string pattern = @"[a-zA-Z0-9](_|.)+\@(gmail.com)";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        static bool ValidateDate(string date)
        {
            // Date regex pattern
            string pattern = @"[0-32]{1,2}[ .-][0-13]{1,2}[ .-]\d{4}";
            return System.Text.RegularExpressions.Regex.IsMatch(date, pattern);
        }






    }
}
