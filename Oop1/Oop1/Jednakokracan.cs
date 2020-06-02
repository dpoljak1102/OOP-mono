using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public class Jednakokracan : Trokut
    {
        public Jednakokracan(double a, double b, double c) : base(a, b, c) { }
        public override void Info()
        {
            Console.WriteLine("Jednakokracan trokut je onaj kojemu su 2 stranice jednake ");
        }
    }
}
