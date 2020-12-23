using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2c
{
    class Account
    {
        //constructor
        public Account(double accountNum, double balance, double charges, double credit, double creditLimit)
        {
            AccountNum = accountNum;
            Balance = balance;
            Charges = charges;
            Credit = credit;
            CreditLimit = creditLimit;

        }

        // get and set
        public double AccountNum { get; set; }
        public double Balance { get; set; }
        public double Charges { get; set; }
        public double Credit { get; set; }
        public double CreditLimit { get; set; }

        //calculate new balance - the new balance (= beginning balance + charges – credits)
        public double calcBalance()
        {
            return (Balance + Charges - Credit);
        }
    }

}
