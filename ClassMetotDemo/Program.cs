using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Kılıç";
            musteri1.Yasi = 21;
            musteri1.Meslegi = "Öğrenci";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Zatinur";
            musteri2.Soyadi = "Kılıç";
            musteri2.Yasi = 19;
            musteri2.Meslegi = "Ev Hanımı";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Oğuzhan";
            musteri3.Soyadi = "Karakuş";
            musteri3.Yasi = 23;
            musteri3.Meslegi = "Şoför";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Banka Müşteri Bilgileri");
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.Meslegi);
                Console.WriteLine("------------");
            }

            Console.WriteLine("--------------Müşteri Hareketleri--------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle2(musteri3);












        }
    }
}
