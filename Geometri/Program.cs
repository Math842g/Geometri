using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave A
            Square a = new Square(4);
            double omkreds = a.Omkreds();
            Console.WriteLine(omkreds);

            Square firkant = new Square(5);
            double areal = firkant.Areal();
            Console.WriteLine(areal);
            //Opgave B
            a.Side = 10;
            omkreds = a.Omkreds();
            areal = a.Areal();
            Console.WriteLine(omkreds);
            Console.WriteLine(areal);
            Console.ReadKey();
        }
    }
}
