using System;

namespace Odev2_5_Mayis22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //odev2 ornek1 Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti alınmamaktadır. Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren program.
            /*
             double fiyat, kargo, toplam=0;
             Console.WriteLine("Ürün fiyatını giriniz: ");
             fiyat = double.Parse(Console.ReadLine());

             if (fiyat>=100)
             {
                 kargo = 0;
                 toplam = fiyat;
             }
             else
             {
                 kargo = 5;
                 toplam = fiyat + kargo;
             }

             Console.WriteLine("Ödenecek tutar: "+toplam);
             Console.ReadKey(); 

             */

            // odev2 ornek 2 Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu gösteren programın C# kodlarını yazalım.
            /*
            int sayi;
            Console.WriteLine("Bir sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi>0)
            {
                Console.WriteLine("Sayı pozitif." );
            }
            else if (sayi<0)
            {
                Console.WriteLine("sayı negatif.");
            }
            else
            {
                Console.WriteLine("Sayı sıfır.");
            }
            */

            //odev2 ornek3 Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

            /*
            double urun1, urun2, toplam = 0;
            Console.WriteLine("ilk ürünün fiyatını giriniz: ");
            urun1=double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci ürünün fiyatını giriniz: ");
            urun2 = double.Parse(Console.ReadLine());
            toplam = urun1 + urun2;

            if (toplam>200)
            {
                urun2 = urun2 - (urun2 / 4);
                toplam = urun1 + urun2;
                Console.WriteLine("Ödenecek tutar: " + toplam);
            }
            else
            {
                Console.WriteLine("Ödenecek tutar: "+toplam);
            }
            Console.ReadKey();  
            */

            //odev2 ornek4 Kullanıcının girdiği 5 sayıdan 50′ den büyük olanların toplamını gösteren Console Örneği.(For Döngüsü)
            /*
            int sayi, toplam=0;

            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine(i+". sayıyı girin:");
                sayi = int.Parse(Console.ReadLine());

                if (sayi>50)
                {
                    toplam = toplam + sayi;

                }
            }

            Console.WriteLine("50'den büyük sayıların toplamı: " + toplam);
            */

            //odev2 ornek5 Klavyeden girilen bir cümlenin harflerini tek tek yazdıran örnek. (Alt alta), Karakterlerin arasına –“tire” koyarak yazdırma. (For Döngüsü)
            // bir strin ifadenin karakter sayısını Length metoduyla bulunur. 
            //Console.WriteLine(cumle.Length); 
            /*
                        string cumle;
                        Console.WriteLine("Bir cümle giriniz: ");
                        cumle= Console.ReadLine();

                        for (int i = 0; i < cumle.Length; i++)
                            Console.WriteLine(cumle[i]);   //harfleri alt alta yazdırıyor. TİRE koyamamdım?? 
                            //Console.WriteLine(cumle.Length); //karakter sayısını buluyor.
            */

            //odev2 ornek6 Kullanıcının girmiş olduğu sayının basamak sayısını While Döngüsü kullanarak bulan programı yapınız.(while döngüsü)
            /*
            int sayi,basamak=0;
            Console.WriteLine("bir sayı giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            while (sayi>0)
            {
                sayi/=10; //bu satırı pek anlamadım
                basamak++;  
            }
            Console.WriteLine("Girdiğiniz sayı "+basamak+" basamaklıdır.");
            */

            //odev2 ornek 7 Sayı 0 olduğunda döngünün bitirme (while döngüsü)


        }
    }
}
