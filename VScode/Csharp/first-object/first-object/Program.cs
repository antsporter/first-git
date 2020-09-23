using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Nationwide X;
            X = new Nationwide();
            X.A = 10;
            X.B = 33;
            X.C = X.A + X.B;
            X.D = 81;
            X.E = X.C + X.D;
            X.F = X.E * X.D;
            Console.WriteLine(X.F);

            Welcome Y;
            Y = new Welcome();
            Y.message();

            Operations Z;
            Z = new Operations();
            Z.message();
            Z.times(34, 567);
            Z.message();
            Z.times(2854, 1034);

            Z.SalaryCalc(25000);
            Z.SalaryCalc(52000);

            Calculator CAL;
            CAL = new Calculator();
            CAL.add(1, 5);
            CAL.sub(10, 5);
            CAL.mult(2, 20);
            CAL.div(100, 5);
 
            Console.Read();
        }
    }
}
