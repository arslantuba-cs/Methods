using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
      
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string urunAciklama,double urunFiyat,int stokAdedi)//stok adedi sonradan eklendi.
        {
            Console.WriteLine("Sepete eklendi : "+ urunAdi);
        }
    }
}
