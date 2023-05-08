using System;
using System.Text.RegularExpressions;
namespace RegexPatterns
{
    class Uc1
    {
        static string NamePattern = @"^[A-Z][A-Za-z]{3,19}$";
        public static void Name()
        {
            Console.WriteLine("enter a name");
            var name = Console.ReadLine();
            var flag = Regex.IsMatch(name, NamePattern);
            if (flag)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid ");
        }
        static void Main(string[] args)
        {
            Name();
        }
    }
}