using System;

namespace Generics_Ex
{
    /*
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    */





    //--------------Gencay Yildiz GENERICS------

    class Program
    {
        /* Aciklama-Tanimlama-  Generic base Class Constraint
         
        static void Main(string[] args)
        {
            #region Aciklama-Tanimlama
            //Yazmis oldugum class a ornek tipini veriyorum ve hemen referansimi olusturup yine ayni sekilde nesnemi bagliyorum. 
            //Yani MyClass a tanimladigimiz T, Ornek e donusuyor.
           
            //MyClass<A> m1 = new MyClass<A>();
            //MyClass<B> m1 = new MyClass<B>();
            //MyClass<C> m1 = new MyClass<C>();
            //MyClass<D> m2 = new MyClass<D>(); // D olmadi cunku C den kalitim aliyor.

            //1. Aciklama ve Tanimlama YAPILDI
            //2. Generic base Class Constraint Yapiliyor, : li kisim
            //3. Generic New Constraint
            #endregion
        }
    }

    //Icine bir degisken tanimliyoruz, genellikle Type kelimesinin ilk harfi olan T
    class MyClass<T> where T : A  //T tipi A veya A dan tureyen siniflari temsil edebilir. 
    {                    //T : class ta yazabilirdik bu T tipinin class oldugunu gosterirdi. ne verilirse verilsin bir sinif verilsin.
        T t;

        public void X()   //X adinda bir method olusturdum.
        {
            //t = new T();   //Nesne tanimi yapmak istedim ama ERROR verdi cunku T ye verilen tipin nesne olusturamama ihtimali var. Bundan dolayi Generic class ta bu duurm icin onceden onlem alinmasi lazim.
        }
    }

    //T parametresi A veya A dan tureyebilen siniflara refere edebilsin.
    class A
    {

    }

    class B : A
    {

    }

    class C : B
    {

    }

    class D
    {

    }

    */
        static void Main(string[] args)
        {
            #region Generic New Constrait
            #endregion

            Console.Read();
        }

        // Generic Class a ayni anda hem Base Class Constrait ve New Constraint tanimi yapilabilir. 
        class MyClass<T> where T : MyClass2, new()//new constraint tanimi yaptik.
        {
            public void X()
            {
                T t1 = new T();    // new constrait uygulanmadigi icin hata veriyor.
            }
        }

        class MyClass2
        {

        }
    }
}