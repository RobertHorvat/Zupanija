using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Županija
    {
        private string naziv;
        private List<Naselje> naselja = new List<Naselje>();

        public Županija(string naziv)
        {
            this.naziv = naziv;
        }

        public void DodajNaselje(Naselje naselje)
        {
            naselja.Add(naselje);
        }

        public string VratiNaziv()
        {
            return naziv;
        }

        //public List<Naselje> VratiNaselja()
        //{
        //    return naselja;
        //}

        public void VratiNaselja()
        {
            IspisiListu(naselja);

        }

        public void VratiSela()
        {
            List<Naselje> Sela = new List<Naselje>();
            for(int x=0;x<naselja.Count();x++)
            {
                if(naselja.ElementAt(x+1).VratiVrstuNaselja()==VrstaNaselja.Selo)
                {
                    Sela.Add(naselja.ElementAt(x + 1));
                }
            }
            //return Sela;
            IspisiListu(Sela);
        }

        public void VratiGradove()
        {
            List<Naselje> Gradovi = new List<Naselje>();
            for (int x = 0; x < naselja.Count(); x++)
            {
                if (naselja.ElementAt(x + 1).VratiVrstuNaselja() == VrstaNaselja.Grad)
                {
                    Gradovi.Add(naselja.ElementAt(x + 1));
                }
            }
            IspisiListu(Gradovi);
        }

        public int VratiBrojNaselja()
        {
            int broj = 0;
            foreach (Naselje n in naselja)
                broj++;
            return broj;
        }

        public int VratiBrojSela()
        {
            int broj = 0;
            foreach (Naselje n in naselja)
                if (n.VratiVrstuNaselja() == VrstaNaselja.Selo)
                    broj++;
            return broj;
        }

        public int VratiBrojGradova()
        {
            int broj = 0;
            foreach (Naselje n in naselja)
                if (n.VratiVrstuNaselja() == VrstaNaselja.Grad)
                    broj++;
            return broj;
        }

        public long VratiBrojStanovnikaUZupaniji()
        {
            long broj = 0;
            foreach (Naselje n in naselja)
                broj += n.VratiBrojStanovnika();
                    
            return broj;
        }

        public double VratiProsjecanBrojStanovnikaPoNaselju()
        {
            long ukupanBroj = 0;
            double broj;
            foreach (Naselje n in naselja)
                ukupanBroj += n.VratiBrojStanovnika();

            return broj = ukupanBroj / naselja.Count();
            
        }
        
        public void VratiNaseljaSortirano()
        {
            naselja.Sort();
            IspisiListu(naselja);
            
        }

        public void IspisiListu(List<Naselje> s)
        {
            foreach (Naselje n in s)
            {
                Console.WriteLine();
                Console.WriteLine("Naziv: {0}", n.VratiNaziv());
                Console.WriteLine("Broj stanovnika: {0}", n.VratiBrojStanovnika());
                Console.WriteLine("Vrsta naselja: {0}", n.VratiVrstuNaselja());
                
            }
        }


    }
}
