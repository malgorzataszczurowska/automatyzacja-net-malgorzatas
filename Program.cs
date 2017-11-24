using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj świecie!");
            Console.WriteLine("Aby zamknąć aplikację wpisz EXIT i naciśnij Enter");
            Console.ReadLine();
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
