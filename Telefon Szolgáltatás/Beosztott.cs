using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Beosztott : Dolgozó
    {

        public int azonosító;
        public string beosztás { get; set; }

        public Beosztott(int azonosító, string név, string cím, string telefon, string beosztás) : base(név, cím, telefon)
        {
            this.azonosító = azonosító;
            this.beosztás = beosztás;
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
                case "uu":
                    ÚjÜgyfél(szolgáltató);
                    res = true;
                    break;
                case "um":
                    ÜgyfélMódosítás(szolgáltató);
                    res = true;
                    break;
                case "ut":
                    ÜgyfélTörlés(szolgáltató);
                    res = true;
                    break;
                case "sz":
                    SzámlaLétrehozása(szolgáltató);
                    res = true;
                    break;
                case "st":
                    SzámlaSztornó(szolgáltató);
                    res = true;
                    break;
                case "tl":
                    TartozásLekérdezés(szolgáltató);
                    res = true;
                    break;
                case "ul":
                    ÜgyfélLekérdezés(szolgáltató);
                    res = true;
                    break;                  
                case "sl":
                    SzámlaLekérdezés(szolgáltató);
                    res = true;
                    break;
                default:
                    Info();
                    break;
            }
            return res;
        }

        public override void Info()
        {
            Console.WriteLine("uu: Új ügyfél");
            Console.WriteLine("um: Ügyfél módosítás");
            Console.WriteLine("ut: Ügyfél töltés");
            Console.WriteLine("sz: Számla létrehozás");
            Console.WriteLine("st: Számla sztornó");
            Console.WriteLine("tl: Tartozás lekérdezés");
            Console.WriteLine("ul: Ügyfél lekérdezés");
            Console.WriteLine("sl: Számla lekérdezés");

            Console.WriteLine("logout: kijelentkezés");
            Console.WriteLine("exit: kilépés a programból");
            Console.WriteLine("Kérem válasszon funkciót:");

        }               
        public void ÚjÜgyfél(Szolgáltató szolgáltató)
        {
            Console.WriteLine("Add meg a felvinni kívánt ügyfél azonosítóját: ");
            try
            {
                int azonosító = int.Parse(Console.ReadLine());
                Console.WriteLine("Adja meg az ügyfél nevét: "); 
                string név=Console.ReadLine();
                Console.WriteLine("Adja meg az ügyfél telefonszámát: ");
                string telefonszám=Console.ReadLine();
                Console.WriteLine("Adja meg az ügyfél címét: "); 
                string cím = Console.ReadLine();
                Ügyfél ügyfél=new Ügyfél(azonosító, név, telefonszám, cím, this);
                szolgáltató.ügyfélLista.Add(ügyfél);
                Console.WriteLine(ügyfél.név + " nevű ügyfél létrejött!");
            }
            catch (Exception)
            {
                Console.WriteLine("Érvénytelen azonosító formátum!");
            }
        }
        public void ÜgyfélMódosítás(Szolgáltató szolgáltató)
        {
            Console.WriteLine("Add meg a módosítani kívánt ügyfél azonosítóját: ");
            try
            {
                bool done = false;
                int azonosító = int.Parse(Console.ReadLine());
                foreach (Ügyfél ügyfél in szolgáltató.ügyfélLista)
                {
                    if (ügyfél.azonosító == azonosító)
                    {
                        Console.WriteLine("Adja meg a " + ügyfél.név + " ügyfél új címét: ");
                        string cím = Console.ReadLine();
                        ügyfél.cím = cím;
                        done = true;
                        Console.WriteLine(ügyfél.azonosító + " azonosítójú ügyfél címe módosult!");
                        break;
                    }

                }
                if (!done)
                    Console.WriteLine(azonosító + " nem található!");
            }
            catch (Exception)
            {
                Console.WriteLine("Érvénytelen azonosító formátum!");
            }
        }
        public void ÜgyfélTörlés(Szolgáltató szolgáltató)
        {
            Console.WriteLine("Add meg az törölni kívánt ügyfél azonosítóját: ");
            try
            {
                bool done = false;
                int azonosító = int.Parse(Console.ReadLine());
                foreach (Ügyfél ügyfél in szolgáltató.ügyfélLista)
                {
                    if (ügyfél.azonosító == azonosító)
                    {
                        szolgáltató.ügyfélLista.Remove(ügyfél);
                        done = true;
                        Console.WriteLine(ügyfél.azonosító + " azonosítójú ügyfél dezintegrálva!");
                        break;
                    }

                }
                if (!done)
                    Console.WriteLine(azonosító + " nem található!");
            }
            catch (Exception)
            {
                Console.WriteLine("Érvénytelen azonosító formátum!");
            }
        }
        public void SzámlaLétrehozása(Szolgáltató szolgáltató)
        {
            Console.WriteLine("Add meg a felvinni kívánt számla azonosítóját: ");
            try
            {
                int azonosító = int.Parse(Console.ReadLine());
                Console.WriteLine("Adja meg az ügyfél azonosítóját: ");
                int ugyfelazon = int.Parse(Console.ReadLine());
                Ügyfél ugyfel = szolgáltató.getÜgyfél(ugyfelazon);
                if (ugyfel != null) {
                    Console.WriteLine("Adja meg az számla összegét: ");
                    int összeg = int.Parse(Console.ReadLine());
                    Számla számla = new Számla(azonosító, ugyfel, összeg, false);
                    szolgáltató.számlaLista.Add(számla);
                    Console.WriteLine(számla.azonosító + " azonosítóval, " + ugyfel.név + " nevű ügyfélhez létrejött a számla!");
                }
                else {
                    Console.WriteLine(ugyfelazon + " azonosítójú ügyfél nem létezik!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Érvénytelen formátum!");
            }
        }
        public void SzámlaSztornó(Szolgáltató szolgáltató)
        {
            Console.WriteLine("Kérem adja meg a sztornózandó számla azonosítóját :");
            try
            {
                bool done = false;
                int azonosító = int.Parse(Console.ReadLine());
                foreach (Számla számla in szolgáltató.számlaLista)
                {
                    if (számla.azonosító == azonosító)
                    {
                        számla.SztornóSzámla();
                        done = true;
                        Console.WriteLine(számla.azonosító + " azonosítójú számla sztornózva!");
                        break;
                    }

                }
            if(! done)
                    Console.WriteLine(azonosító + " nem található!");
            }
            catch (Exception)
            {
                Console.WriteLine("Érvénytelen azonosító formátum!");
            }
        }

        public void TartozásLekérdezés(Szolgáltató szolgáltató)
        {
            foreach (Számla számla in szolgáltató.számlaLista)
            {
                if((számla.befizetve == false) && (számla.sztornó == false))
                    Console.WriteLine("Azonosító: " + számla.azonosító + ", Dátum: " + számla.dátum + ", Befizetve: " + számla.befizetve + ", összeg: " + számla.összeg + ", Sztornó: " + számla.sztornó);
            }
        }
        public void ÜgyfélLekérdezés(Szolgáltató szolgáltató)
        {
            foreach (Ügyfél ügyfél in szolgáltató.ügyfélLista)
            {
                Console.WriteLine("Azonosító: " + ügyfél.azonosító + ", Név: " + ügyfél.név + ", Cím: " + ügyfél.cím + ", kapcsolattartó: " + ügyfél.kapcsolattartó.név + ", Telszám: " + ügyfél.telefon);
            }
        }
        public void SzámlaLekérdezés(Szolgáltató szolgáltató)
        {
            foreach (Számla számla in szolgáltató.számlaLista)
            {
                // if (számla.sztornó == false)
                    Console.WriteLine("Ügyfél név: " + számla.ügyfél.név + ", Azonosító: " + számla.azonosító + ", Dátum: " + számla.dátum + ", Befizetve: " + számla.befizetve + ", összeg: " + számla.összeg + ", Sztornó: " + számla.sztornó);
            }
        }

    }
}
