using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                MusteriAdi = "Ahmet",
                MusteriSoyad = "Yıldız"
            };

            Musteri musteri2 = new Musteri()
            {
                MusteriAdi = "Ahmet",
                MusteriSoyad = "Yıldız"
            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSil(musteri1);

        }
    }
}
