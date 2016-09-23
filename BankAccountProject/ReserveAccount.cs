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
        private double userAddRes;
        private double userSubRes;




        //properties
        public double AddRes
        {
            get { return this.userAddRes; }
            set { userAddRes = value; }
        }

        public double SubRes
        {
            get { return this.userSubRes; }
            set { userSubRes = value; }
        }

        //constructors
        public void DisplayResAccount()
        {
            Console.WriteLine("Reserved: ${0}", resAmount);
        }

    }
}
