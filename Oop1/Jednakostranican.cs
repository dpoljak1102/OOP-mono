using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    // Namjerno nismo overide napravil tako da ispistuje Trokut.info
    public class Jednakostranican : Trokut
    {
        public Jednakostranican(double a, double b, double c) : base(a, b, c) { }
        //Opseg +100
        public override double Opseg()
        {
            return _a + _b + _c + 100;
        }
    }
}
