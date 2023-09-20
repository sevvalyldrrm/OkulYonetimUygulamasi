using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    internal class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public float Ortalama
        {
            get
            {
                //string sonuc1 = sayi > 0 ? "sayı 0'dan büyük" : sayi < 0 ? "sayı 0'dan küçük" : "sayı nötr";
                //double ortalama = ogrenciler.Where(a => a.Subesi == SUBE.B).Average(a => a.Yas)
                

                float a = Notlar.Count > 0 ? this.Notlar.Average(a => a.Not) : 0;
                return a;

            }


        }
        public SUBE Sube { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public Adres Adresi { get; set; }

        public DersNotu DersNot { get; set; }


        public List<string> Kitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();



    }
    public enum SUBE
    {
        Empty, A, B, C
    }
    public enum CINSIYET
    {
        Empty, Kiz, Erkek
    }



}
