using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class ReserveAccount : Account
    {
        //fields
        private double addRes;
        private double subRes;




        //properties
        public double AddRes
        {
            get { return this.addRes; }
            set { addRes = value; }
        }

        public double SubRes
        {
            get { return this.subRes; }
            set { subRes = value; }
        }

        //constructors
        public void DisplayResAccount()
        {
            Console.WriteLine("Reserved: ${0}", resAmount);
        }

        public void AddUserRes(double userNumRes)
        {
            double addRes = resAmount + userNumRes;
            Console.WriteLine();
            Console.WriteLine("$" + userNumRes + " has been deposited to your checking account");
            Console.WriteLine("Your new balance is $" + addRes);
            Console.WriteLine("Thank you for your time, your money is in good hands.");
            Environment.Exit(0);
        }


        public void SubUserRes(double userNumRes)
        {
            double subRes = resAmount - userNumRes;
            Console.WriteLine();
            Console.WriteLine("$" + userNumRes + " has been withdrawn from your checking account");
            Console.WriteLine("Your new balance is $" + addRes);
            Console.WriteLine("Enjoy your money and spend it wisely...");
            Environment.Exit(0);

        }

    }
}
