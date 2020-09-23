using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_object
{
    class Calculator
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Your Answer is: "+ a + b);
        }
        
        public void sub(int a, int b)
        {
            Console.WriteLine("Your Answer is: "+ a - b);
        }

        public void mult(int a, int b)
        {
            Console.WriteLine("Your Answer is: "+ a * b);
        }

        public void div(float a, float b)
        {
            Console.WriteLine("Your Answer is: "+ a / b);
        }

    }
}
