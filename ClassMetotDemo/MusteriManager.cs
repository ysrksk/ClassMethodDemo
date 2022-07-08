using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi :" + musteri.MusteriAdi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi :" + musteri.MusteriAdi);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi :" + musteri.MusteriAdi);
        }
    }
}
