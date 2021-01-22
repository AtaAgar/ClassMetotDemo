using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Edanur ";
            musteri1.SoyAdi = "Çetin";
            musteri1.Telefon = "05998887766";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Rabia";
            musteri2.SoyAdi = "Çetin";
            musteri2.Telefon = "05443332211";

            MusteriMenager musteri = new MusteriMenager();
            musteri.Ekle(musteri1);
            musteri.Ekle(musteri2);
            musteri.Sil(musteri2);
            musteri.Listele(musteri1);
        }
    }
}
