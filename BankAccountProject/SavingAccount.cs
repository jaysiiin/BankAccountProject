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
        private double userMoneySaving;




        //properties
        public double UserMoneySaving
        {
            get { return this.userMoneySaving; }
            set { userMoneySaving = value; }

        }
        //constructors


    }
}
