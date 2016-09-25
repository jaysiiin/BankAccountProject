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
        private double addRes;
        private double subRes;




        //properties
        public double AddRes
        {
            get { return this.addRes; }
            set { addRes = value; }
        }

        public double SubRes
        {
            get { return this.subRes; }
            set { subRes = value; }
        }

        //constructors
        public void DisplayResAccount()
        {
            Console.WriteLine("Reserved: ${0}", resAmount);
        }

    }
}
