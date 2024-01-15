using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás 
{

    internal class Főnök : Szolgáltató
    {
        protected string név { get; set; }
        public string beosztás { get; set; }
        public override string Bejelentkezés()
        {
            return "kutya";
        }
        public string BeokLekérdezése()
        {
            return "kutya";
        }


    }
}
