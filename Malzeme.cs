using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepremCantasiApp
{
    public class Malzeme
    {
        public string Ad { get; set; }
        public int Adet { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public Malzeme(string ad, int adet)
        {
            Ad = ad;
            Adet = adet;
            EklenmeTarihi = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Ad} - {Adet} adet";
        }
    }
}
