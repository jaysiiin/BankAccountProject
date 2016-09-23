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
        private double userMoneyRes;

        


        //properties
        public double UserMoneyRes
        {
            get { return this.userMoneyRes; }
            set { userMoneyRes = value; }

        }
        //constructors
        public void DisplayRes()
        {
            Console.WriteLine("Your current reservation account balance is: $" + userMoneyRes);
        }

    }
}
