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
        private double userStartMoney;
        private double userAddMoney;
        private double userSubMoney;
        private double checkingAmount;
        private double resAmount;
        private double savingAmount;


        //properties
        public double UserAddMoney
        {
            get { return this.userAddMoney; }
            set { userAddMoney = value; }

        }

        public double UserSubMoney
        {
            get { return this.userSubMoney; }
            set { userSubMoney = value; }

        }

        public double CheckingAmount
        {
            get { return this.checkingAmount; }
            set { checkingAmount = value; }

        }

        public double SavingAmount
        {
            get { return this.savingAmount; }
            set { savingAmount = value; }

        }
        public double ResAmount
        {
            get { return this.resAmount; }
            set { resAmount = value; }

        }

       


        //constructors
        //public CheckingAccountHardCode()
        //{

        //    checkingAmount = 500;
        //}


        //method



    }
}
