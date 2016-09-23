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
        public double UserMoneyChekcing
        {
            get { return this.userMoneyChecking; }
            set { userMoneyChecking = value; }

        }

        
        //constructors


    }
}
