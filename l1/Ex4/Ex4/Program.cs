using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());

            double idealKg;
            if(sex.Equals('f'))
            {
                idealKg = ComputeKg.computeF(height, age, sex);
                ComputeKg.printConversion(idealKg);

            }
            else if(sex.Equals('b'))
            {
                idealKg = ComputeKg.computeB(height, age, sex);
                ComputeKg.printConversion(idealKg);

            }
            else
            {
                Console.WriteLine("only 2 genders allowed");
            }
            Console.ReadKey();
            
        }
    }

    class ComputeKg
    {
        public static double computeF(int height, int age, char sex)
        {
           
            return (double)(height - 100 - ((height - 150) / 2.5)  + ((age - 20) / 6));
        }



        public static double computeB(int height, int age, char sex)
        {

            return (double)(height - 100 - ((height - 150) / 4) + ( (age - 20) / 4));
        }

        public static void printConversion(double idealkg)
        {
            Console.WriteLine("Ideal: " + idealkg);
        }
    }


}
