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
        string userpattern = "@^[A-Za-z]{0,}[0-9]*$";
        string[] EmailInput = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
        string pattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
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
        public void ValidatingLastName()
        {
            Console.WriteLine("Validating the Last Name");
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the Last Name");
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
        public void ValidatingEmailId()
        {

            Regex regex = new Regex(pattern);
            for (int i = 0; i < EmailInput.Length; i++)
            {
                bool validemail = regex.IsMatch(EmailInput[i]);
                if (validemail)
                {
                    Console.WriteLine(EmailInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(EmailInput[i] + " ----->Invalid");
                }
            }

        }
        public void ValidatingPhoneNumber()
        {
            string[] PhoneNumberInput = { "91 9843801062", " 91 8939620291", "919894571810", "B789023", "98#1234" };
            string PhoneNumberPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(PhoneNumberPattern);
            for (int i = 0; i < PhoneNumberInput.Length; i++)
            {
                bool validnum = regex.IsMatch(PhoneNumberInput[i]);
                if (validnum)
                {
                    Console.WriteLine(PhoneNumberInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(PhoneNumberInput[i] + " ----->InValid");
                }

            }
        }
        public void ValidatingPassWord()
        {
            string[] passwordInput = { "Sant#", "Santosh1", "2SEN","Santo#s" };
            string passwordPattern = @"[A-Z]{1,}[a-z0-9]{3,14}[@#]{1}[a-z0-9]{1,4}";
            Regex regex = new Regex(passwordPattern);
            for (int i = 0; i < passwordInput.Length; i++)
            {
                bool result = regex.IsMatch(passwordInput[i]);
                if (result)
                {
                    Console.WriteLine(passwordInput[i] + " ----->Valid");
                }
                else
                {
                    Console.WriteLine(passwordInput[i] + " ----->InValid");
                }

            }
        }

    }
}
