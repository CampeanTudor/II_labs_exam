using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            exempleConsoleApp.ServiceReference1.WebService1SoapClient service = new exempleConsoleApp.ServiceReference1.WebService1SoapClient();

            string c = service.getCurrentDateAndTime().ToString();
            Console.WriteLine("Date and time " + c);
            Console.ReadKey();

        }
    }
}
