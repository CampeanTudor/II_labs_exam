using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] rez = Program.fibonnaciSequence(8);

            for(int i=0;i<rez.Length;i++)
            {
                Console.WriteLine(rez[i]);
            }

            Console.ReadKey();

        }


        public static int[] fibonnaciSequence(int nrOfElements)
        {

            int[] fSequnce = new int[nrOfElements];
            fSequnce[0] = 0;
            fSequnce[1] = 1;

            int i;
            for (i = 2;i<nrOfElements;i++)
            {
                fSequnce[i] = fSequnce[i - 1] + fSequnce[i - 2];
            }

            return fSequnce;

        }
    }
}
