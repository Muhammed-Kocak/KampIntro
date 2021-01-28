using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(urun.Adi + " : " + urun.Fiyati + " TL " + " | " + urun.Aciklama);
            }
            Console.WriteLine("-------------------");


            Console.WriteLine("-----------------------------------------METOTLAR---------------------------------------------");

            //instance - örnek oluşturduk
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12,10);
            sepetManager.Ekle2("Elma","Yeşil elma",12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu",12,8);


            
        }
    }
}



//Metotlar tekrarlanan kodları sürekli çağırarak kullanmamızı sağlıyor.
//Don't repeat yourself.  -  DRY  - Clean Code  - Best Practice