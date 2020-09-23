using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_object
{
    class Operations
    {
        public int no1, no2;

        public void message()
        {
            Console.WriteLine("How are you?");
        }

        public void times(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("The result is of the addition is " + result);
        }

        public void SalaryCalc (int salary)
        {
            float tax, net;
            if (salary >= 40000)
            {
                tax = salary * 40 / 100;
            }
            else
            {
                tax = salary * 20 / 100;
            }
            net = salary - tax;

            Console.WriteLine("-------------");
            Console.WriteLine("Your Salary is: " + salary);
            Console.WriteLine("Your Tax calculated is: " + tax);
            Console.WriteLine("Your Net Salary is: " + net);

        }

    }
}
