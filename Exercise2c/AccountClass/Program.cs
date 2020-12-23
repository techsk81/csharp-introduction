using System;

namespace Exercise2c
{
    class Program
    {
        static void Main(string[] args)
        {
            double accountNum;
            double balance, charges, credit, creditLimit;

            Console.WriteLine("Enter the account number:");
            accountNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the balance at the beginning of the month:");
            balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the charges:");
            charges = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the credit applied to the account:");
            credit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the credit limit:");
            creditLimit = Convert.ToDouble(Console.ReadLine());

            //get object (Account class)
            Account account = new Account(accountNum, balance, charges, credit, creditLimit);

            if (account.calcBalance() > account.CreditLimit)
            {
                Console.WriteLine("Credit limit exceeded");
            }
            Console.WriteLine("Your current balance is {0:C}", account.calcBalance());

            Console.ReadLine();


        }
    }
}

        