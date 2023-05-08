using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatterns
{
    class UC2
    {
        static string NamePattern = @"^[A-Z][A-Za-z]{3,19}$";
        public static void LastName()
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
            LastName();
        }
    }
}
