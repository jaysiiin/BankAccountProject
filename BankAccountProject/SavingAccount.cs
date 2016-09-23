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
        private double userAddSavings;
        private double userSubSavings;




        //properties
        public double AddSavings
        {
            get { return this.userAddSavings; }
            set { userAddSavings = value; }
        }

        public double SubSavings
        {
            get { return this.userSubSavings; }
            set { userSubSavings = value; }
        }

        //constructors
        public void DisplaySavingAccount()
        {
            Console.WriteLine("Savings: ${0}", savingAmount);
        }

    }
}
