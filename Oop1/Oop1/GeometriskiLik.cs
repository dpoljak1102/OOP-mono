using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    public class GeometriskiLik : AbstractInfo
    {
        public void TestFromGeometriskiLik()
        {
            Console.WriteLine("property from GeometriskiLik");
        }
        public override void Info()
        {
            Console.WriteLine("Geometriski lik informacija");
        }
    }
}
