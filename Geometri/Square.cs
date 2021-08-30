using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Square
    {
        //Opgave A
        private double a;
        
        public Square(double a)
        {
            this.a = a;
        }
        public double Omkreds()
        {
            double omkreds = 4 * a;
            return omkreds;
        }
        public double Areal()
        {
            double areal = Math.Pow(a, 2);
            return areal;
        }
        //Opgave B
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        


    }
}
