using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Ügyfél
    {
        public int azonosító { get; set; }
        public string név { get; set; }
        public string telefon { get; set; }
        public string cím { get; set; }
        public Beosztott kapcsolattartó { get; set; }
        public Ügyfél(int azonosító, string név, string telefon, string cím, Beosztott kapcsolattartó)
        {
            this.azonosító = azonosító;
            this.név = név;
            this.cím = cím;
            this.telefon = telefon;
            this.kapcsolattartó = kapcsolattartó; 
        }

        public Ügyfél()
        {
        }

        public string BeszélgetésNyilvántartása()
        {
            return "kutya";
        }
        public string InternethasználatRögzítése()
        {
            return "kutya";
        }
        public string SzámlaLekérdezése()
        {
            return "kutya";
        }
        public string SzámlaKifizetése()
        {
            return "kutya";
        }
    }
}
