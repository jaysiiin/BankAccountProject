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
        private double userAddChecking;
        private double userSubChecking;
        



        //properties
        public double AddChecking
        {
            get { return this.userAddChecking; }
            set { userAddChecking = value; }
        }

        public double SubChecking
        {
            get { return this.userSubChecking; }
            set { userSubChecking = value; }
        }


        //constructor
        public void DisplayCheckingAccount()
        {
            Console.WriteLine();
            Console.WriteLine("Checking: ${0}", checkingAmount);
        }
    }
}
