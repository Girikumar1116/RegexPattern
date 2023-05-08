using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatterns
{
    public class Uc6
    {
        static string PasswordPattern = @"^[A-Z][A-Za-z0-9-_.]{8,20}$";
        public static void PassWord()
        {
            Console.WriteLine("enter a password");
            var password = Console.ReadLine();
            var flag = Regex.IsMatch(password, PasswordPattern);
            if (flag)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid ");
        }
        public static void Main(string[] args)
        {
            PassWord();
        }
    }
}
