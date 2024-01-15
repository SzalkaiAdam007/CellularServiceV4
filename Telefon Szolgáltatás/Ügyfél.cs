using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Ügyfél
    {
        public string ügyfélAdatok { get; set; }
        public string kapcsolattartó { get; set; }
        public string kifizetettSzámlák { get; set; }
        public string számlaTartozás { get; set; }
       
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
