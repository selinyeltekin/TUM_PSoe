using System;

namespace Odev1_selin_26_Nisan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /////odev1-ornek1 1 for dongusu kullanarak kullanicidan aldigi 10 adet sayiyi toplayarak ekranda gosteren uygulama.

            /*
            int sayi, toplam = 0;
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
            }

            Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);


            */

            // odev1-ornek2 1-100 arası 3’e tam bölünemeyen sayıları listeleyen uygulama.

            /*
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i % 3 !=0) //i % 3 == 1 && i % 3 ==2 yazınca olmadı neden??
                            { Console.WriteLine(i); }
                        }
                       // Console.ReadKey();
                    }
                    */

            // odev1-ornek3 Kullanıcının gireceği 5 adet sayıdan kaç tanesinin 10 ile 20 arasında olduğunu sayan örnek.

            /*
            int sayi, adet = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + ". sayıyı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                
            if (10 < sayi && sayi < 20)
                {
                    adet++;
                }
                Console.WriteLine(adet+" tane 10 ile 20 arasında sayı var.");
            }
            */



            //odev1-ornek4 1 ile 100 arasındaki çift sayıları toplayarak sonucu ekranda yazdıran örnek:


            /*
            int toplam = 0;
            for (int sayi = 1; sayi < 101; sayi++)
            {
                if (sayi%2==0)
                {
                    toplam = toplam + sayi;
                }
            }
            Console.WriteLine("toplam: " + toplam);

            */


            //odev1-ornek5 Kullanıcının girdiği 10 sayıdan çift olan sayı adetini gösteren örnek:

            /*
            int sayi, adet = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Lütfen "+i+ ". sayıyı giriniz: ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi%2==0)
                {
                    adet++;
                }
               
            }
            Console.WriteLine(adet + " tane çift sayı girdiniz.");
            Console.ReadKey();
            */

        }
    }
}

