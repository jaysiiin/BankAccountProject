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

    }
}
