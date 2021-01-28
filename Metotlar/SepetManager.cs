using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //notlarda (1) numara olan not buraya bağlıdır..

            //naming convention
            //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. "+ urun.Adi + " Sepete eklendi!");

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {

            Console.WriteLine("Tebrikler. " + urunAdi + " Sepete eklendi!");
        }
    }
}
