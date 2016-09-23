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
        private double userMoneyChecking;

        


        //properties
        public double UserMoneyChecking
        {
            get { return this.userMoneyChecking; }
            set { userMoneyChecking = value; }

        }

        
        //constructors
        public void DisplayChecking()
        {
            Console.WriteLine("Your current checking account balance is: $" + userMoneyChecking);
        }

    }
}
