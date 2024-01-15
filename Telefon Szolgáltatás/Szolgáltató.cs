using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Szolgáltató
    {
        public string név { get; set; }
        public string címadatok { get; set; }
        public string elérhetőségek { get; set; }
        public string ügyfelekLista { get; set; }
        public string tartozásLista { get; set; }

        public string Bejelentkezés()
        {
            return "kutya";
        } 
        public string ListákLekérdezése()
        {
            return "kutya";
        } 
        public string ÁltalánosAdatokMódosítása()
        {
            return "kutya";
        }

    }
}
