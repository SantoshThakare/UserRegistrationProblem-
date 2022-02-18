using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to validating User Registration using Regex");
            Console.WriteLine("Enter Option " +
                "\n 1. ValidatingFirstName" +
                "\n 2. ValidatingLastName" +
                "\n 3. ValidatingEmailId" +
                "\n 4. ValidatingPhoneNumber" +
                "\n 5. One Spacial Character ");
            RegexExample regex = new RegexExample();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    regex.ValidatingFirstName();
                    break;
                case 2:
                    regex.ValidatingLastName();
                    break;
                case 3:
                    regex.ValidatingEmailId();
                    break;
                case 4:
                    regex.ValidatingPhoneNumber();
                    break;
                case 5:
                    regex.ValidatingPassWord();
                    break;


                default:
                    break;

            }
        }
    }
}
