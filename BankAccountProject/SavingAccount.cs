using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingAccount : Account
    {
        //fields
        private double addSavings;
        private double subSavings;




        //properties
        public double AddSavings
        {
            get { return this.addSavings; }
            set { addSavings = value; }
        }

        public double SubSavings
        {
            get { return this.subSavings; }
            set { subSavings = value; }
        }

        //constructors
        public void DisplaySavingAccount()
        {
            Console.WriteLine("Savings: ${0}", savingAmount);
        }

        public void AddUserSaving(double userNumSaving)
        {
            double addSaving = savingAmount + userNumSaving;
            Console.WriteLine();
            Console.WriteLine("$" + userNumSaving + " has been deposited to your checking account");
            Console.WriteLine("Your new balance is $" + addSaving);
            Console.WriteLine("Thank you for your time, your money is in good hands.");
            Environment.Exit(0);

        }


        public void SubUserSaving(double userNumSaving)
        {
            double subSaving = savingAmount - userNumSaving;
            Console.WriteLine();
            Console.WriteLine("$" + userNumSaving + " has been withdrawn from your checking account");
            Console.WriteLine("Your new balance is $" + subSaving);
            Console.WriteLine("Enjoy your money and spend it wisely...");
            Environment.Exit(0);

        }

    }
}
