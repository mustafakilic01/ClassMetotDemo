using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi !!! : " + musteri.Adi +" "+ musteri.Soyadi);
        }
        public void Ekle2(Musteri musteri)
        {
            Console.WriteLine("Bir müşteri hesabını sildirdi !!! : " + musteri.Adi +" "+ musteri.Soyadi);
        }





    }
}
