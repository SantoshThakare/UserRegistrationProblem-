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
            Console.WriteLine("Welcome to validating User Registration using Regular Expression");
            Console.WriteLine("Enter Option 1");
            RegexExample regex = new RegexExample();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    regex.ValidatingFirstName();
                    break;

                default:
                    break;

            }
        }
    }
}
