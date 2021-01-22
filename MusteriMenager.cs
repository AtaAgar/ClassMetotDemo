using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriMenager
    {
        public void Ekle( Musteri musteri )
        {
            Console.WriteLine("Sayın " + musteri.Adi + " " + musteri.SoyAdi + ", Kaydınız Eklenmiştir. ");
        }

        public void Sil( Musteri musteri )
        {
            Console.WriteLine("Sayın " + musteri.Adi + " " + musteri.SoyAdi + ", Kaydınız Silinmiştir. ");
        }

        public void Listele( Musteri musteri )
        {
            Console.WriteLine("Sayın " + musteri.Adi + " " + musteri.SoyAdi + ", müşteri bilgileriniz aşağıdaki gibidir.");
            Console.WriteLine("Adı Soyadı: " + musteri.Adi + " " + musteri.SoyAdi );
            Console.WriteLine("Telefon numaranız: " + musteri.Telefon);
            Console.WriteLine("ID Numaranız: " + musteri.Id );

        }



    }
}
