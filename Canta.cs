using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepremCantasiApp
{
    public class Canta
    {
        public List<Malzeme> MalzemeListesi { get; set; }

        public Canta()
        {
            MalzemeListesi = new List<Malzeme>();
        }

        public void MalzemeEkle(Malzeme m)
        {
            MalzemeListesi.Add(m);
        }

        public void MalzemeCikar(Malzeme m)
        {
            MalzemeListesi.Remove(m);
        }

    }
}
