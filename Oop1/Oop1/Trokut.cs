using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public class Trokut : GeometriskiLik
    {

        //stranice trokuta
        protected double _a;
        protected double _b;
        protected double _c;

        public Trokut()
        {
            this._a = 0;
            this._b = 0;
            this._c = 0;
        }
        public Trokut(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public void PrintStranice()
        {
            Console.WriteLine("Stranice trokuta :" + _a + "," + _b + "," + _c);
        }
        public virtual double Opseg()
        {
            return _a + _b + _c;
        }

        public double Povrsina(double v)
        {
            return (_a * v) / 2;

        }

        public void TypeTrokut()
        {
            if (_a == _b && _b == _c)
            {
                Console.WriteLine("Trokut je jednakostranican");
            }
            else if (_a == _b || _a == _c || _b == _c)
            {
                Console.WriteLine("Trokut je jednakokracan");
            }
            else
            {
                Console.WriteLine("Trokut je raznostranican");
            }
        }

        public override void Info()
        {
            Console.WriteLine("Trokut se sastoji od 3 stranice i 3 kuta");
        }

        public void FullInfo()
        {
            PrintStranice();
            TypeTrokut();
            Info();
        }

    }
}
