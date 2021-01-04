using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            String pass;

            //Set up loop to repeat program until valid input is accepted
            bool validPass = false;
            do
            {
                //Get user inout
                Console.WriteLine("Please enter a password containing:\n-At least one lowercase letter\n-At least one uppercase letter\n-7-12 characters\n-An exclamation point");
                pass = Console.ReadLine();

                //Validate input
                if (pass.Length >= 7 && pass.Length <=12)
                {
                    if (pass.Any(char.IsLower) && pass.Any(char.IsUpper) && pass.Contains('!'))
                    {
                        //Input is valid, print message and update control variable
                        Console.WriteLine("Password valid and accepted.");
                        validPass = true;
                        Console.WriteLine("Press Enter to close the program.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Error\n");
                    }
                }
                else
                {
                    Console.WriteLine("Error\n");
                }
            } while (validPass == false);
        }
    }
}
