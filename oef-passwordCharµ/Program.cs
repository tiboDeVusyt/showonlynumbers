using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_passwordCharµ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give a password");
            Console.WriteLine("the password needs to have at least 8 length");
            string password = Console.ReadLine();
            int counter = 0;
            bool upper = false;
            bool digit = false;
            
            for (int i = 0; i < password.Length; i++)
            {
                counter++;
                char newchar = Convert.ToChar(password[i]);
                if (char.IsUpper(newchar))
                {
                    upper = true;
                }
                else if (char.IsDigit(newchar))
                {
                    digit = true;
                }
            }
            if (counter<8)
            {
                Console.WriteLine("the password needs to be longer");
            }
            else if (!upper)
            {
                Console.WriteLine("there needs to be 1 capital letter in your password");
            }
            else if (!digit)
            {
                Console.WriteLine("there needs to be 1 number in your password");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("this is a valid password");
                Console.WriteLine($"your new pasword is {password}");
            }
        }
    }
}
