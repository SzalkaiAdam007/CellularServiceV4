using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Szolgáltató
    {
        private Dolgozó dolgozo = null;  // bejelentkezett dolgozó
        public string név { get; set; }
        public string cím { get; set; }
        public string telefon { get; set; }
        public Főnök főnök { get; set; }
        public Alapadatok adatok { get; set; }
        public List<Beosztott> beosztottLista { get; set; }
        public List<Ügyfél> ügyfélLista { get; set; }
        public List<Számla> számlaLista { get; set; }

        public Szolgáltató(string név, string cím, string telefon, Alapadatok adatok)
        {
            this.név = név;
            this.cím = cím;
            this.telefon = telefon;
            this.adatok = adatok;
            beosztottLista = new List<Beosztott>();
            ügyfélLista = new List<Ügyfél>();
            számlaLista=new List<Számla>();
        }

        public void Input()
        {
            Console.WriteLine("exit: kilépés a programlól");
            Console.WriteLine("logout: kilépés a Szolgáltatóból");
            Console.WriteLine("Kérem jelentkezzen be! Adja meg a nevét:");

            string input = "";
            while (input!="exit") {
                input = Console.ReadLine();
                if (dolgozo == null)
                {
                    Bejelentkezés(input);

                }
                else
                {
                    switch (input)
                    {
                        case "logout":
                            dolgozo = null;
                            Console.WriteLine("Kijelentkezve! Adja meg a nevét:");
                            break;
                        default:
                            dolgozo.Input(input, this);
                            break;
                    }
                }
            }
        }

        public void Bejelentkezés(String név)
        {
            if(főnök.Bejelentkezés(név))
            {
                dolgozo = főnök;
                Console.WriteLine("Üdvözlöm főnök!");
                dolgozo.Info();
            }
            else
            {
                foreach (Beosztott beosztott in beosztottLista)
                {
                    if (beosztott.Bejelentkezés(név))
                    {
                        dolgozo = beosztott;
                        Console.WriteLine("Üdvözlöm beosztott!");
                        dolgozo.Info();
                        break;
                    }
                }
            }
            if (dolgozo == null)
                Console.WriteLine("Sikertelen bejelentkezés! Adja meg a nevét:");
        }
        public Ügyfél getÜgyfél(int azonosító)
        {
            Ügyfél res = null;
            foreach (Ügyfél ügyfél in ügyfélLista)
            {
                if(ügyfél.azonosító == azonosító)
                {
                    res = ügyfél;
                    break;
                }
            }
            return res;
        }

        public Beosztott getBeosztott(int azonosító)
        {
            Beosztott res = null;
            foreach (Beosztott beosztott in beosztottLista)
            {
                if (beosztott.azonosító == azonosító)
                {
                    res = beosztott;
                    break;
                }
            }
            return res;
        }


    }
}
