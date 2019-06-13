using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNr;
            int scndNr;

            firstNr = int.Parse(Console.ReadLine());
            scndNr = int.Parse(Console.ReadLine());

            Program.doOperation(firstNr, scndNr, '/');
            Console.ReadKey();

        }



        public static void doOperation(int firstNr,int scndNr, char oparator)
        {
            int rez = -1;

            switch (oparator)
            {
                case '+': rez = firstNr + scndNr;
                    break;

                case '-':rez = firstNr - scndNr;
                    break;

                case '/': rez = firstNr / scndNr;
                    break;

                case '*': rez = firstNr * scndNr;
                    break;
            }

            if(rez==-1)
            {
                Console.WriteLine("Bad operator");
            }else
            {
                Console.WriteLine("result" + rez);
            }

        }
    }
}
