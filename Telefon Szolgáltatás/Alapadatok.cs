using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Szolgáltatás
{
    internal class Alapadatok
    {
        public int ÁFA { get; set; }
        public int percdíjCsúcsidőben { get; set; }
        public int percdíjEgyébIdőben { get; set; }
        public int internetSzolgáltatásDíjak { get; set; }



        public Alapadatok(int ÁFA, int percdíjCsúcsidőben, int percdíjEgyébIdőben, int internetSzolgáltatásDíjak)
        {
            this.ÁFA = ÁFA;
            this.percdíjCsúcsidőben = percdíjCsúcsidőben;
            this.percdíjEgyébIdőben = percdíjEgyébIdőben;
            this.internetSzolgáltatásDíjak = internetSzolgáltatásDíjak;

        }
    }
}
