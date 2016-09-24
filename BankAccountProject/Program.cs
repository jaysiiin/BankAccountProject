using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //to access the txt file 

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account 1
            CheckingAccount account1Checking = new CheckingAccount();
            ReserveAccount account1Res = new ReserveAccount();
            SavingAccount account1Savings = new SavingAccount();
            Account WithdrawGreeting = new Account();

            //Account 2
            CheckingAccount account2Checking = new CheckingAccount();
            ReserveAccount account2Res = new ReserveAccount();
            SavingAccount account2Savings = new SavingAccount();
            

            //Intro
            Console.WriteLine("\n\n");
            Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
            Console.WriteLine("Samuel G. Sawyer or Helen J. Hunter?");
            string choosenOne = Console.ReadLine();

            //Chosing a customer 
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


            //Accessing the account
            if (choosenOne.ToLower() == "customer 1")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Welcome back {0}, here is your account information.", choosenOne);
                account1Checking.DisplayCheckingAccount();
                account1Res.DisplayResAccount();
                account1Savings.DisplaySavingAccount();
                Console.WriteLine("Would you like to withdraw or deposit today?");
                string choosenWithDepo = Console.ReadLine();


                if (choosenWithDepo.ToLower() == "withdraw")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    account1Checking.DisplayCheckingAccount();
                    account1Res.DisplayResAccount();
                    account1Savings.DisplaySavingAccount();
                    Console.WriteLine();
                    WithdrawGreeting.WithdrawDisplay();
                    string choosenAccount = Console.ReadLine();
                    do
                    {
                        if (choosenAccount.ToLower() == "checkings")
                        {

                        }
                        else if (choosenAccount.ToLower() == "reserved")
                        {

                        }
                        else if (choosenAccount.ToLower() == "savings")
                        {

                        }
                        else if (choosenAccount.ToLower() == "quit")
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Thank you for stopping by!");
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            account1Checking.DisplayCheckingAccount();
                            account1Res.DisplayResAccount();
                            account1Savings.DisplaySavingAccount();
                            Console.WriteLine();
                            WithdrawGreeting.WithdrawDisplay();
                            Console.WriteLine("That wasn't an options, please pick again from the list");
                        }
                    } while (true);
                }
                else if (choosenWithDepo.ToLower() == "deposit")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    account1Checking.DisplayCheckingAccount();
                    account1Res.DisplayResAccount();
                    account1Savings.DisplaySavingAccount();
                    Console.WriteLine();
                    Console.WriteLine("Which account would like to deposit to?\nCheckings, Resereved, or Savings account? Enter \"quit\" to exit.");
                    string choosenAccount = Console.ReadLine();
                    do
                    {
                        if (choosenAccount.ToLower() == "checkings")
                        {

                        }
                        else if (choosenAccount.ToLower() == "reserved")
                        {

                        }
                        else if (choosenAccount.ToLower() == "savings")
                        {

                        }
                        else if (choosenAccount.ToLower() == "quit")
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Thank you for stopping by!");
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            account1Checking.DisplayCheckingAccount();
                            account1Res.DisplayResAccount();
                            account1Savings.DisplaySavingAccount();
                            Console.WriteLine();
                            Console.WriteLine("Which account would like to deposit to?\nCheckings, Resereved, or Savings account? Enter \"quit\" to exit.");
                            Console.WriteLine("That wasn't an options, please pick again from the list");
                            choosenAccount = Console.ReadLine();
                        }
                    } while (true);
                }





                else if (choosenOne.ToLower() == "customer 2")
                {
                    Console.WriteLine("yous is right");
                }




















            }
        }
    }
}
