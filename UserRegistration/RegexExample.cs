﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class RegexExample
    {
        string pattern = "^[A-Z][a-z]*[0-9][a-z]*$";
        public void ValidatingFirstName()
        {
            Console.WriteLine("Validating the First Name");
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the First Name");
            string input = Console.ReadLine();
            bool result = regex.IsMatch(input);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
