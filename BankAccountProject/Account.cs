using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        //fields

        public double checkingAmount;
        public double resAmount;
        public double savingAmount;
     
     
      
        //constructors
        public Account()
        {

            checkingAmount = 500;
            savingAmount = 500;
            resAmount = 500;
        }

        public void WithdrawDisplay()
        {
            Console.WriteLine("Which account would you like to withdraw from?\nCheckings, Resereved, or Savings account? Enter \"quit\" to exit.");
        }

        public void DepositDisplay()
        {
            Console.WriteLine("Which account would you like to deposit?\nCheckings, Resereved, or Savings account? Enter \"quit\" to exit.");
        }
      
        


    }
}
