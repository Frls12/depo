using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _200716080_Kemal_Sener
{
    class depokont
    {
        urunler ad = new urunler();
        depo depok = new depo();

        List<urunler> urunek = new List<urunler>();

        public void urunekle(urunler urunler)
        {

            ad.en = urunler.en;
            ad.boy = urunler.boy;
            ad.yuksek = urunler.yuksek;

            urunek.Add(new urunler()
            {
                boy = urunler.boy,
                yuksek = urunler.yuksek,
                en = urunler.en
            }
            );

        }
        public urunler[] buyuksıra()
        {
            urunler[] yen = new urunler[30];
            yen = urunek.Where(p => p.hacim > 300).ToArray(); ;

            return yen;
        }
        public List<urunler> gıdadı_liste()
        {
            List<urunler> urunek_gıda = new List<urunler>();
            urunek_gıda = urunek.Where(p => p.gıda == false).ToList();
            return urunek_gıda;
        }

        public int bosluk()
        {
            return depok.mevcutkapasite;
        }
    }
}
