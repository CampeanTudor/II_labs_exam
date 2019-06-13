using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            String arrayToBeProcessed = Console.ReadLine();
            String[] splited = arrayToBeProcessed.Split(new char[]{' ' });

            int[] array = Array.ConvertAll(splited, s => int.Parse(s));


            double aritm = 0;

            for(int i = 0;i<array.Length;i++)
            {
                aritm += array[i];
            }

            aritm = Math.Sqrt(aritm);


            double geom = 1;

            for (int i = 0; i < array.Length; i++)
            {
                geom *= array[i];
            }


            geom = Math.Pow(geom,1/(double)array.Length);


            Console.WriteLine(aritm);
            Console.WriteLine(geom);

            Console.ReadKey();





        }
    }
}
