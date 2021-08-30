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
            Console.WriteLine(a.Omkreds());
            Console.WriteLine(a.Areal());
            //Opgave B
            Square a1 = new Square();
            a1.A = 10;
            Console.WriteLine(a1.Omkreds());

            Console.ReadKey();
        }
    }
}
