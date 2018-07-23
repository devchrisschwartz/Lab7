using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program that validates zip codes
            Console.WriteLine("Please enter a valid zip code");
            string input = Console.ReadLine();

            //if (Regex.IsMatch(input, @"^\d{5}$"))
            //{
            //    Console.WriteLine("You entered a vaid zip code!");
            //}
            //else
            //{
            //    Console.WriteLine("Nice try, next time please do it right");
            //}

            // 1. Validation for names: ^[A-Z][a-zA-Z]{0,29}$
            // 2. Validation for emails: ^[A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$
            // 3. Validation for phone numbers: ^\d{3}-\d{3}-\d{4}$
            // 4. Validation for dates: ^[0-3]\d\/[0-1]\d\/\d\d\d\d$

            while (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                Console.WriteLine("Nice try, next time please do it right");
                input = Console.ReadLine();
            }

            Console.WriteLine("You entered a valid zip code!");

        }
    }
}
