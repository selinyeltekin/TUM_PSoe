using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
   public interface IArabaSur
    {
        void Calistir();
        void Sur();
        void Parket();
        void VitesDegistir(int vites);
        void Durdur();
    }

    public class Araba : IArabaSur    //interface classta bahsedilen methodlarin hepsi kullanilmadan error gecmiyor.
    {
        public void Calistir()
        {
            Console.WriteLine("Araba Calistirildi..");
        }

        public void Sur()
        {
            Console.WriteLine("Surus basladi.");
        }

        public void Parket()
        {
            Console.WriteLine("Park ediliyor.");
        }

        public void VitesDegistir(int vites)
        {
            Console.WriteLine(vites.ToString() + ". vitese gecildi");
        }
        public void Durdur()
        {
            Console.WriteLine("Rotaya geldik.");
        }
    }

    class Calistir
    {
        static void Ana(string[] args)
        {
            Araba mercedes = new Araba();
            mercedes.Calistir();
            mercedes.Sur();
            mercedes.VitesDegistir(3);
            mercedes.Parket();
            mercedes.Durdur();

            Console.ReadKey();
        }
    }
}
