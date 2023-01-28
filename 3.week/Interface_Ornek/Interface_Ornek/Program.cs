using System;

namespace Interface_Ornek
{
   public interface Iislemler
    {
        void islemgoster();
        double tutargetir();
    }

    public class IslemNo : Iislemler
    {
        private string islemkodu;
        private string Tarih;
        private double Tutar;
        public IslemNo()     //Method
        {
            islemkodu = "";
            Tarih = "";
            Tutar = 0.0;
        }

        public IslemNo(string c, string d, double a)
        {
            islemkodu = c;
            Tarih = d;
            Tutar = a;
        }
        //interfaceler, interface bir class in icine bos method tanimi yapmamizi ve bunu diger classlar icinde kullanmamizi saglar. Bu bos methodlarin ici inherit edilen yerde tanimlanir.
        public double tutargetir()
        {
            return Tutar;
        }
        public void islemgoster()
        {
            Console.WriteLine("Islem No : {0}", islemkodu);
            Console.WriteLine("Tarih: {0}", Tarih);
            Console.WriteLine("Tutar: {0}", tutargetir());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IslemNo islem1 = new IslemNo("001", "8/10/2012", 78900.00);
            IslemNo islem2 = new IslemNo();
            IslemNo islem3 = new IslemNo("002", "9/10/2012", 451900.00);
            islem1.islemgoster();
            islem2.islemgoster();
            islem3.islemgoster();

            Console.ReadKey();
        }
    }
}
