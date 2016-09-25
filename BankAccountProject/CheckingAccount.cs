using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : Account
    {
        //fields
        private double addChecking;
        private double subChecking;




        //properties
        public double AddChecking
        {
            get { return this.addChecking; }
            set { addChecking = value; }
        }

        public double SubChecking
        {
            get { return this.subChecking; }
            set { subChecking = value; }
        }




        //constructor
        public void DisplayCheckingAccount()
        {
            Console.WriteLine();
            Console.WriteLine("Checkings: ${0}", checkingAmount);
        }

        //methods
        public void AddUserChecking(double userNumChecking)
        {
            double addChecking = checkingAmount + userNumChecking;
            Console.WriteLine("$" + userNumChecking + " has been deposited to your checking account");

        }


        public void SubUserChecking (double userNumChecking)
        {
            double subChecking = checkingAmount - userNumChecking ;
            Console.WriteLine("$" + userNumChecking + " has been withdrawn from your checking account");

        }

        internal void SubUserChecking(string userNumChecking)
        {
            throw new NotImplementedException();
        }
    }
}
