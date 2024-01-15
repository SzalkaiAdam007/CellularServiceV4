using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Számla
    {
        public int azonosító { get; set; }

        public Ügyfél ügyfél { get; set; }

        public DateTime dátum = DateTime.Now;
        public bool befizetve { get; set; }
        public int összeg { get; set; }

        public bool sztornó = false;


        public List<SzámlaTételek> tételLista { get; set; }

        public Számla(int azonosító, Ügyfél ügyfél, int összeg, bool befizetve)
        {
            this.azonosító = azonosító;
            this.ügyfél = ügyfél;
            this.összeg = összeg;
            this.befizetve = befizetve;
        }

        public string SzámlaNyomtatás()
        {
            return "kutya";
        }
        public void SztornóSzámla()
        {
            sztornó = true;
        }
    }
}
