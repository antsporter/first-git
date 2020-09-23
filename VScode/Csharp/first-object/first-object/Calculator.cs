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
            float addition;
            addition = a + b;
            Console.WriteLine("Your Answer is: "+ addition);
        }
        
        public void sub(int a, int b)
        {
            float subtract;
            subtract = a - b;
            Console.WriteLine("Your Answer is: "+ subtract);
        }

        public void mult(int a, int b)
        {
            float multiply;
            multiply = a * b;
            Console.WriteLine("Your Answer is: "+ multiply);
        }

        public void div(float a, float b)
        {
            float divide;
            divide = a / b;
            Console.WriteLine("Your Answer is: "+ divide);
        }

    }
}
