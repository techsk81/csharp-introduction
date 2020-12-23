using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2c
{
    class GrossPay
    {
        static void Main(string[] args)
        {
            double hoursWorked, hourlyRate;

            Console.WriteLine("Enter the number of hours worked last week: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            double grossPay = 0;

            if (grossPay >= 40)
            {

                grossPay = (40 * hourlyRate) + ((hoursWorked - 40) * 1.5 * hourlyRate);

            }
            else
            {
                grossPay = hourlyRate * hoursWorked;
            }

            Console.WriteLine("The Gross Pay is: " + grossPay);

        }

    }
}
