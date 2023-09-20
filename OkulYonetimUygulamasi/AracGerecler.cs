using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OkulYonetimUygulamasi
{
    internal class AracGerecler
    {
        public static int SayiAl(string mesaj)
        {
            int sayi;
            bool dongu = false;
            do
            {
                Console.Write(mesaj);
                string cevap = Console.ReadLine().ToUpper();
                dongu = int.TryParse(cevap, out sayi);
                if (!dongu)
                {
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                }
            } while (!dongu);
            return sayi;
        }
        public static bool HarfMi(string ifade)
        {

            foreach (char c in ifade)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static string HarfAl(string soru)
        {
            bool dongu = true;
            string ifade;
            do
            {
                Console.Write(soru);
                ifade = Console.ReadLine();
                ifade= ifade.Substring(0,1).ToUpper()+ifade.Substring(1).ToLower();
                if (HarfMi(ifade))
                {
                    dongu=false;

                }
                else
                {
                    Console.WriteLine("Hatalı islem tekrar girin.");
                }

            } while (dongu);
            return ifade;
        }
        public static DateTime TarihAl(string soru)
        {
            bool dongu = false;
            DateTime tarih = new DateTime();

            while (!dongu)
            {
                Console.Write(soru );
                string tarihStr = Console.ReadLine();

                if (DateTime.TryParseExact(tarihStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out tarih))
                {
                    // Doğru tarih formatıyla başarılı bir şekilde dönüşüm yapıldı.
                    dongu = true;
                }
                else
                {
                    Console.WriteLine("Hatalı tarih formatı girdiniz. Lütfen tekrar deneyin.");
                }
            }
            return tarih;
        }
        public static int EnKucukSayiyiBul(List<int> liste) 
        {
            liste.Sort(); // Listeyi küçükten büyüğe sıralıyoruz
            int enKucuk = 1; // Varsayılan olarak en küçük sayı 1 olarak kabul edilir
            foreach (int numara in liste)
            {
                if (numara == enKucuk)
                {
                    // Eğer listede var olan bir sayıyı bulduysak, en küçük sayıyı bir artırarak devam ediyoruz
                    enKucuk++;
                }
                
            }return enKucuk;

            
        }
    }
}


    

