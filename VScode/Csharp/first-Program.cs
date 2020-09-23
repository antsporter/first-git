using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy, che, mat;
            int total;
            float per;
            phy = 95;
            che = 80;
            mat = 12;
            total = phy + che + mat;
            per = (float)total * 100 / 450;
            Console.Write("Total Marks: ");
            Console.WriteLine(total);
            Console.Write("Percentage: ");
            Console.WriteLine(per);
            if(per >= 60){
                Console.WriteLine("You have Passed the Exam");
            }
            else
            {
                Console.WriteLine("You have Failed the Exam");
            }

            int counter;
            counter = 1;

            while (counter <= 10)
            {
                Console.WriteLine("Hello");
                counter = counter + 1;
            }

            int loop;

            for (loop = 1; loop <= 10; loop++)

            {
                Console.WriteLine("World");
            }

            Console.Read();
        }
    }
}
