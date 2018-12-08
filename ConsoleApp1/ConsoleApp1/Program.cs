using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Županija a = new Županija("Medimurska");
            a.DodajNaselje(new Naselje("Peklenica", 1400, VrstaNaselja.Selo));
            a.DodajNaselje(new Naselje("Pribislavec", 1300, VrstaNaselja.Selo));
            a.DodajNaselje(new Naselje("Cakovec", 16000, VrstaNaselja.Grad));
            a.DodajNaselje(new Naselje("Prelog", 4300, VrstaNaselja.Grad));

            Console.WriteLine("{0} zupanija", a.VratiNaziv());
            a.VratiNaselja();
            Console.WriteLine("Broj naselja u Zupaniji: {0} iznosi: {1}", a.VratiNaziv(),a.VratiBrojNaselja());
            Console.WriteLine("Od toga ima {0} gradova.", a.VratiBrojGradova());
            Console.WriteLine("Od toga ima {0} sela.", a.VratiBrojSela());
            Console.WriteLine("{0} zupanija ima ukupno {1} stanovnika.", a.VratiNaziv(), a.VratiBrojStanovnikaUZupaniji());
            Console.WriteLine("Prosjecan broj stanovnika po naselju iznosi: {0}.", a.VratiProsjecanBrojStanovnikaPoNaselju());
            a.VratiNaseljaSortirano();
            Console.ReadKey();
        }
    }
}
