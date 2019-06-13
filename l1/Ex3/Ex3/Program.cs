using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            int initTemp=int.Parse(Console.ReadLine());
            String initMeasUnit = Console.ReadLine();

            if(initMeasUnit.Equals("C"))
            {
                Console.WriteLine(Program.convertToF(initTemp));
            }
            else if(initMeasUnit.Equals("F"))
            {
                Console.WriteLine(Program.convertToC(initTemp));
            }
            else
            {
                Console.WriteLine("Bad measurement unit");
            }


            Console.ReadKey();

        }


        public static int convertToC(int tempF)
        {
            return (tempF - 32) / 5 * 9;
        }

        public static int convertToF(int tempC)
        {
            return tempC * 9 / 5 + 32;
        }
    }
}
