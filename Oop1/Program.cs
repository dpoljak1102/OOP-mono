using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut(1,2,3);
            trokut.FullInfo();

            Raznostranican raznostranican = new Raznostranican(2,5,7);
            raznostranican.FullInfo();

            //Izracunati opseg i povrsinu za npr jednakokracan trokut
            Jednakokracan jednakokracan = new Jednakokracan(2,2,5);
            Console.WriteLine("\nOpseg: {0}\nPovrsina: {1}", jednakokracan.Opseg(), jednakokracan.Povrsina(3));

            //Overide smo radili na opsegu kod jednakostranicnog trokuta opseg+100
            Jednakostranican jednakostranican = new Jednakostranican(7,7,7);
            Console.WriteLine("\nTrebamo dobiti opseg koji je sigurno veci od 100, Opseg:{0}", jednakostranican.Opseg());

            //Provjeri vrstu trokuta
            Trokut trokut1 = new Trokut(6, 6, 2);
            Console.WriteLine("\nProvjera vrste trokuta");
            trokut1.TypeTrokut();
            Console.WriteLine("\nPrikaz stranica");
            trokut1.PrintStranice();

            //generics
            GenType<int> genType = new GenType<int>();
            genType.Method<string>("Hello world");

        }
    }

    //generics
    public class GenType<T> {
        public void Method<A>(A input) {
            Console.WriteLine(input);
        }
    }

    interface I {
        void Info();
    }
    public abstract class AbstractInfo:I {
        public abstract void Info();
    }

    public class GeometriskiLik: AbstractInfo {
        public void TestFromGeometriskiLik() {
            Console.WriteLine("property from GeometriskiLik");
        }
        public override void Info() {
            Console.WriteLine("Geometriski lik informacija");
        }
    }

    public class Trokut : GeometriskiLik {

        //stranice trokuta
        protected double _a;
        protected double _b;
        protected double _c;

        public Trokut() {
            this._a = 0;
            this._b = 0;
            this._c = 0;
        }
        public Trokut(double a, double b, double c) {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public void PrintStranice() {
            Console.WriteLine("Stranice trokuta :" + _a + ","+ _b+ "," + _c);
        }
        public virtual double Opseg() {
            return _a + _b + _c;
        }
        
        public double Povrsina(double v) {
            return (_a*v)/2;
            
        }

        public void TypeTrokut() {
            if (_a == _b && _b == _c)
            {
                Console.WriteLine("Trokut je jednakostranican");
            }
            else if (_a == _b || _a == _c || _b == _c)
            {
                Console.WriteLine("Trokut je jednakokracan");
            }
            else {
                Console.WriteLine("Trokut je raznostranican");
            }
        }

        public override void Info(){
            Console.WriteLine("Trokut se sastoji od 3 stranice i 3 kuta");
        }

        public void FullInfo() {
            PrintStranice();
            TypeTrokut();
            Info();
        }

    }
    public class Raznostranican : Trokut {

        public Raznostranican(double a, double b, double c): base(a,b,c) { }
        public override void Info(){
            Console.WriteLine("Raznostranican trokut koji ima sve razlicite stranice ");
        }
    }

    public class Jednakokracan : Trokut {
        public Jednakokracan(double a, double b, double c) : base(a, b, c) { }
        public override void Info(){
            Console.WriteLine("Jednakokracan trokut je onaj kojemu su 2 stranice jednake ");
        }
    }
    // Namjerno nismo overide napravil tako da ispistuje Trokut.info
    public class Jednakostranican : Trokut {
        public Jednakostranican(double a, double b, double c) : base(a, b, c) { }
        //Opseg +100
        public override double Opseg()
        {
            return _a + _b + _c + 100;
        }
    }
}
