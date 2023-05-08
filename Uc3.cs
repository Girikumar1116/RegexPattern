using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace RegexPatterns
{
 
    class Uc3
    {
        static string pattern = @"^[a-z]{1}[a-z0-9-_\s]{3,20}@[a-z]{5}.(com|co)$";
        public static void EmailPattern()
        {
            Console.WriteLine("enter a email");
            string s = Console.ReadLine();
            var flag = Regex.IsMatch(s, pattern);
            if (flag)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        static void Main(string[] args)
        {
            EmailPattern();
        }
    }

}
