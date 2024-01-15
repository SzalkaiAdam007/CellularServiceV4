using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal abstract class Dolgozó
    {

        public string név { get; set; }
        public string cím { get; set; }
        public string telefon { get; set; }

        public Dolgozó(string név, string cím, string telefon)
        {
            this.név = név;
            this.cím = cím;
            this.telefon = telefon;
        }

        public abstract bool Bejelentkezés(String név);
        public abstract bool Input(string input, Szolgáltató szolgáltató);
        public abstract void Info();

    }
}