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
}
