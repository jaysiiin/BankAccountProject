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
            Account Greeting = new Account();
            
            //Account 2
            CheckingAccount account2Checking = new CheckingAccount();
            ReserveAccount account2Res = new ReserveAccount();
            SavingAccount account2Savings = new SavingAccount();

            

            //Intro
            Console.WriteLine("\n\n");
            Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
            Console.WriteLine("Samuel Sawyer or Helen Hunter?");
            string choosenOne = Console.ReadLine();

            //Chosing a customer 
            StreamWriter Sam = new StreamWriter("Sam.txt");
            using (Sam)

            {
                Sam.WriteLine(choosenOne);

                do
                {
                    if (choosenOne.ToLower() == "samuel sawyer")
                    {

                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Please enter your 7 digit account number.");
                        string userAccountNum = Console.ReadLine();
                        Sam.WriteLine(userAccountNum);

                        do
                        {
                            if (userAccountNum.Length > 7 || userAccountNum.Length < 7)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n");
                                Console.WriteLine("Please reenter the your 7 digit account number.");
                                userAccountNum = Console.ReadLine();
                            }

                        } while (userAccountNum.Length > 7 || userAccountNum.Length < 7);


                        Console.WriteLine("Please enter your password.");
                        string password = Console.ReadLine();
                        if (password == "password1")
                        {
                            Console.Clear();
                            break;

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("That wasn't the correct password! Please enter the correct password.");
                            password = Console.ReadLine();
                        }


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
                            password = Console.ReadLine();
                        }


                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
                        Console.WriteLine("Samuel Sawyer or Helen Hunter?");
                        Console.WriteLine("That account does not exist in this program.");
                        choosenOne = Console.ReadLine();

                    }
                } while (true);
            }
            

                //Account 1 
                if (choosenOne.ToLower() == "samuel sawyer")
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Welcome back {0}, here is your account information.", choosenOne);
                    account1Checking.DisplayCheckingAccount();
                    account1Res.DisplayResAccount();
                    account1Savings.DisplaySavingAccount();
                    Console.WriteLine("Would you like to withdraw or deposit today?");
                    string choosenWithDepo = Console.ReadLine();
                    
                    //withdraw
                    if (choosenWithDepo.ToLower() == "withdraw")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        account1Checking.DisplayCheckingAccount();
                        account1Res.DisplayResAccount();
                        account1Savings.DisplaySavingAccount();
                        Console.WriteLine();
                        Greeting.WithdrawDisplay();
                        string choosenAccount = Console.ReadLine();

                        do
                        {
                            if (choosenAccount.ToLower() == "checkings")
                            {
                                Console.WriteLine("How much would you like to withdraw from your checking accout?");
                                Console.Write("$");
                                double userNumChecking = double.Parse(Console.ReadLine());
                               
                                account1Checking.SubUserChecking(userNumChecking);
                                if (userNumChecking == 0) 
                                {
                                        Console.Clear();
                                        Console.WriteLine("\n\n");
                                        Console.WriteLine("Thank you for stopping by!");
                                        Environment.Exit(0);
                                    
                                }
                            }

                            else if (choosenAccount.ToLower() == "reserved")
                            {
                                Console.WriteLine("How much would you like to withdraw from your reserved accout?");
                            }
                            else if (choosenAccount.ToLower() == "savings")
                            {
                                Console.WriteLine("How much would you like to withdraw from your savings accout?");
                            }
                            else if (choosenAccount.ToLower() == "quit")
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n");
                                Console.WriteLine("Thank you for stopping by!");
                                Environment.Exit(0);

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n");
                                account1Checking.DisplayCheckingAccount();
                                account1Res.DisplayResAccount();
                                account1Savings.DisplaySavingAccount();
                                Console.WriteLine();
                                Greeting.WithdrawDisplay();
                                Console.WriteLine("That wasn't an options, please pick again from the list");
                                choosenAccount = Console.ReadLine();
                            }

                        } while (choosenAccount != "");
                    }


                    //deposit
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
                                Console.WriteLine("How much would you like to deposit from your checking accout?");
                                Console.Write("$");
                                double userNumChecking = double.Parse(Console.ReadLine());
                                account1Checking.AddUserChecking(userNumChecking);
                                Console.ReadLine();
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
                        } while (choosenAccount != "");
                    }
                    
                }


                //Account 2
                else if (choosenOne.ToLower() == "customer 2")
                {
                    Console.WriteLine("yous is right");
                }




















            
        }
    }
}
