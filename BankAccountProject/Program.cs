using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
            Console.WriteLine("Customer 1 or Customer 2?");
            string choosenOne = Console.ReadLine();

            do
            {
                if (choosenOne.ToLower() == "customer 1")
                {
                    Console.Clear();
                }
                else if (choosenOne.ToLower() == "customer 2")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("That wasn't an option please pick again.");
                    choosenOne = Console.ReadLine();
                }
            } while (true);


        }
    }
}
