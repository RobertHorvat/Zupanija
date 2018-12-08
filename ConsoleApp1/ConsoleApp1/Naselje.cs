using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Naselje: IComparable<Naselje>
    {
        private string naziv;
        private long brojStanovnika;
        private VrstaNaselja vrsta;
       

        public Naselje(string naziv,long brojStanovnika,VrstaNaselja vrsta)
        {
            this.naziv = naziv;
            this.vrsta = vrsta;
            if (brojStanovnika <= 0)
                throw new ArgumentException(String.Format("Broj stanovnika nije pravilno unesen!"));
            else
                this.brojStanovnika = brojStanovnika;
        }

        public string VratiNaziv()
        {
            return naziv;
        }

        public long VratiBrojStanovnika()
        {
            return brojStanovnika;
        }

        public VrstaNaselja VratiVrstuNaselja()
        {
            return vrsta;
        }

        public int CompareTo(Naselje other)
        {
            //throw new NotImplementedException();
            if (VratiBrojStanovnika() > other.VratiBrojStanovnika())
                return 1;
            else if (VratiBrojStanovnika() < other.VratiBrojStanovnika())
                return -1;
            else
                return 0;
        }
    }
}
