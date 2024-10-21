using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hourly rate :-");
            var hourlyRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hours worked");

            var hoursWorked = int.Parse(Console.ReadLine());
            var extraHours = (hoursWorked - 40);

            if (hoursWorked >= 40)
            {
                Console.WriteLine("Extra worked hours : {0}" ,extraHours);
                var overTimePay = extraHours * (hourlyRate * 1.5);
                Console.WriteLine("Over time pay = {0}",overTimePay);

            }
            else
            {
                Console.WriteLine("You have to work atleast 40 hours");
            }

            var regularPay = hourlyRate * 40;
            Console.WriteLine("Regular pay : {0}", regularPay);



            var grossPay = hourlyRate * hoursWorked;
            var netPay = ((hourlyRate * hoursWorked) - (grossPay/20));


            Console.WriteLine("Net pay = {0}",netPay);
            Console.WriteLine("Gross pay = {0}",grossPay);





        }
    }
}
