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
            //Intro
            Console.WriteLine("\n\n");
            Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
            Console.WriteLine("Customer 1 or Customer 2?");
            CheckingAccount account1Checking = new CheckingAccount();
            ReserveAccount account1Res = new ReserveAccount();
            SavingAccount account1Savings = new SavingAccount();
            string choosenOne = Console.ReadLine();

            do
            {
                if (choosenOne.ToLower() == "customer 1")
                {
                    
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Please enter your password.");
                    string password = Console.ReadLine();
                        if (password == "password1")
                        {
                        Console.Clear();
                        break;
                        
                        }
                        else
                        {
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("That wasn't the correct password!");
                        }
                    Console.Clear();
                    
                }


                else if (choosenOne.ToLower() == "customer 2")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Please enter your password.");
                    string password = Console.ReadLine();
                    if (password == "password2")
                    {
                        Console.Clear();
                        break;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("That wasn't the correct password!");
                    }
                    Console.Clear();
                    
                }
                else
                {
                    Console.WriteLine("That wasn't an option please pick again.");
                    choosenOne = Console.ReadLine();
                    
                }
            } while (true);


            //Chosing a customer 
            if (choosenOne.ToLower() == "customer 1")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Welcome back {0}, here is your account information.", choosenOne);
                account1Checking.DisplayCheckingAccount();
                account1Res.DisplayResAccount();
                account1Savings.DisplaySavingAccount();
                Console.WriteLine("Would you like to withdraw or deposit today?");
                string choosenTwo = Console.ReadLine();
                if (choosenTwo.ToLower() == "withdraw" )
                {
                    Console.WriteLine("\n\n");
                    account1Checking.DisplayCheckingAccount();
                    account1Res.DisplayResAccount();
                    account1Savings.DisplaySavingAccount();
                    Console.WriteLine("Which account would like to withdraw from, Checkings, Resereved, or Savings account?");
                    string choosenThree = Console.ReadLine();
                        if (choosenThree.ToLower() == "checkings")
                            {

                            }
                        else if ( choosenThree.ToLower() == "reserved")
                            {

                            }
                        else if ( choosenThree.ToLower() == "savings")
                            {

                            }
                        else
                            {
                        Console.WriteLine("That wasn't an options, please pick again from the list");
                            }
                }
            }





            else if (choosenOne.ToLower() == "customer 2")
            {
                Console.WriteLine("yous is right");
            }





















        }
    }
}
