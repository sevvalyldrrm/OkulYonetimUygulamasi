using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    internal class Okul
    {
        // Okula ait herhangi bir bilginin değiştirilmesi işlemleri bu sınıfta yapılacak.

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            Ogrenci o = new Ogrenci();

            o.Ad = ad;
            o.No = no;
            o.Soyad = soyad;
            o.DogumTarihi = dogumTarihi;
            o.Cinsiyet = cinsiyet;
            o.Sube = sube;
            this.Ogrenciler.Add(o);

        }

        public void NotEkle(int no, string ders, int not)
        {
            Ogrenci o = new Ogrenci();
            o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                o.Notlar.Add(new DersNotu(ders, not));
            }
        }       
        public Ogrenci OgrenciyiBul(int no)
        {
            bool dongu = true;
            Ogrenci o1 = new Ogrenci();

            do
            {
                o1 = this.Ogrenciler.Where(t => t.No == no).FirstOrDefault();

                if(o1 != null)
                {
                    dongu= false;
                }
                else
                {
                    Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");
                     no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                }
                

            } while (dongu);
           
            return o1;
        }



    }
}
