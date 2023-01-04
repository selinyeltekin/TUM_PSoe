using System;

namespace Sinav1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////SORU 1
            /**
            int teksayi = 0, ciftsayi = 0;
            int sayi;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sayi=Convert.ToInt32(Console.ReadLine());
                if (sayi%2==0)
                {
                    ciftsayi++;
                }
                else
                {
                    teksayi++;
                }
            }
            Console.WriteLine(ciftsayi+"tane cift sayi,"+teksayi+"tane tek sayı vardır.");
            **/
            ///////////////SORU 2
            /**
            int fiyat;
            int yenifiyat;
            Console.WriteLine("bir fiyat giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
            if(fiyat<=100)
            {
                yenifiyat = fiyat-(fiyat*20/100);
                Console.WriteLine("Ödenecek tutar:" + yenifiyat);
            }
            else if(100<fiyat && fiyat<=200)
            {
                yenifiyat=fiyat - (fiyat*30/100);
                Console.WriteLine("Ödenecek tutar:" + yenifiyat);
            }
            else if (fiyat>200)
            {
                yenifiyat=fiyat - (fiyat * 40/100);
                Console.WriteLine("Ödenecek tutar:" + yenifiyat);
            }
            else
            {
                Console.WriteLine("gecersiz fiyat girdiniz");
            }
            **/
            ///////////////SORU 3

        }
    }
}
