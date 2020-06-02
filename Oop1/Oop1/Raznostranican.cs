using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public class Raznostranican : Trokut
    {
        public Raznostranican(double a, double b, double c) : base(a, b, c) { }
        public override void Info()
        {
            Console.WriteLine("Raznostranican trokut koji ima sve razlicite stranice ");
        }
    }
}
