using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 68;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi + ": " + urun.Fiyati + " tl : " + urun.Aciklama);
            }

            Console.WriteLine("------------Metotlar--------------");

            // instance - örnek
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "köy armudu", 9,34);// stok adedi sonradan eklenen parametre olduğu için bütün sayfaları dolaşıp düzenleme yapmak zorundayız.
            sepetmanager.Ekle2("Armut", "köy armudu", 9,54);//Bu durudan kurtulmak için Product urun paraetresi kullanmak mantıklı olacaktır. Product sınıfına stok adedi parametresi eklenip sorun kısa yoldan çözülür.
            sepetmanager.Ekle2("Armut", "köy armudu", 9,32);

        }
    }
}
