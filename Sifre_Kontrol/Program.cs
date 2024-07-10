using System;

namespace sifre_guvenlik
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Şifre Güvenlik Kontrolü");       //  ekranda ilk olarak cikmaini istedigim yazilari yukledim
            Console.Write("Lütfen Şifrenizi Girin :");
            string sifre = Console.ReadLine();

            int toplamKarakter = 0,  toplamPuan = 0;
            string mesaj = "";

            char[] harf = sifre.ToCharArray();                  //parametre olarak gelen şifrenin her bir karakterini char şeklinde diziye çevirip o dizi içindeki harfleri tek tek kontrol etmek için döngüye soktum.


            foreach (var item in harf)      // harfler içinde boşluk varmı diye kontrolü yaptirdim.
            {
               
                if(item == ' ')
                {
                    mesaj = "Şifreniz içerisinde boşluk kullanımı yapamazsınız !";
                }
                
                toplamKarakter++;
            }


            
            if (toplamKarakter  < 9)        // şifrenin 9 karakterden küçük olup olmadığı kontrol ettirdim.
            {
                mesaj += "\nŞifreniz 9 karakterden az olamaz !";        // satırlar karışmaması icin "\n" kullandım(kullanıcının özellikle karistirmadan görmesinin istedigm satırlara da ekledim)
            }
            else
            {
                
                if(BuyukHarfSayisi(sifre) == 0)     // Şifredeki büyük harf sayısının 0 olup olmadığı kontrol etirdim.
                {
                    mesaj += "\nŞifreniz içinde en az 1 büyük harf kullanmalısınız !";
                }
               
                else if (KucukHarfSayisi(sifre) == 0)        // Şifredeki küçük harf sayısının 0 olup olmadığı kotrol ediliyor.
                {
                    mesaj += "\nŞifreniz içinde en az 1 küçük harf kullanmalısınız !";
                }
                
                else if (RakamSayisi(sifre) == 0)       // Şifredeki rakam sayısının 0 olup olmadığı kotrol ettirdim.
                {
                    mesaj += "\nŞifreniz içinde en az 1 rakam kullanmalısınız !";
                }
                
                else if (OzelKarakterSayisi(sifre) == 0 )    // Şifredeki özel karakter sayısının 0 olup olmadığı kotrol ettirdim..
                {
                    mesaj += "\nŞifreniz içinde en az 1 özel karakter kullanmalısınız !";
                }

                else        // Şifrede karakter sayılarında 0 yok ise 
                {
                    toplamPuan = 10;
                   
                    if(BuyukHarfSayisi(sifre) == 1)      // büyük harf sayısının 1 tane mi daha fazlamı kontorlü yapılıp toplamPuan değişkenine ona göre puan ekleniyor.
                    {
                        toplamPuan += 10;
                    }
                    else
                    {
                        toplamPuan += 20;
                    }

                    
                    if (KucukHarfSayisi(sifre) == 1)        // küçük harf sayısının 1 tane mi daha fazlamı kontorlü yapılıp toplamPuan değişkenine ona göre puan ekleniyor.
                    {
                        toplamPuan += 10;
                    }
                    else
                    {
                        toplamPuan += 20;
                    }

                    
                    if (RakamSayisi(sifre) == 1)        // rakam sayısının 1 tane mi daha fazlamı kontorlü yapılıp toplamPuan değişkenine ona göre puan ekleniyor.
                    {
                        toplamPuan += 10;
                    }
                    else
                    {
                        toplamPuan += 20;
                    }
                    
                    toplamPuan += 10* OzelKarakterSayisi(sifre);


                    
                    if(toplamPuan >= 100)       // toplamPuan değişkeni 100 e eşit yada daha büyükse puan 100 e eşitlenip mesaj verilsin.100 den buyuk olması mantikli olmadigi icin boyle bir islem yaptirdim.
                    {
                        toplamPuan = 100;
                        mesaj = "\nŞifreniz çok güçlü ve kabul edilebilir. Şifre Puanınız ...: " + toplamPuan;
                    }
                   
                    else if (toplamPuan >= 90 && toplamPuan <= 100)      // toplamPuan değişkeni 90 ile 100 arasındamı kontrol edilip mesaj verilsin..
                    {
                        mesaj = "\nŞifreniz çok güçlü ve kabul edilebilir. Şifre Puanınız ...: " + toplamPuan;
                    }
                   
                    else if (toplamPuan >= 70 && toplamPuan < 90)        // toplamPuan değişkeni 70 ile 90 arasındamı kontrol edilip mesaj verilsin..
                    {
                        mesaj = "\nŞifreniz kabul edilebilir. Şifre Puanınız ...: " + toplamPuan;
                    }

                    else        // toplamPuan değişkeni 70den küçükse mesaj verilsin.
                    {
                        mesaj += "\nŞifreniz güvenli değil! Şifre Puanınız ...: " + toplamPuan;
                    }
                }
            }


            Console.WriteLine("Girilen Şifre : " + sifre);
            Console.WriteLine("Toplam Karakter Sayısı : " + toplamKarakter);
            Console.WriteLine("Toplam Büyük Harf Sayısı : " + BuyukHarfSayisi(sifre));
            Console.WriteLine("Toplam Küçük Harf Sayısı : " + KucukHarfSayisi(sifre));
            Console.WriteLine("Toplam Rakam Sayısı : " + RakamSayisi(sifre));
            Console.WriteLine("Toplam Özel Karakter Sayısı : " + OzelKarakterSayisi(sifre));
            Console.WriteLine(mesaj);
            Console.ReadKey();
        }

        static int BuyukHarfSayisi(string sifre)
        {
            int buyukHarfSayisi = 0;
            char[] strSifre = sifre.ToCharArray();
            foreach (var harf in strSifre)
            {
                //parametre olarak gelen şifrenin her bir karakterini char şeklinde diziye çevirip o dizi içindeki harfleri tek tek kontrol etmek için döngüye soktum.
                
                //döngüden gelen harf değişkenindeki harfler büyük harf aralığındamı kontrol edilip eğer o aralıktaysa buyukHarfSayisi değişkenine 1 eklensin..
               
                if (harf >= 'A' && harf <= 'Z')
                {
                    buyukHarfSayisi++;
                }
            }

            return buyukHarfSayisi;
        }

        static int KucukHarfSayisi(string sifre)
        {
            int kucukHarfSayisi = 0;
            char[] strSifre = sifre.ToCharArray();
            foreach (var harf in strSifre)
            {
                //parametre olarak gelen şifrenin her bir karakterini char şeklinde diziye çevirip o dizi içindeki harfleri tek tek kontrol etmek için döngüye sokuluyor.
                //döngüden gelen harf değişkenindeki harfler küçük harf aralığındamı kontrol edilip eğer o aralıktaysa kucukHarfSayisi değişkenine 1 ekleniyor.
               
                if (harf >= 'a' && harf <= 'z')
                {
                    kucukHarfSayisi++;
                }
            }

            return kucukHarfSayisi;
        }

        static int OzelKarakterSayisi(string sifre)
        {
            int ozelKarakterSayisi = 0;
            char[] strSifre = sifre.ToCharArray();
            foreach (var harf in strSifre)
            {
                //parametre olarak gelen şifrenin her bir karakterini char şeklinde diziye çevirip o dizi içindeki harfleri tek tek kontrol etmek için döngüye sokuluyor.
                
                //döngüden gelen harf değişkenindeki karakterlerin özel karakter olup olmadığı kontrol edilip eğer özel karakterse ozelKarakterSayisi değişkenine 1 ekleniyor.
               
                if (!char.IsLetterOrDigit(harf))
                {
                    ozelKarakterSayisi++;
                }
            }

            return ozelKarakterSayisi;
        }

        static int RakamSayisi(string sifre)
        {
            int rakamsayisi = 0;
            char[] strSifre = sifre.ToCharArray();
            foreach (var harf in strSifre)
            {
                //parametre olarak gelen şifrenin her bir karakterini char şeklinde diziye çevirip o dizi içindeki harfleri tek tek kontrol etmek için döngüye sokuluyor.
                
                //döngüden gelen harf değişkenindeki karakterlerin numerik olup olmadığı kontrol edilip eğer numerikse rakamsayisi değişkenine 1 ekleniyor.
                
                if (char.IsDigit(harf))
                {
                    rakamsayisi++;
                }
            }

            return rakamsayisi;
        }
    }
}
