using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Telefon_Szolgáltatás
{

    internal class Főnök : Dolgozó
    {
        public string gépkocsi { get; set; }

        public Főnök(string név, string cím, string telefon, string gépkocsi) : base(név, cím, telefon)
        {
            this.gépkocsi = gépkocsi;
        }
        public override bool Bejelentkezés(String név)
        {
            return this.név == név;
        }
        public override bool Input(string input, Szolgáltató szolgáltató)
        {
            bool res = false;
            switch (input)
            {
                case "beok":
                    BeosztottLista(szolgáltató);
                    res = true;
                    break;
                default:
                    Info();
                    break;
            }
            return res;
        }


        public void BeosztottLista(Szolgáltató szolgáltató)
        {
            foreach (Beosztott beosztott in szolgáltató.beosztottLista)
            {
                Console.WriteLine("név: " + beosztott.név + ", Cím: " + beosztott.cím + ", beosztás: " + beosztott.beosztás + ", Telszám: " + beosztott.telefon);
            }
        }

        public override void Info()
        {
            Console.WriteLine("beok: beosztottak listája");
            Console.WriteLine("logout: kijelentkezés");
            Console.WriteLine("exit: kilépés a programból");
            Console.WriteLine("Kérem válasszon funkciót:");
        }

    }
}
