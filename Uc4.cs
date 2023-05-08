using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatterns
{
    public class Uc4
    {
        static string NumberPattern = @"^[0-9]{2}(\s)[0-9]{10}$";
        public static void PhoneNumber()
        {
            Console.WriteLine("enter a mobile number");
            var mobileno = Console.ReadLine();
            var flag = Regex.IsMatch(mobileno, NumberPattern);
            if (flag)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid ");
        }
        public static void Main(string[] args)
        {
            PhoneNumber();
        }
    }
}
