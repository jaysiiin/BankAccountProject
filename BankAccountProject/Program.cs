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
            SavingAccount account1Saving = new SavingAccount();
            Account Greeting = new Account();
            StreamWriter Sam = new StreamWriter("Sam.txt");
            StreamWriter Withdraw = new StreamWriter("Withdraw.txt");
            StreamWriter Deposit = new StreamWriter("Deposit.txt");
            


            //Intro
            
                Console.WriteLine("\n\n");
                Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
                Console.WriteLine("Sam S.?");
                string choosenOne = Console.ReadLine();
            using (Sam)
            {
                Sam.WriteLine("user name: " + choosenOne);

                do
                {
                    if (choosenOne.ToLower() == "sam s." || choosenOne.ToLower() == "sam s" || choosenOne.ToLower() == "sam")
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Please enter your 7 digit account number.");
                        string userAccountNum = Console.ReadLine();
                        Sam.WriteLine("user account #: " + userAccountNum);

                        if (userAccountNum.Length > 7 || userAccountNum.Length < 7)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Please enter the your 7 digit account number.");
                            userAccountNum = Console.ReadLine();

                        }


                        Console.WriteLine("Please enter your password.");
                        string password = Console.ReadLine();
                        if (password == "password1")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That's the wrong password, please enter it again.");
                            password = Console.ReadLine();
                        }
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Hello, welcome to the automated bank teller!\nWhich account are you accessing today?");
                        Console.WriteLine("That account does not exist in this program.");
                        choosenOne = Console.ReadLine();
                    }
                } while (choosenOne.ToLower() == "sam s." || choosenOne.ToLower() == "sam s" || choosenOne.ToLower() == "sam");
              }




            //Account 1



            if (choosenOne.ToLower() == "sam s." || choosenOne.ToLower() == "sam s" || choosenOne.ToLower() == "sam")
            {
                
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Welcome back Sam S., here is your account information.");
                    account1Checking.DisplayCheckingAccount();
                    account1Res.DisplayResAccount();
                    account1Saving.DisplaySavingAccount();
                    Console.WriteLine("Would you like to withdraw or deposit today? Or \"quit\" to quit.");
                    string choosenWithDepo = Console.ReadLine();

                //withdraw
                if (choosenWithDepo.ToLower() == "withdraw")
                {

                    Console.Clear();
                    Console.WriteLine("\n\n");
                    account1Checking.DisplayCheckingAccount();
                    account1Res.DisplayResAccount();
                    account1Saving.DisplaySavingAccount();
                    Console.WriteLine();
                    Greeting.WithdrawDisplay();
                    string choosenAccount = Console.ReadLine();
                    ;

                    
                        do
                        {
                        using (Withdraw)
                        {
                            Withdraw.WriteLine(choosenAccount);
                        }

                            //}
                            if (choosenAccount.ToLower() == "checkings")
                            {
                                Console.WriteLine("How much would you like to withdraw from your checking accout?");
                                Console.Write("$");
                                double userNumChecking = double.Parse(Console.ReadLine());
                                account1Checking.SubUserChecking(userNumChecking);
                                Withdraw.WriteLine("-$" + userNumChecking + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss"));

                            }

                            else if (choosenAccount.ToLower() == "reserved")
                            {
                                Console.WriteLine("How much would you like to withdraw from your reserved accout?");
                                Console.Write("$");
                                double userNumRes = double.Parse(Console.ReadLine());
                                account1Res.SubUserRes(userNumRes);
                                Withdraw.WriteLine("-$" + userNumRes + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss"));


                            }
                            else if (choosenAccount.ToLower() == "savings")
                            {
                                Console.WriteLine("How much would you like to withdraw from your checking accout?");
                                Console.Write("$");
                                double userNumSaving = double.Parse(Console.ReadLine());
                                account1Saving.SubUserSaving(userNumSaving);
                                Withdraw.WriteLine("-$" + userNumSaving + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss"));
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
                                account1Saving.DisplaySavingAccount();
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
                    account1Saving.DisplaySavingAccount();
                    Console.WriteLine();
                    Console.WriteLine("Which account would like to deposit to?\nCheckings, Resereved, or Savings account? Enter \"quit\" to exit.");
                    string choosenAccount = Console.ReadLine();

                    
                        do
                        {
                        using (Deposit)
                        {
                            Deposit.WriteLine(choosenWithDepo);
                        }
                            if (choosenAccount.ToLower() == "checkings")
                            {
                                Console.WriteLine("How much would you like to deposit from your checking accout?");
                                Console.Write("$");
                                double userNumChecking = double.Parse(Console.ReadLine());
                                account1Checking.AddUserChecking(userNumChecking);
                                Deposit.WriteLine("+$" + userNumChecking + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss"));
                                Console.ReadLine();
                            }
                            else if (choosenAccount.ToLower() == "reserved")
                            {
                                Console.WriteLine("How much would you like to deposit from your reserved accout?");
                                Console.Write("$");
                                double userNumRes = double.Parse(Console.ReadLine());
                                account1Res.AddUserRes(userNumRes);
                                Deposit.WriteLine("+$" + userNumRes + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss"));
                                Console.ReadLine();
                            }
                            else if (choosenAccount.ToLower() == "savings")
                            {
                                Console.WriteLine("How much would you like to deposit from your savings accout?");
                                Console.Write("$");
                                double userNumSavings = double.Parse(Console.ReadLine());
                                account1Saving.AddUserSaving(userNumSavings);
                                Deposit.WriteLine("+$" + userNumSavings + DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss"));
                                Console.ReadLine();
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
                                account1Saving.DisplaySavingAccount();
                                Console.WriteLine();
                                Console.WriteLine("Which account would like to deposit to?\nCheckings, Resereved, or Savings account? Enter \"quit\" to exit.");
                                Console.WriteLine("That wasn't an options, please pick again from the list");
                                choosenAccount = Console.ReadLine();
                            }
                        

                        } while (choosenAccount != "");
        
                    }
                

                else if (choosenWithDepo.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you for using this program.");
                    Environment.Exit(0);
                }

                

            }
            
               




































            
        }
    }
}
