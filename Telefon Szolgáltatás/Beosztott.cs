using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Beosztott : Szolgáltató
    {
        public string név { get; set; }
        public string beosztás { get; set; }
        public string elérhetőség { get; set; }
        public override string ÜgyfélKarbantartás()
        {
            return "kutyaaa";
        }
        public string SzámlaLétrehozás()
        {
            return "kutya";
        }
        public string TartozásLekérdezés()
        {
            return "kutya";
        }
    }
}
