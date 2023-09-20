using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    // Okul sınıfı verilerine ulaşabilmek için Okul nesnesi oluşturduk

    internal class Uygulama
    {
        static Okul Okul = new Okul();
        static int secimSayaci = 0;
        public static void Calistir()
        {
           // SahteVeriGir();
            Menu();
            SecimEkrani();
            //Test();



        }


        static void SahteVeriGir()
        {
            Okul.OgrenciEkle(1, "Mehmet", "Çelik", new DateTime(2007, 12, 27), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(2, "Hasan", "Yılmaz", new DateTime(1994, 1, 16), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(3, "Fatih", "Polat", new DateTime(1996, 5, 22), CINSIYET.Kiz, SUBE.B);
            Okul.OgrenciEkle(4, "Ahmet", "Şahin", new DateTime(1990, 6, 20), CINSIYET.Erkek, SUBE.A);
            Okul.OgrenciEkle(5, "Ali", "Güneş", new DateTime(2009, 6, 7), CINSIYET.Erkek, SUBE.C);
            Okul.OgrenciEkle(6, "Ahmet", "Çelik", new DateTime(1992, 8, 1), CINSIYET.Erkek, SUBE.A);
            Okul.OgrenciEkle(7, "Murat", "Yılmaz", new DateTime(2006, 7, 19), CINSIYET.Erkek, SUBE.B);
            Okul.OgrenciEkle(8, "Murat", "Kaya", new DateTime(2003, 12, 14), CINSIYET.Kiz, SUBE.B);
            Okul.OgrenciEkle(9, "Ahmet", "Polat", new DateTime(1994, 9, 3), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(10, "Murat", "Kaya", new DateTime(2003, 11, 22), CINSIYET.Erkek, SUBE.C);
            Okul.OgrenciEkle(11, "Hüseyin", "Koç", new DateTime(2004, 1, 31), CINSIYET.Erkek, SUBE.A);
            Okul.OgrenciEkle(12, "Mehmet", "Güneş", new DateTime(2002, 8, 3), CINSIYET.Kiz, SUBE.B);
            Okul.OgrenciEkle(13, "Fatih", "Kaya", new DateTime(1992, 8, 11), CINSIYET.Erkek, SUBE.A);
            Okul.OgrenciEkle(14, "Fatih", "Polat", new DateTime(2004, 5, 18), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(15, "Osman", "Çelik", new DateTime(2009, 4, 20), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(16, "Hüseyin", "Kara", new DateTime(2005, 5, 17), CINSIYET.Kiz, SUBE.A);
            Okul.OgrenciEkle(17, "Ahmet", "Kaya", new DateTime(1991, 3, 2), CINSIYET.Erkek, SUBE.B);
            Okul.OgrenciEkle(18, "Hüseyin", "Polat", new DateTime(1994, 1, 18), CINSIYET.Kiz, SUBE.B);
            Okul.OgrenciEkle(19, "Ömer", "Şahin", new DateTime(1999, 2, 17), CINSIYET.Erkek, SUBE.C);
            Okul.OgrenciEkle(20, "Ali", "Yılmaz", new DateTime(2000, 6, 20), CINSIYET.Erkek, SUBE.B);

            Ogrenci ogr1 = new Ogrenci();
            ogr1 = Okul.OgrenciyiBul(1);
            Okul.NotEkle(1, "Fen", 15);
            Okul.NotEkle(1, "Beden", 56);
            Okul.NotEkle(1, "Türkçe", 20);

            ogr1.Adresi = new Adres("Sincan", "Seymenler", "Seymenler");
            ogr1.Kitaplar.Add("Sefiller");

            Ogrenci ogr2 = new Ogrenci();
            ogr2 = Okul.OgrenciyiBul(2);
            Okul.NotEkle(2, "Türkçe", 50);
            ogr2.Adresi = new Adres("Ankara", "Gölbaşı", "Bahçelievler");
            ogr2.Kitaplar.Add("Cinali");

            Ogrenci ogr3 = new Ogrenci();
            ogr3 = Okul.OgrenciyiBul(3);
            Okul.NotEkle(3, "Fen", 75);
            ogr3.Adresi = new Adres("Ankara", "Keçiören", "Etiler");
            ogr3.Kitaplar.Add("Siyah İnci");

            Ogrenci ogr4 = new Ogrenci();
            ogr4 = Okul.OgrenciyiBul(4);
            Okul.NotEkle(4, "Türkçe", 60);
            ogr4.Adresi = new Adres("İstanbul", "Üsküdar", "Bağlarbaşı");
            ogr4.Kitaplar.Add("Kırmızı Pazartesi");

            Ogrenci ogr5 = new Ogrenci();
            ogr5 = Okul.OgrenciyiBul(5);
            Okul.NotEkle(5, "Matematik", 70);
            ogr5.Adresi = new Adres("İzmir", "Karşıyaka", "Bostanlı");
            ogr5.Kitaplar.Add("Don Quijote");
            ogr5.Kitaplar.Add("Ayşe Tatilde");

            Ogrenci ogr6 = new Ogrenci();
            ogr6 = Okul.OgrenciyiBul(6);
            Okul.NotEkle(6, "Tarih", 85);
            ogr6.Adresi = new Adres("Bursa", "Osmangazi", "Süleymaniye");
            ogr6.Kitaplar.Add("Moby Dick");

            Ogrenci ogr7 = new Ogrenci();
            ogr7 = Okul.OgrenciyiBul(7);
            Okul.NotEkle(7, "Coğrafya", 88);
            ogr7.Adresi = new Adres("Antalya", "Muratpaşa", "Altındağ");
            ogr7.Kitaplar.Add("Iliad");
            ogr7.Kitaplar.Add("Ulysses");

            Ogrenci ogr8 = new Ogrenci();
            ogr8 = Okul.OgrenciyiBul(8);
            Okul.NotEkle(8, "Kimya", 92);
            ogr8.Adresi = new Adres("Eskişehir", "Odunpazarı", "Vişnelik");
            ogr8.Kitaplar.Add("Bülbülü Öldürmek");

            Ogrenci ogr9 = new Ogrenci();
            ogr9 = Okul.OgrenciyiBul(9);
            Okul.NotEkle(9, "Biyoloji", 75);
            ogr9.Adresi = new Adres("Trabzon", "Ortahisar", "Kemerkaya");
            ogr9.Kitaplar.Add("1984");

            Ogrenci ogr10 = new Ogrenci();
            ogr10 = Okul.OgrenciyiBul(10);
            Okul.NotEkle(10, "Matematik", 85);
            ogr10.Adresi = new Adres("Gaziantep", "Şahinbey", "Gazimuhtarpaşa");
            ogr10.Kitaplar.Add("Hayvan Çiftliği");

            Ogrenci ogr11 = new Ogrenci();
            ogr11 = Okul.OgrenciyiBul(11);
            Okul.NotEkle(11, "Fizik", 90);
            ogr11.Adresi = new Adres("İzmir", "Konak", "Alsancak");
            ogr11.Kitaplar.Add("Körleşme");

            Ogrenci ogr12 = new Ogrenci();
            ogr12 = Okul.OgrenciyiBul(12);
            Okul.NotEkle(12, "Edebiyat", 80);
            ogr12.Adresi = new Adres("Ankara", "Çankaya", "Kızılay");
            ogr12.Kitaplar.Add("Saatleri Ayarlama Enstitüsü");

            Ogrenci ogr13 = new Ogrenci();
            ogr13 = Okul.OgrenciyiBul(13);
            Okul.NotEkle(13, "Tarih", 85);
            ogr13.Adresi = new Adres("Konya", "Meram", "Selçuklu");
            ogr13.Kitaplar.Add("Aylak Adam");

            Ogrenci ogr14 = new Ogrenci();
            ogr14 = Okul.OgrenciyiBul(14);
            Okul.NotEkle(14, "Coğrafya", 88);
            ogr14.Adresi = new Adres("Antalya", "Konyaaltı", "Limbağ");
            ogr14.Kitaplar.Add("Tutunamayanlar");

            Ogrenci ogr15 = new Ogrenci();
            ogr15 = Okul.OgrenciyiBul(15);
            Okul.NotEkle(15, "Kimya", 92);
            ogr15.Adresi = new Adres("Mersin", "Toroslar", "Gündoğdu");
            ogr15.Kitaplar.Add("Kürk Mantolu Madonna");

            Ogrenci ogr16 = new Ogrenci();
            ogr16 = Okul.OgrenciyiBul(16);
            Okul.NotEkle(16, "Biyoloji", 75);
            ogr16.Adresi = new Adres("Kayseri", "Melikgazi", "Talas");
            ogr16.Kitaplar.Add("İnsan Ne İle Yaşar");

            Ogrenci ogr17 = new Ogrenci();
            ogr17 = Okul.OgrenciyiBul(17);
            Okul.NotEkle(17, "Matematik", 85);
            ogr17.Adresi = new Adres("Denizli", "Pamukkale", "Kınıklı");
            ogr17.Kitaplar.Add("Dava");

            Ogrenci ogr18 = new Ogrenci();
            ogr18 = Okul.OgrenciyiBul(18);
            Okul.NotEkle(18, "Fizik", 90);
            ogr18.Adresi = new Adres("Mardin", "Artuklu", "Dara");
            ogr18.Kitaplar.Add("Kuyucaklı Yusuf");

            Ogrenci ogr19 = new Ogrenci();
            ogr19 = Okul.OgrenciyiBul(19);
            Okul.NotEkle(19, "Edebiyat", 80);
            ogr19.Adresi = new Adres("Şanlıurfa", "Haliliye", "Divanyolu");
            ogr19.Kitaplar.Add("Yaban");

            Ogrenci ogr20 = new Ogrenci();
            ogr20 = Okul.OgrenciyiBul(20);
            Okul.NotEkle(20, "Tarih", 85);
            ogr20.Adresi = new Adres("Erzurum", "Yakutiye", "Aziziye");
            ogr20.Kitaplar.Add("Sessiz Ev");

            
        }


        static void Menu()
        {

            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine();
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20 - Öğrencinin notunu gir");
            Console.WriteLine();
            Console.WriteLine("çıkış yapmak için \"çıkış\" yazıp \"enter\"a basın.");
            
            

        }
        static string SecimAl()
        {
            if (secimSayaci != 10)
            {
                Console.WriteLine();
                Console.Write("Yapmak istediginiz islemi seçiniz: ");
                return Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                return "ÇIKIŞ";
            }

        }

        static void SecimEkrani()
        {

            while (true)
            {

                
                string secim = SecimAl();
                Console.WriteLine();

                switch (secim)
                {
                    case "1":
                        OgrenciListele();
                        break;
                    case "2":
                        OgrenciListeleSube();
                        break;
                    case "3":
                        OgrenciListeleCinsiyet();
                        break;
                    case "4":
                        OgrenciListeleDogumTarihi();
                        break;
                    case "5":
                        OgrenciListeleAdres();
                        break;
                    case "6":
                        OgrenciNotlariListele();
                        break;
                    case "7":
                        OgrenciKitaplariListele();
                        break;
                    case "8":
                        OgrenciListeleYuksekBes();
                        break;
                    case "9":
                        OgrenciListeleDusukUc();
                        break;
                    case "10":
                        OgrenciListeleSubeEnYuksekBes();
                        break;
                    case "11":
                        OgrenciListeleSubeEnDusukUc();
                        break;
                    case "12":
                        OgrenciNotOrtalamasi();
                        break;
                    case "13":
                        SubeNotOrtalamasi();
                        break;
                    case "14":
                        SonKitap();
                        break;
                    case "15":
                        OgrenciEkle();
                        break;
                    case "16":
                        OgrenciGuncelle();
                        break;
                    case "17":
                        OgrenciSil();
                        break;
                    case "18":
                        AdresGir();
                        break;
                    case "19":
                        KitapEkle();
                        break;
                    case "20":
                        NotGir();
                        break;
                    case "liste":
                    case "LİSTE"://calismasi lazim
                        Menu();                         
                        break;
                    case "ÇIKIŞ":
                    case "cikis":
                    case "çıkış":
                        Cikis();
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.\n");
                        secimSayaci++;
                        break;
                
                }
                Console.WriteLine() ;
                Console.WriteLine("Menüyü tekrar listelemek için \"liste\", çıkış yapmak için \"çıkış\" yazın.");
            }

        }
        static void OgrenciListele()
        {
            Console.WriteLine("1-Bütün Ögrencileri Listele --------------------------------------------------\n");
            if (Okul.Ogrenciler.Count > 0)
            {
                Console.WriteLine("Sube".PadRight(10)+"No".PadRight(10)+"Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(20) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci item in Okul.Ogrenciler.OrderBy(t => t.No))
                {
                    Console.WriteLine(item.Sube + "".PadRight(10) + (item.No + "").PadRight(8) + (item.Ad + " " +item.Soyad).PadRight(20)  + (item.Ortalama + "").PadRight(25) + item.Kitaplar.Count);
                }
            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }

             
        }
        static void OgrenciListeleSube()
        {
            Console.WriteLine("2-Subeye Göre Ögrencileri Listele --------------------------------------------");
            if (Okul.Ogrenciler.Count > 0)
            {
                SUBE hangisi = new SUBE();
                hangisi = SubeSor("Listelemek istediğiniz şubeyi girin (A/B/C): ");
                List<Ogrenci> liste = Okul.Ogrenciler.Where(t => t.Sube == hangisi).OrderBy(t => t.No).ToList();
                Console.WriteLine();
                Console.WriteLine("Sube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(20) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine(item.Sube.ToString().PadRight(10) + (item.No.ToString().PadRight(10) + (item.Ad + " " + item.Soyad).PadRight(22) + (item.Ortalama.ToString()).PadRight(25) + item.Kitaplar.Count.ToString().PadRight(15)));
                }

            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }

        }
        static void OgrenciListeleCinsiyet()
        {
            Console.WriteLine("3-Cinsiyete Göre Öğrencileri Listele -----------------------------------------");
            CINSIYET hangisi = CinsiyetSor("Listelemek istediğiniz cinsiyeti girin (K/E): ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(t => t.Cinsiyet == hangisi).OrderBy(t => t.No).ToList();
            Console.WriteLine();
            
            if (liste.Count > 0)
            {
                Console.WriteLine("Sube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(20) + "Not Ort.".PadRight(20) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad).PadRight(22) + (item.Ortalama.ToString()).PadRight(25) + item.Kitaplar.Count);
                }
            }
            else
            {
                
                Console.WriteLine("Listelenecek ögrenci yok.");
                
            }
        }
        static void OgrenciListeleDogumTarihi()
        {
            Console.WriteLine("4-Dogum Tarihine Göre Ögrencileri Listele ------------------------------------");
            DateTime tarih = AracGerecler.TarihAl("Hangi tarihten sonraki ögrencileri listelemek istersiniz: ");
            List<Ogrenci> liste = Okul.Ogrenciler.Where(t => t.DogumTarihi > tarih).OrderBy(t => t.No).ToList();
            if (liste.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad).PadRight(25) + (item.Ortalama.ToString()).PadRight(25) + item.Kitaplar.Count);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Listelenecek ögrenci yok.");
                
            }

        }
        static void OgrenciListeleAdres()//adres girdikten sonra dene
        {
            Console.WriteLine("5-Illere Göre Ögrencileri Listele --------------------------------------------\n");
            if (Okul.Ogrenciler.Count > 0)
            {
                Console.WriteLine("Sube      No        Adı Soyadı           Sehir           Semt");
                Console.WriteLine("-------------------------------------------------------------------------------");
                List<Ogrenci> liste = Okul.Ogrenciler.OrderBy(t => t.Adresi.Il).ToList();
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad).PadRight(21) + (item.Adresi.Il).PadRight(16) + item.Adresi.Ilce);
                }
            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }

        }
        static void OgrenciNotlariListele()//denenmesi lazim
        {
            Console.WriteLine("6-Ögrencinin notlarını görüntüle ---------------------------------------------");
            if (Okul.Ogrenciler.Count > 0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);
               
                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();



                if (o1.Notlar.Count > 0)
                {
                    Console.WriteLine("Dersin Adi     Notu");
                    Console.WriteLine("--------------------");
                    

                    foreach (DersNotu item in o1.Notlar)
                    {
                        Console.WriteLine((item.DersAdi.ToString()).PadRight(15) + item.Not);
                        
                    }
                }
                else
                {
                    Console.WriteLine("Öğrenciye ait bir not bulunmamaktadır");

                }

            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }

        }
        static void OgrenciKitaplariListele()//denenmesi lazim 
        {
            Console.WriteLine("7-Ögrencinin okudugu kitapları listele ---------------------------------------");
            if (Okul.Ogrenciler.Count > 0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Console.WriteLine();
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);
                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();
                Console.WriteLine("Okudugu Kitaplar");
                Console.WriteLine("-----------------");
                foreach (string item in o1.Kitaplar)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");//hocanin programinda yok fakat kimse olmadiginda program hata verior
            }


        }
        static void OgrenciListeleYuksekBes()//ortalama get yazilmasi lazim
        {
            Console.WriteLine("8-Okuldaki en basarılı 5 ögrenciyi listele -----------------------------------");
            if (Okul.Ogrenciler.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
                Console.WriteLine("-------------------------------------------------------------------------------");
                List<Ogrenci> liste = Okul.Ogrenciler.OrderByDescending(a => a.Ortalama).Take(5).ToList();
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad.ToString()).PadRight(27) + (item.Ortalama.ToString()).PadRight(0) + item.Kitaplar.Count);
                }
            }
            else
            {
                Console.WriteLine("Listelenecek ögrenci yok.");
            }




        }
        static void OgrenciListeleDusukUc()//dene
        {
            Console.WriteLine("9-Okuldaki en basarısız 3 ögrenciyi listele ----------------------------------");
            if (Okul.Ogrenciler.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
                Console.WriteLine("-------------------------------------------------------------------------------");
                List<Ogrenci> liste = Okul.Ogrenciler.OrderBy(a => a.Ortalama).Take(3).ToList();
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad.ToString()).PadRight(25) + (item.Ortalama.ToString()).PadRight(20) + item.Kitaplar.Count);
                }
            }
            else
            {
                Console.WriteLine("Listelenecek ögrenci yok.");
            }


        }
        static void OgrenciListeleSubeEnYuksekBes()//dene
        {
            Console.WriteLine("10-Subedeki en basarılı 5 ögrenciyi listele -----------------------------------");

            SUBE sube = SubeSor("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            Console.WriteLine();
            List<Ogrenci> liste = Okul.Ogrenciler.Where(a => a.Sube == sube).OrderByDescending(a => a.Ortalama).Take(5).ToList();
            if (liste.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
                Console.WriteLine("-------------------------------------------------------------------------------");

                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad.ToString()).PadRight(28) + (item.Ortalama.ToString()).PadRight(18) + item.Kitaplar.Count);
                }
            }
            else
            {
                Console.WriteLine("Listelenecek ögrenci yok.");
            }


        }
        static void OgrenciListeleSubeEnDusukUc()//dene
        {
            Console.WriteLine("11-Subedeki en basarısız 3 ögrenciyi listele ----------------------------------");

            SUBE sube = SubeSor("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            Console.WriteLine();
            List<Ogrenci> liste = Okul.Ogrenciler.Where(a => a.Sube == sube).OrderBy(a => a.Ortalama).Take(3).ToList();
            if (liste.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Sube      No        Adı Soyadı               Not Ort.       Okuduğu Kitap Say.");
                Console.WriteLine("-------------------------------------------------------------------------------");

                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine((item.Sube.ToString()).PadRight(10) + (item.No.ToString()).PadRight(10) + (item.Ad + " " + item.Soyad.ToString()).PadRight(25) + (item.Ortalama.ToString()).PadRight(22) + item.Kitaplar.Count);
                }
            }
            else
            {
                Console.WriteLine("Listelenecek ögrenci yok.");
            }


        }
        static void OgrenciNotOrtalamasi()//dene
        {
            Console.WriteLine("12-Ögrencinin Not Ortalamasını Gör ----------------------------------");
            if (Okul.Ogrenciler.Count > 0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);
                Console.WriteLine();
                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();
                Console.WriteLine("Ögrencinin not ortalaması: " + o1.Ortalama);
            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }

        }
        static void SubeNotOrtalamasi()//dene
        {
            Console.WriteLine("13-Şubenin Not Ortalamasını Gör -------------------------------------");

            SUBE sube = SubeSor("Bir şube seçin (A/B/C): ");
            
            Console.WriteLine();
            List<Ogrenci> liste = Okul.Ogrenciler.Where(a => a.Sube == sube).ToList();
            if(liste.Count > 0)
            {
                double siniftoplam = liste.Sum(a => a.Ortalama);
                double notOrtalamasi = siniftoplam / liste.Count;
                Console.WriteLine(sube + " subesinin not ortalaması: " + notOrtalamasi);
            }
            else { Console.WriteLine("Sınıfta öğrenci yok. "); }
            
        }
        static void SonKitap()//dene
        {
            Console.WriteLine("14-Ögrencinin okudugu son kitabı listele ----------------------------");
            if(Okul.Ogrenciler.Count > 0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);
                Console.WriteLine();
                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();
                if (o1.Kitaplar.Count > 0)
                {
                    Console.WriteLine("Ögrencinin Okudugu Son Kitap");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine(o1.Kitaplar.LastOrDefault());
                }
                else
                {
                    Console.WriteLine("Öğrencinin okuduğu herhangi bir kitap bulunmamaktadır.");
                }
            }
            else
            {
                Console.WriteLine("Listelenecek öğrenci yok. ");
            }
            


            
        }
        

        static void OgrenciEkle()
        {
            int gecicino = 1;
            bool kosul = false;
            Ogrenci o1 = new Ogrenci();
            Ogrenci o2 = new Ogrenci();
            Console.WriteLine("15-Öğrenci Ekle -----------------------------------------------------");
            int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");


            o1 = Okul.Ogrenciler.Where(t => t.No == no).FirstOrDefault();
            //o1 = Okul.OgrenciyiBul(no);
            if (o1 != null)
            {


                //gecicino = o1.No;

                // List<int> ogrenciNumaralari = Okul.Ogrenciler.Select(o => o.No).ToList();

                List<int> ogrenciNumaralari = new List<int>();
                foreach (Ogrenci item in Okul.Ogrenciler)
                {
                    ogrenciNumaralari.Add(item.No);
                }
                gecicino = AracGerecler.EnKucukSayiyiBul(ogrenciNumaralari);
                o2.No = gecicino;

                kosul = true;
            }
            else
            {
                o2.No = no;
            }


            o2.Ad = AracGerecler.HarfAl("Ögrencinin adı: ");
            o2.Soyad = AracGerecler.HarfAl("Ögrencinin soyadı: ");
            o2.DogumTarihi = AracGerecler.TarihAl("Ögrencinin dogum tarihi: ");
            o2.Cinsiyet = CinsiyetSor("Ögrencinin cinsiyeti (K/E): ");
            o2.Sube = SubeSor("Ögrencinin subesi (A/B/C): ");
            Console.WriteLine();
            Console.WriteLine(o2.No + " numaralı ögrenci sisteme basarılı bir sekilde eklenmistir.");
            Okul.OgrenciEkle(o2.No, o2.Ad, o2.Soyad, o2.DogumTarihi, o2.Cinsiyet, o2.Sube);
            if (kosul)
            {
                Console.WriteLine("Sistemde " + o1.No + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + o2.No + " olarak değiştirildi.");
            }


        }
        static void OgrenciGuncelle()
        {
            Console.WriteLine("16-Ögrenci Güncelle -----------------------------------------------------------");
            //try
            // {
            if(Okul.Ogrenciler.Count > 0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);

                o1.Ad = AracGerecler.HarfAl("Ögrencinin adı: ");
                o1.Soyad = AracGerecler.HarfAl("Ögrencinin soyadı: ");
                o1.DogumTarihi = AracGerecler.TarihAl("Ögrencinin dogum tarihi: ");
                o1.Cinsiyet = CinsiyetSor("Ögrencinin cinsiyeti (K/E): ");
                o1.Sube = SubeSor("Ögrencinin subesi (A/B/C): ");

                Console.WriteLine();
                Console.WriteLine("Ogrenci güncellendi.");
                Console.WriteLine();
            }else { Console.WriteLine("Listede güncellenecek ögrenci yok."); }
            



            // }
            // catch (Exception e)
            // {
            //Console.WriteLine(e.Message);

            // }



        }
        static void OgrenciSil()
        {
            Console.WriteLine("17-Ögrenci sil ----------------------------------------------------------------");
            // try
            // {
            if(Okul.Ogrenciler.Count>0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Console.WriteLine();
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);

                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();
                Console.Write("Ögrenciyi silmek istediginize emin misiniz (E/H): ");
                string ifade = Console.ReadLine().ToUpper();
                if (ifade == "E")
                {
                    Okul.Ogrenciler.Remove(o1);
                    Console.WriteLine("Ögrenci basarılı bir sekilde silindi.");
                }
            }
            
            else { Console.WriteLine("Listede silinecek ögrenci yok."); }

            // }
            // catch (Exception e)
            // {
            //    Console.WriteLine(e.Message);

            //}


        }
        static void AdresGir()
        {
            Console.WriteLine("18-Ögrencinin Adresini Gir ------------------------------------------");
            //try
            // {
            if(Okul.Ogrenciler.Count > 0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);

                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();

                string il = AracGerecler.HarfAl("Il: ");

                string ilce = AracGerecler.HarfAl("Ilce: ");

                string mahalle = AracGerecler.HarfAl("Mahalle: ");

                o1.Adresi = new Adres(il, ilce, mahalle);
                Console.WriteLine();
                Console.WriteLine("Bilgiler sisteme girilmistir.");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Listede ögrenci yok.");
            }


            // }
            // catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);

            // }
        }
        static void KitapEkle()
        {
            Console.WriteLine();
            Console.WriteLine("19-Ögrencinin okudugu kitabı gir ------------------------------------");
            //try
            //{
            if(Okul.Ogrenciler.Count>0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Console.WriteLine();
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);
                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();
                Console.Write("Eklenecek Kitabin Adı: ");
                string kitap = Console.ReadLine();
                o1.Kitaplar.Add(kitap);
                Console.WriteLine("Bilgiler sisteme girilmistir.");
            }
            else { Console.WriteLine("Listede ögrenci yok."); }
            

            //}
            // catch (Exception e)
            //{
            // Console.WriteLine(e.Message);

            // }

        }
        static void NotGir()
        {

            Console.WriteLine("20-Not Gir ----------------------------------------------------------");

            // try
            //{
            if (Okul.Ogrenciler.Count>0)
            {
                int no = AracGerecler.SayiAl("Ögrencinin numarasi: ");
                Console.WriteLine();
                Ogrenci o1 = new Ogrenci();
                o1 = Okul.OgrenciyiBul(no);


                Console.WriteLine("Ögrencinin Adı Soyadı: " + o1.Ad + " " + o1.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + o1.Sube);
                Console.WriteLine();
                Console.Write("Not eklemek istediğiniz dersi giriniz: ");
                string ders = Console.ReadLine();


                int adet = AracGerecler.SayiAl("Eklemek istediginiz not adedi:");
                for (int i = 1; i <= adet; i++)
                {

                    int not = AracGerecler.SayiAl(i + ". notu girin: ");
                    Okul.NotEkle(no, ders, not);
                    if (i == adet)
                    {
                        Console.WriteLine("Bilgiler sisteme girilmistir.");


                    }

                }
            }
            else { Console.WriteLine("Listede ögrenci yok. "); }
            

            //}
            // catch (Exception e)
            //{
            // Console.WriteLine(e.Message);

            // }

        }
        static void Cikis()
        {
            Environment.Exit(0);
        }
        static void ListeMiCikisMi()
        {
            Console.WriteLine();
            Console.WriteLine("Menüyü tekrar listelemek için \"liste\", çıkış yapmak için \"çıkış\" yazın.");
            Console.WriteLine();
            do
            {
                Console.Write("Yapmak istediginiz islemi seçiniz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "Liste":
                    case "liste":
                        Menu();
                        SecimAl(); break;
                    case "ÇIKIŞ":
                    case "cikis":
                    case "çıkış":
                        Cikis();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        Console.WriteLine(); break;
                }


            } while (true);


        }

        static CINSIYET CinsiyetSor(string soruMetni)
        {
            CINSIYET cns;
            do
            {
                Console.Write(soruMetni);
                string cinsiyet = Console.ReadLine().ToUpper();
                if (cinsiyet == "K")
                {
                    cns = CINSIYET.Kiz; break;
                }
                else if (cinsiyet == "E")
                {
                    cns = CINSIYET.Erkek; break;
                }
                else
                {
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                }

            } while (true);
            return cns;
        }
        static SUBE SubeSor(string soruMetni)
        {
            
          
            do
            {
                
                Console.Write(soruMetni);
                string sube = Console.ReadLine().ToUpper();

                /* if (sube == "A")
                 {
                     hangisi = SUBE.A; break;
                 }
                 else if (sube == "B")
                 {
                     hangisi = SUBE.B; break;
                 }
                 else if (sube == "C")
                 {
                     hangisi = SUBE.C; break;
                 }
                 else
                 {
                     Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                 }*/
                switch (sube)
                {
                    case "A":
                        
                           return  SUBE.A; 
                        
                    case "B":
                        
                            return SUBE.B;  

                    case "C":
                        
                           return SUBE.C;  
                    default:
                        Console.WriteLine("Hatali giris yapildi. Tekrar deneyin"); break;
                }

            } while (true);
           
        }
        static void OgrenciListesiYazdir(List<Ogrenci> list)// doldurulabilir
        {

        }
        static void Test()
        {
            Console.WriteLine(Okul.Ogrenciler.Count);

        }
    }

}


